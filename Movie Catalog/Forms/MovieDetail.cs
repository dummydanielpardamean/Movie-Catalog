using Movie_Catalog.Interfaces;
using Movie_Catalog.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog
{
    public partial class MovieDetail : Form
    {
        private Movie Movie;

        public MovieDetail()
        {
            InitializeComponent();

            getMovieInformation();

            setMoviePoster();

            setMovieTitle();

            setMovieDescription();
        }

        private void getMovieInformation()
        {
            DBConnector DBC = new DBConnector();

            string query = String.Format("select * from movies where id='{0}'", BrowseMovieItem.ClickedMovieID);

            List<Movie> Movies = DBC.SelectForBrowseMovie(query);

            Movie = Movies[0];
        }

        private void setMoviePoster()
        {
            Storage storage = new Storage();
            MoviePoster.Image = Image.FromFile(@storage.GetPoster(Movie));
        }

        private void setMovieTitle()
        {
            DateTime dateTime = DateTime.Parse(Movie.ReleaseYear);
            MovieTitle.Text = String.Format("{0} ({1:yyyy})", Movie.Title, dateTime);
        }

        private void setMovieDescription()
        {
            MovieDescription.Text = Movie.Description;
        }

        private void PlayMovieButton_Click(object sender, EventArgs e)
        {
            VideoPlayer videoPlayer = new VideoPlayer(Movie);
            videoPlayer.ShowDialog();
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hapus film ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBConnector DBC = new DBConnector();

                string query = String.Format("DELETE FROM movies WHERE id= '{0}'",
                        BrowseMovieItem.ClickedMovieID
                    );

                if (DBC.Delete(query))
                {
                    query = String.Format("DELETE FROM last_watched WHERE movie_id= '{0}'",
                            BrowseMovieItem.ClickedMovieID
                        );

                    DBC = new DBConnector();

                    if (DBC.Delete(query))
                        this.Close();
                    else
                        Console.WriteLine("Film tidak berhasil di hapus");
                }
                else
                {
                    Console.WriteLine("Film tidak berhasil di hapus");
                }
            }
            
        }
    }
}
