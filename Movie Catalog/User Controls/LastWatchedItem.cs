using Movie_Catalog.Helper.Storage;
using Movie_Catalog.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog.User_Controls
{
    partial class LastWatchedItem : UserControl
    {
        public LastWatchedItem(Movie movie)
        {
            InitializeComponent();

            setMoviePoster(movie);

            setMovieTitle(movie);

            setPosistionInformation(movie);

            setLastWatchedInformation(movie);

            setPlayButtonAttr(movie);
        }

        private void setMoviePoster(Movie movie)
        {
            // ambil gambar lokal dan pasangkan ke picturebox
            MoviePoster.Image = Image.FromFile(
                    PosterStorage.GetFile(movie.PosterPath)
                );
        }

        private void setMovieTitle(Movie movie)
        {
            // melakukan sedikit format teks, yang bertujuan untuk menggabungkan title dengan tahun film dikeluarkan
            DateTime dt = DateTime.Parse(movie.ReleaseYear);
            string titleFormat = String.Format("{0} ({1:yyyy})", movie.Title, dt);
            // set title sesuai dengan format
            MovieTitle.Text = titleFormat;
        }

        private void setPosistionInformation(Movie movie)
        {
            double currentPositionHour = Math.Floor(((movie.CurrentPosition / (1000 * 60 * 60)) % 24));
            double currentPositionMinute = Math.Floor((movie.CurrentPosition / 1000) % 60);
            double currentPositionSecond = Math.Floor(((movie.CurrentPosition / (1000 * 60)) % 60));

            double MovieDurationHour = Math.Floor(((movie.MovieDuration / (1000 * 60 * 60)) % 24));
            double movieDurationMinute = Math.Floor((movie.MovieDuration / 1000) % 60);
            double movieDurationSecond = Math.Floor(((movie.MovieDuration / (1000 * 60)) % 60));

            PositionInformation.Text = String.Format("{0}h{1}m{2}s / {3}h{4}m{5}s", currentPositionHour, currentPositionMinute, currentPositionSecond, MovieDurationHour, movieDurationMinute, movieDurationSecond);
        }

        private void setLastWatchedInformation(Movie movie)
        {
            DateTime last_watched = DateTime.Parse(movie.LastWatchedDate);
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

        private void setPlayButtonAttr(Movie movie)
        {
            PlayButton.Name = movie.ID;
            PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            DBConnector DBC = new DBConnector();

            string query = String.Format("SELECT m.id, m.title, m.description, m.release_year, m.poster_path, m.movie_path, lw.current_position, lw.movie_duration, lw.last_watched_date FROM last_watched as lw, movies as m WHERE m.id=lw.movie_id and m.id='{0}'", button.Name);

            List<Movie> Movies = DBC.SelectForMoviePlus(query);

            VideoPlayer videoPlayer = new VideoPlayer(Movies[0]);
            videoPlayer.ShowDialog();
        }
    }
}
