using Movie_Catalog.ClassSchema;
using Movie_Catalog.Helper.Storage;
using Movie_Catalog.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Movie_Catalog
{
    partial class VideoPlayer : Form
    {
        private DBConnector DBC;

        private Movie Movie;

        private static double CurrentPosition;

        private static double MovieDurationLength;

        public VideoPlayer(Movie movie)
        {
            DBC = new DBConnector();

            Movie = movie;

            InitializeComponent();

            if (movie.MoviePath != null)
            {
                string uri = new Uri(
                        MovieStorage.GetFile(movie.MoviePath)
                    ).AbsoluteUri;

                axVLCPlugin21.playlist.add(uri);
                axVLCPlugin21.playlist.play();

                string query = String.Format("SELECT * FROM last_watched WHERE movie_id = '{0}';",
                    Movie.ID
                );

                List<LastWatched> result = DBC.SelectForLastWatched(query);

                if (result.Count > 0)
                    axVLCPlugin21.input.time = Convert.ToDouble(result[0].current_position);
                else
                    axVLCPlugin21.input.time = 0;
            }
        }

        private void axVLCPlugin21_MediaPlayerStopped(object sender, EventArgs e)
        {
            string query;

            // set up query untuk mengecek apa ada record dengan movie_id yang diberikan
            query = String.Format("SELECT * FROM last_watched WHERE movie_id = '{0}';",
                    Movie.ID
                );

            // jika ada record
            if (DBC.SelectForLastWatched(query).Count > 0)
            {
                // perbarui data.
                query = String.Format("UPDATE last_watched SET current_position = '{1}', movie_duration = '{2}', last_watched_date = '{3}' WHERE movie_id = '{0}';",
                    Movie.ID,
                    CurrentPosition,
                    MovieDurationLength,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                );

                DBC.Update(query);
            }
            else
            {
                // jika tidak, buat record
                query = String.Format("INSERT INTO last_watched (movie_id, current_position, movie_duration, last_watched_date) VALUES ('{0}', '{1}', '{2}', '{3}');",
                    Movie.ID,
                    CurrentPosition,
                    MovieDurationLength,
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                );

                DBC.Insert(query);
            }
        }

        private void axVLCPlugin21_MediaPlayerPositionChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerPositionChangedEvent e)
        {
            // Terkadang time mengembalikan nilai -1
            // ini dapat menyebabkan kesalahan dalam mencatat posisi tontonan terakhir
            // jadi dilakukan conditional didalam memperbarui value CurrentPostion
            if (axVLCPlugin21.input.time != -1)
                CurrentPosition = axVLCPlugin21.input.time;
        }

        private void axVLCPlugin21_MediaPlayerLengthChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerLengthChangedEvent e)
        {
            MovieDurationLength = axVLCPlugin21.input.length;
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            // jika film sudah diputar sampai habis
            // akan dilakukan penghapusan record history tontonan
            string query = String.Format("DELETE FROM last_watched WHERE movie_id = '{0}';",
                    Movie.ID
                );
            DBConnector DBC = new DBConnector();

            if(DBC.Delete(query))
                this.Close();
        }
    }
}
