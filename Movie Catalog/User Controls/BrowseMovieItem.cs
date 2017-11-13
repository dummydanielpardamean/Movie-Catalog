using Movie_Catalog.Helper.Storage;
using Movie_Catalog.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog.User_Controls
{
    partial class BrowseMovieItem : UserControl
    {
        public static string ClickedMovieID;

        public BrowseMovieItem(Movie movie)
        {
            InitializeComponent();

            setMoviePoster(movie);

            setMovieTitle(movie);

            setOpenButtonAttr(movie);
        }

        private void setMoviePoster(Movie movie)
        {
            MoviePoster.Image = Image.FromFile(
                    PosterStorage.GetFile(movie.PosterPath)
                );
        }

        private void setMovieTitle(Movie movie)
        {
            MovieTitle.Text = String.Format("{0} ({1:yyyy})", movie.Title, DateTime.Parse(movie.ReleaseYear));
        }

        private void setOpenButtonAttr(Movie movie)
        {
            OpenButton.Name = movie.ID;
            OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            ClickedMovieID = Convert.ToString(button.Name);

            MovieDetail movieDetail = new MovieDetail();
            movieDetail.ShowDialog();
        }
    }
}
