using Movie_Catalog.Helper.Storage;
using Movie_Catalog.User_Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Catalog
{
    public partial class MovieDetail : Form
    {
        private DBConnector DBC;

        private Dictionary<string, string> Movie;

        public MovieDetail()
        {
            DBC = new DBConnector();

            InitializeComponent();

            getMovieInformation();

            setMoviePoster(Movie);

            setMovieTitle(Movie);

            setMovieDescription(Movie);
        }

        private void getMovieInformation()
        {
            try
            {
                DBC.connection.Open();

                string query = "select * from movies where id=@movie_id";
                MySqlCommand command = new MySqlCommand(query, DBC.connection);
                command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                command.Parameters["@movie_id"].Value = BrowseMovieItem.ClickedMovieID;

                MySqlDataReader reader = command.ExecuteReader();

                Movie = new Dictionary<string, string>();

                if (reader.Read())
                {
                    Movie["id"] = reader["id"].ToString();
                    Movie["title"] = reader["title"].ToString();
                    Movie["description"] = reader["description"].ToString();
                    Movie["release_year"] = reader["release_year"].ToString();
                    Movie["poster_path"] = reader["poster_path"].ToString();
                    Movie["movie_path"] = reader["movie_path"].ToString();
                    Movie["subtitle_path"] = reader["subtitle_path"].ToString();
                    Movie["created_at"] = reader["created_at"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBC.connection.Close();
            }
        }

        private void setMoviePoster(Dictionary<string, string> Movie)
        {
            using (var bmpTemp = new Bitmap(PosterStorage.GetFile(Movie["poster_path"].ToString())))
            {
                MoviePoster.Image = new Bitmap(bmpTemp);
            }
        }

        private void setMovieTitle(Dictionary<string, string> Movie)
        {
            DateTime dateTime = DateTime.Parse(Movie["release_year"].ToString());
            MovieTitle.Text = String.Format("{0} ({1:yyyy})", Movie["title"].ToString(), dateTime);
        }

        private void setMovieDescription(Dictionary<string, string> Movie)
        {
            MovieDescription.Text = Movie["description"].ToString();
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
                string query = "Select * from movies where id=@movie_id";

                MySqlCommand command = new MySqlCommand(query, DBC.connection);
                command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                command.Parameters["@movie_id"].Value = BrowseMovieItem.ClickedMovieID;

                try
                {
                    DBC.connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MovieStorage movieStorage = new MovieStorage(reader["movie_path"].ToString());
                        movieStorage.Delete();

                        MoviePoster.Image.Dispose();

                        PosterStorage posterStorage = new PosterStorage(reader["poster_path"].ToString());
                        posterStorage.Delete();

                        SubtitleStorage subtitleStorage = new SubtitleStorage(reader["subtitle_path"].ToString());
                        subtitleStorage.Delete();

                        DBC.connection.Close();

                        DBC.connection.Open();

                        query = "DELETE FROM movies WHERE id= @movie_id";

                        command = new MySqlCommand(query, DBC.connection);
                        command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                        command.Parameters["@movie_id"].Value = BrowseMovieItem.ClickedMovieID;

                        if (command.ExecuteNonQuery() != -1)
                        {
                            DBC.connection.Close();

                            DBC.connection.Open();

                            query = "DELETE FROM last_watched WHERE movie_id= @movie_id";

                            command = new MySqlCommand(query, DBC.connection);
                            command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                            command.Parameters["@movie_id"].Value = BrowseMovieItem.ClickedMovieID;

                            if (command.ExecuteNonQuery() != -1)
                                this.Close();
                            else
                                Console.WriteLine("Film tidak berhasil di hapus");
                        }
                        else
                        {
                            Console.WriteLine("Film tidak berhasil di hapus");
                        }
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
}
