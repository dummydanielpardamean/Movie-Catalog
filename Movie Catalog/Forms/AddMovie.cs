using Movie_Catalog.Helper.Storage;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Movie_Catalog
{
    public partial class AddMovie : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private SearchMovie SM = null;

        // Menyimpan Path video yang akan di list.
        private string MoviePath;

        public AddMovie()
        {
            InitializeComponent();
        }

        // Event Listener yang akan menerima data dari form Search Movie.
        void SearchMovie_OnDataAvailable(object sender, EventArgs e)
        {
            MovieTitle.Text = Convert.ToString(
                    SM.Title
                );

            MovieDescription.Text = Convert.ToString(
                    SM.Description
                );

            MovieID.Text = SM.ID;

            string[] date = SM.ReleaseDate.Split('-');
            MovieReleaseYear.Value = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));

            Thread fetchPosterThread = new Thread(new ThreadStart(fetchPoster));
            fetchPosterThread.Start();
        }

        private void InitializeSearchMovieForm()
        {
            this.SM = new SearchMovie();
            // Search event handler untuk data binding.
            SM.OnDataAvailable += new EventHandler(SearchMovie_OnDataAvailable);
            SM.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //ValidateInputs();

            SaveButton.Text = "SAVING...";

            MovieStorage movieStorage = new MovieStorage(MovieID.Text, this.MoviePath);
            SubtitleStorage subtitleStorage = new SubtitleStorage(MovieID.Text, SubtitlePathLabel.Text);
            PosterStorage posterStorage = new PosterStorage(MovieID.Text, MoviePoster);

            DBConnector DBC = new DBConnector();

            string query = "INSERT INTO movies (id, title, description, release_year, poster_path, movie_path, subtitle_path) VALUES (@id, @title, @description, @release_year, @poster_path, @movie_path, @subtitle_path)";

            MySqlCommand command = new MySqlCommand(query, DBC.connection);
            command.Parameters.Add("@id", MySqlDbType.Int64);
            command.Parameters.Add("@title", MySqlDbType.String);
            command.Parameters.Add("@description", MySqlDbType.String);
            command.Parameters.Add("@release_year", MySqlDbType.Date);
            command.Parameters.Add("@poster_path", MySqlDbType.String);
            command.Parameters.Add("@movie_path", MySqlDbType.String);
            command.Parameters.Add("@subtitle_path", MySqlDbType.String);

            command.Parameters["@id"].Value = MovieID.Text;
            command.Parameters["@title"].Value = MovieTitle.Text;
            command.Parameters["@description"].Value = MovieDescription.Text;
            command.Parameters["@release_year"].Value = MovieReleaseYear.Value.ToString("yyyy-MM-dd");
            command.Parameters["@poster_path"].Value = posterStorage.GetName();
            command.Parameters["@movie_path"].Value = movieStorage.GetName();
            command.Parameters["@subtitle_path"].Value = subtitleStorage.GetName();


            try
            {
                DBC.connection.Open();
                
                if(command.ExecuteNonQuery() != -1)
                {
                    movieStorage.Run();
                    posterStorage.Run();
                    subtitleStorage.Run();

                    SaveButton.Text = "SAVE";

                    MessageBox.Show("Berhasil disimpan.");

                    this.Close();
                }
                else
                {
                    SaveButton.Text = "SAVE";
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (checkInternetConnection())
                this.InitializeSearchMovieForm();
            else
                MessageBox.Show("Internet is not available");
        }

        private void fetchPoster()
        {
            WebRequest request = WebRequest.Create("https://image.tmdb.org/t/p/w500" + SM.PosterPath);

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                MoviePoster.Image = Bitmap.FromStream(stream);
            }
        }

        public void ValidateInputs()
        {
            if (MovieTitle.Text == "") throw new Exception("Judul film harus diisi");
        }

        private bool checkInternetConnection()
        {
            return InternetGetConnectedState(out int Desc, 0);
        }

        private void MovieFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                RestoreDirectory = true,
                ValidateNames = true,
                Filter = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                        " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm"
            };

            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.MoviePathLabel.Text = this.MoviePath = ofd.FileName;
            }
        }

        private void MoviePoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                RestoreDirectory = true,
                ValidateNames = true,
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.MoviePoster.Image = Image.FromFile(@ofd.FileName);
            }
        }

        private void MovieSubtitle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.SubtitlePathLabel.Text = ofd.FileName;
            }
        }
    }
}
