using Movie_Catalog.Helper.Storage;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog.User_Controls
{
    partial class WatchingListItem : UserControl
    {
        public WatchingListItem(MySqlDataReader movie)
        {
            InitializeComponent();

            setMoviePoster(movie);

            setMovieTitle(movie);

            setPosistionInformation(movie);

            setLastWatchedInformation(movie);

            setPlayButtonAttr(movie);
        }

        private void setMoviePoster(MySqlDataReader movie)
        {
            // ambil gambar lokal dan pasangkan ke picturebox
            using (Bitmap bmpTemp = new Bitmap(
                    PosterStorage.GetFile(
                        movie["poster_path"].ToString()
                    )
                ))
            {
                MoviePoster.Image = new Bitmap(bmpTemp);
            }
        }

        private void setMovieTitle(MySqlDataReader movie)
        {
            // melakukan sedikit format teks, yang bertujuan untuk menggabungkan title dengan tahun film dikeluarkan
            DateTime dt = DateTime.Parse(movie["release_year"].ToString());
            string titleFormat = String.Format("{0} ({1:yyyy})", movie["title"].ToString(), dt);
            // set title sesuai dengan format
            MovieTitle.Text = titleFormat;
        }

        private void setPosistionInformation(MySqlDataReader movie)
        {
            double currentPositionHour = Math.Floor(((Convert.ToDouble(movie["current_position"].ToString()) / (1000 * 60 * 60)) % 24));
            double currentPositionMinute = Math.Floor((Convert.ToDouble(movie["current_position"].ToString()) / 1000) % 60);
            double currentPositionSecond = Math.Floor(((Convert.ToDouble(movie["current_position"].ToString()) / (1000 * 60)) % 60));

            double MovieDurationHour = Math.Floor(((Convert.ToDouble(movie["movie_duration"].ToString()) / (1000 * 60 * 60)) % 24));
            double movieDurationMinute = Math.Floor((Convert.ToDouble(movie["movie_duration"].ToString()) / 1000) % 60);
            double movieDurationSecond = Math.Floor(((Convert.ToDouble(movie["movie_duration"].ToString()) / (1000 * 60)) % 60));

            PositionInformation.Text = String.Format("{0}h{1}m{2}s / {3}h{4}m{5}s", currentPositionHour, currentPositionMinute, currentPositionSecond, MovieDurationHour, movieDurationMinute, movieDurationSecond);
        }

        private void setLastWatchedInformation(MySqlDataReader movie)
        {
            DateTime last_watched = DateTime.Parse(movie["last_watched_date"].ToString());
            DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan = (currentDate - last_watched);

            string lastWatchedText = "Last watched : ";

            // cek perbedaan hari
            if (timeSpan.Days > 0)
            {
                LastWatchedInformation.Text = lastWatchedText + Convert.ToString(timeSpan.Days) + (timeSpan.Days > 1 ? " days" : " day");
            }
            else
            {
                // jika hari 0 maka masih dalam jangka waktu jam
                if (timeSpan.Hours > 0)
                {
                    LastWatchedInformation.Text = lastWatchedText + Convert.ToString(timeSpan.Hours) + (timeSpan.Hours > 1 ? " hours" : " hour");
                }
                else
                {
                    // jika jam 0 maka masih dalam jangka waktu menit
                    if (timeSpan.Minutes > 0)
                    {
                        LastWatchedInformation.Text = lastWatchedText + Convert.ToString(timeSpan.Minutes) + (timeSpan.Minutes > 1 ? " minutes" : " minute");
                    }
                    else
                    {
                        // selain dari itu berarti detik
                        LastWatchedInformation.Text = lastWatchedText + Convert.ToString(timeSpan.Seconds) + (timeSpan.Seconds > 1 ? " seconds" : " second");
                    }
                }
            }
        }

        private void setPlayButtonAttr(MySqlDataReader movie)
        {
            PlayButton.Name = movie["id"].ToString();
            PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            SqlConnector DBC = new SqlConnector();

            string query = "SELECT m.id, m.title, m.description, m.release_year, m.poster_path, m.movie_path, lw.current_position, lw.movie_duration, lw.last_watched_date FROM last_watched as lw, movies as m WHERE m.id=lw.movie_id and m.id=@movie_id";

            MySqlCommand command = new MySqlCommand(query, DBC.connection);
            command.Parameters.Add("@movie_id", MySqlDbType.Int64);
            command.Parameters["@movie_id"].Value = button.Name;

            try
            {
                DBC.connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Dictionary<string, string> Movie = new Dictionary<string, string>();

                    Movie["id"] = reader["id"].ToString();
                    Movie["title"] = reader["title"].ToString();
                    Movie["description"] = reader["description"].ToString();
                    Movie["release_year"] = reader["release_year"].ToString();
                    Movie["poster_path"] = reader["poster_path"].ToString();
                    Movie["movie_path"] = reader["movie_path"].ToString();
                    Movie["current_position"] = reader["current_position"].ToString();
                    Movie["movie_duration"] = reader["movie_duration"].ToString();
                    Movie["last_watched_date"] = reader["last_watched_date"].ToString();

                    VideoPlayer videoPlayer = new VideoPlayer(Movie);
                    videoPlayer.ShowDialog();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBC.connection.Close();
            }
        }
    }
}
