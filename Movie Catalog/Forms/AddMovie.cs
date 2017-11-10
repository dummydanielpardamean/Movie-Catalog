using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;

namespace Movie_Catalog
{
    public partial class AddMovie : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private SearchMovie SM = null;

        // Menyimpan Path video yang akan di list.
        private string MoviePath;

        Storage movieStorage, subtitleStorage, posterStorage;

        public AddMovie()
        {
            InitializeComponent();
        }

        // Event Listener yang akan menerima data dari form Search Movie.
        void SearchMovie_OnDataAvailable(object sender, EventArgs e)
        {
            TitleAddMovieButton.Text = Convert.ToString(SM.Title);

            DescriptionLabelField.Text = Convert.ToString(SM.Description);

            string[] date = SM.ReleaseDate.Split('-');
            DTPReleaseYear.Value = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));

            Thread fetchPosterThread = new Thread(new ThreadStart(fetchPoster));
            fetchPosterThread.Start();
        }

        private void fetchPoster()
        {
            WebRequest request = WebRequest.Create("https://image.tmdb.org/t/p/w500" + SM.PosterPath);

            using (WebResponse response = request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                PosterPreviewPictureBox.Image = Bitmap.FromStream(stream);
            }
        }

        private void InitializeSearchMovieForm()
        {
            this.SM = new SearchMovie();
            // Search event handler untuk data binding.
            SM.OnDataAvailable += new EventHandler(SearchMovie_OnDataAvailable);
            SM.ShowDialog();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
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
                if(ofd.ShowDialog() == DialogResult.OK)
                    this.MoviePathLabel.Text = this.MoviePath = ofd.FileName;
            }
        }

        private void PosterPreviewPictureBox_Click(object sender, EventArgs e)
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
                    this.PosterPreviewPictureBox.Image = Image.FromFile(@ofd.FileName);
            }
        }

        private void OpenFileSubtitleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            using (ofd)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.SubtitlePathLabel.Text = ofd.FileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Text = "SAVING...";

            this.movieStorage = new Storage(SM.ID, this.MoviePath);
            this.subtitleStorage = new Storage(SM.ID, this.SubtitlePathLabel.Text);
            this.posterStorage = new Storage(SM.ID, null, true);

            DBConnector DBC = new DBConnector();

            string query = String.Format("INSERT INTO movies (title, description, release_year, poster_path, movie_path, id) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                TitleAddMovieButton.Text,
                DescriptionLabelField.Text,
                DTPReleaseYear.Value.ToString("yyyy-MM-dd"),
                posterStorage.fileName,
                movieStorage.fileName,
                SM.ID
            );

            if (DBC.Insert(query))
            {
                Thread t1 = new Thread(new ThreadStart(saveToLocalDir));
                t1.Start();

                t1.Join();

                SaveButton.Text = "SAVE";

                MessageBox.Show("Berhasil disimpan.");

                this.Close();
            }
        }

        private void saveToLocalDir()
        {
            //Invoke((MethodInvoker)(() => {
                
            //}));

            movieStorage.MoveMovie();
            subtitleStorage.MoveSubtitle();
            posterStorage.MoveImage(PosterPreviewPictureBox);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (checkInternetConnection())
                this.InitializeSearchMovieForm();
            else
                MessageBox.Show("Internet is not available");
        }

        private bool checkInternetConnection()
        {
            return InternetGetConnectedState(out int Desc, 0);
        }
        
    }
}
