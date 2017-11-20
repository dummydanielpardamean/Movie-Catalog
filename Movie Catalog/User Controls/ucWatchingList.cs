using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Movie_Catalog.User_Controls
{
    public partial class ucWatchingList : UserControl
    {
        private static ucWatchingList _instance;

        public static ucWatchingList Instance
        {
            get
            {
                if (_instance == null)
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

        private void generate()
        {
            this.FlowLayout.Controls.Clear();

            SqlConnector DBC = new SqlConnector();

            try
            {
                DBC.connection.Open();

                string query = "SELECT m.id, m.title, m.description, m.release_year, m.poster_path, m.movie_path, lw.current_position, lw.movie_duration, lw.last_watched_date FROM last_watched AS lw, movies AS m WHERE m.id = lw.movie_id ORDER BY lw.last_watched_date DESC";

                MySqlCommand command = new MySqlCommand(query, DBC.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    this.FlowLayout.Controls.Add(
                            new WatchingListItem(reader)
                        );
                }
            }
            catch(Exception ex)
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



