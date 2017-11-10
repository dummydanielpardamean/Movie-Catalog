using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Movie_Catalog.Interfaces;

namespace Movie_Catalog.User_Controls
{
    public partial class ucBrowse : UserControl
    {
        private static ucBrowse _instance;

        public static ucBrowse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucBrowse();
                }
                return _instance;
            }
        }

        public ucBrowse()
        {
            InitializeComponent();
        }

        private void ucBrowse_Load(object sender, EventArgs e)
        {
            _instance = null;
            generate();
        }

        public void generate()
        {
            this.FlowLayoutBrowse.Controls.Clear();

            DBConnector DBC = new DBConnector();

            List<Movie> movies = DBC.SelectForBrowseMovie("SELECT * FROM movies");

            foreach (Movie movie in movies)
            {
                this.FlowLayoutBrowse.Controls.Add(
                        new BrowseMovieItem(movie)
                    );
            }
        }
    }
}
