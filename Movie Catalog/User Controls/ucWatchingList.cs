using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Movie_Catalog.Interfaces;

namespace Movie_Catalog.User_Controls
{
    public partial class ucWatchingList : UserControl
    {
        private static ucWatchingList _instance;

        public static ucWatchingList Instance
        {
            get
            {
                if(_instance== null)
                    _instance = new ucWatchingList();
                return _instance;
            }
        }

        public ucWatchingList()
        {
            InitializeComponent();

            _instance = null;
            generate();
        }
        
        public void generate()
        {
            this.FlowLayout.Controls.Clear();

            DBConnector DBC = new DBConnector();

            string query = "SELECT m.id, m.title, m.description, m.release_year, m.poster_path, m.movie_path, lw.current_position, lw.movie_duration, lw.last_watched_date FROM last_watched AS lw, movies AS m WHERE m.id = lw.movie_id ORDER BY lw.last_watched_date DESC";

            List<Movie> movies = DBC.SelectForMoviePlus(query);

            foreach (Movie movie in movies)
            {
                this.FlowLayout.Controls.Add(
                        new LastWatchedItem(movie)
                    );
            }
        }
    }
}



