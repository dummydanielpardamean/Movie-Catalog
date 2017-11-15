using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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

            try
            {
                DBC.connection.Open();

                string query = "SELECT * FROM movies";

                MySqlCommand command = new MySqlCommand(query, DBC.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    this.FlowLayoutBrowse.Controls.Add(
                            new BrowseMovieItem(reader)
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("poop");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBC.connection.Close();
            }
        }
    }
}
