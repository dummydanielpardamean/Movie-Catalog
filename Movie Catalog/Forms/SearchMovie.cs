using System;
using System.Net;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Movie_Catalog.JSONSchema.SearchSchema;
using System.Threading;

namespace Movie_Catalog
{
    public partial class SearchMovie : Form
    {
        public event EventHandler OnDataAvailable;

        public string ID { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string PosterPath { get; private set; }
        public string ReleaseDate { get; private set; }

        public SearchMovie()
        {
            InitializeComponent();
            MovieDGV.CellClick += MovieDGV_CellClick;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.SearchFieldTextBox.Text != "")
            {
                FetchingStatus.Text = "Fetching data...";
                Thread fetchMovieInformationThread = new Thread(new ThreadStart(fetchMovieInformation));
                fetchMovieInformationThread.Start();
                return;
            }

            MessageBox.Show("Keyword belum diisi");
        }

        private void fetchMovieInformation()
        {
            using (WebClient webClient = new WebClient())
            {
                string URL = String.Format("https://api.themoviedb.org/3/search/movie?api_key=25a50153584853f213f4dbe652c52187&query={0}", this.SearchFieldTextBox.Text);

                try
                {
                    Search JSONObject = new JavaScriptSerializer().Deserialize<Search>(
                        webClient.DownloadString(URL)
                    );

                    Invoke((MethodInvoker)(() =>
                    {

                        string[] columnNames = new string[] {
                        "ID",
                        "Title",
                        "Description",
                        "Poster Path",
                        "Release Date"
                    };

                        MovieDGV.ColumnCount = columnNames.Length;

                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            MovieDGV.Columns[i].Name = columnNames[i];
                        }

                        MovieDGV.Rows.Clear();

                        foreach (SearchResult result in JSONObject.results)
                        {
                            string[] row = new string[] {
                            Convert.ToString(result.id),
                            result.title,
                            result.overview,
                            result.poster_path,
                            result.release_date
                        };

                            DataGridViewButtonColumn PilihButton = new DataGridViewButtonColumn()
                            {
                                Name = "Action",
                                UseColumnTextForButtonValue = true,
                                Text = "Pilih"
                            };

                            if (MovieDGV.Columns["Action"] == null)
                                MovieDGV.Columns.Insert(5, PilihButton);

                            MovieDGV.Rows.Add(row);
                        }

                        FetchingStatus.Text = "Done";

                        Thread RemoveFetchingSatus = new Thread(new ThreadStart(() =>
                        {
                            Thread.Sleep(1000);
                            Invoke((MethodInvoker)(() =>
                            {
                                FetchingStatus.Text = "";
                            }));
                        }));

                        RemoveFetchingSatus.Start();

                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void MovieDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MovieDGV.Columns["Action"].Index)
                if (MessageBox.Show("Apa kamu yakin?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.ID = MovieDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Title = MovieDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.Description = MovieDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.PosterPath = MovieDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.ReleaseDate = MovieDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

                    if (OnDataAvailable != null)
                        OnDataAvailable(this, EventArgs.Empty);

                    this.Close();
                }
        }

        private void SearchFieldTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
    }
}
