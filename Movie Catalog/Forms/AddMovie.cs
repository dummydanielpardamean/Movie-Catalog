using Movie_Catalog.Helper.Storage;
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
            ValidateInputs();

            SaveButton.Text = "SAVING...";

            MovieStorage movieStorage = new MovieStorage(MovieID.Text, this.MoviePath);
            SubtitleStorage subtitleStorage = new SubtitleStorage(MovieID.Text, SubtitlePathLabel.Text);
            PosterStorage posterStorage = new PosterStorage(MovieID.Text, MoviePoster);

            DBConnector DBC = new DBConnector();

            string query = String.Format("INSERT INTO movies (title, description, release_year, poster_path, movie_path, id) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                MovieTitle.Text,
                MovieDescription.Text,
                MovieReleaseYear.Value.ToString("yyyy-MM-dd"),
                posterStorage.GetName(),
                movieStorage.GetName(),
                MovieID.Text
            );

            if (DBC.Insert(query))
            {
                movieStorage.Run();
                posterStorage.Run();
                subtitleStorage.Run();

                SaveButton.Text = "SAVE";

                MessageBox.Show("Berhasil disimpan.");

                this.Close();
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
