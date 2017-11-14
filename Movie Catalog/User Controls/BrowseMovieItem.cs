using Movie_Catalog.Helper.Storage;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog.User_Controls
{
    partial class BrowseMovieItem : UserControl
    {
        public static string ClickedMovieID;

        public BrowseMovieItem(MySqlDataReader movie)
        {
            InitializeComponent();

            setMoviePoster(movie);

            setMovieTitle(movie);

            setOpenButtonAttr(movie);
        }

        private void setMoviePoster(MySqlDataReader movie)
        {
            MoviePoster.Image = Image.FromFile(
                    PosterStorage.GetFile(movie["poster_path"].ToString())
                );
        }

        private void setMovieTitle(MySqlDataReader movie)
        {
            MovieTitle.Text = String.Format("{0} ({1:yyyy})", movie["title"].ToString(), DateTime.Parse(movie["release_year"].ToString()));
        }

        private void setOpenButtonAttr(MySqlDataReader movie)
        {
            OpenButton.Name = movie["id"].ToString();
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
