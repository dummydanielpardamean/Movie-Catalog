using Movie_Catalog.Helper.Storage;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Movie_Catalog
{
    partial class VideoPlayer : Form
    {
        private DBConnector DBC;

        private string query;

        private MySqlCommand command;

        private Dictionary<string, string> Movie;

        private static double CurrentPosition;

        private static double MovieDurationLength;

        public VideoPlayer(Dictionary<string, string> movie)
        {
            InitializeComponent();

            DBC = new DBConnector();

            Movie = movie;

            SetMovieToVideoPlayer();
        }

        private void SetMovieToVideoPlayer()
        {
            if (Movie["movie_path"].ToString() != null)
            {
                string uri = new Uri(
                        MovieStorage.GetFile(Movie["movie_path"].ToString())
                    ).AbsoluteUri;

                axVLCPlugin21.playlist.add(uri);
                axVLCPlugin21.playlist.play();

                try
                {
                    SetPosition();
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
        }

        private void axVLCPlugin21_MediaPlayerPositionChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerPositionChangedEvent e)
        {
            // Terkadang time mengembalikan nilai -1
            // ini dapat menyebabkan kesalahan dalam mencatat posisi tontonan terakhir
            // jadi dilakukan conditional didalam memperbarui value CurrentPostion
            if (axVLCPlugin21.input.time != -1)
                CurrentPosition = axVLCPlugin21.input.time;
            Console.WriteLine(CurrentPosition);
        }

        private void axVLCPlugin21_MediaPlayerLengthChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerLengthChangedEvent e)
        {
            MovieDurationLength = axVLCPlugin21.input.length;
        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            // jika film sudah diputar sampai habis
            // akan dilakukan penghapusan record history tontonan
            string query = "DELETE FROM last_watched WHERE movie_id = @movie_id;";
            DBConnector DBC = new DBConnector();

            MySqlCommand command = new MySqlCommand(query, DBC.connection);
            command.Parameters.Add("@movie_id", MySqlDbType.Int64);

            command.Parameters["@movie_id"].Value = Movie["id"].ToString();

            if (command.ExecuteNonQuery() != -1)
                this.Close();
        }

        private void SetPosition()
        {
            DBC.connection.Open();

            query = "SELECT * FROM last_watched WHERE movie_id=@movie_id";
            MySqlCommand command = new MySqlCommand(query, DBC.connection);
            command.Parameters.Add("@movie_id", MySqlDbType.Int64);
            command.Parameters["@movie_id"].Value = Movie["id"].ToString();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                axVLCPlugin21.input.time = Convert.ToDouble(reader["current_position"].ToString());
            else
                axVLCPlugin21.input.time = 0;
        }

        private void UpdatePosition()
        {
            DBC.connection.Close();

            try
            {
                DBC.connection.Open();

                // perbarui data.
                query = "UPDATE last_watched SET current_position = @current_position, movie_duration = @movie_duration, last_watched_date = @last_watched_date WHERE movie_id = @movie_id;";
                command = new MySqlCommand(query, DBC.connection);
                command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                command.Parameters.Add("@current_position", MySqlDbType.Int64);
                command.Parameters.Add("@movie_duration", MySqlDbType.Int64);
                command.Parameters.Add("@last_watched_date", MySqlDbType.String);

                command.Parameters["@movie_id"].Value = Movie["id"].ToString();
                command.Parameters["@current_position"].Value = CurrentPosition;
                command.Parameters["@movie_duration"].Value = MovieDurationLength;
                command.Parameters["@last_watched_date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                command.ExecuteNonQuery();
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

        private void CreateLastWatchedRecord()
        {
            DBC.connection.Close();

            try
            {
                DBC.connection.Open();

                // jika tidak, buat record
                query = "INSERT INTO last_watched (movie_id, current_position, movie_duration, last_watched_date) VALUES (@movie_id, @current_position, @movie_duration, @last_watched_date);";

                command = new MySqlCommand(query, DBC.connection);
                command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                command.Parameters.Add("@current_position", MySqlDbType.Int64);
                command.Parameters.Add("@movie_duration", MySqlDbType.Int64);
                command.Parameters.Add("@last_watched_date", MySqlDbType.String);

                command.Parameters["@movie_id"].Value = Movie["id"].ToString();
                command.Parameters["@current_position"].Value = CurrentPosition;
                command.Parameters["@movie_duration"].Value = MovieDurationLength;
                command.Parameters["@last_watched_date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                command.ExecuteNonQuery();
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

        private void axVLCPlugin21_MediaPlayerStopped(object sender, EventArgs e)
        {
            try
            {
                DBC.connection.Open();

                // set up query untuk mengecek apa ada record dengan movie_id yang diberikan
                query = "SELECT * FROM last_watched WHERE movie_id = @movie_id;";
                command = new MySqlCommand(query, DBC.connection);
                command.Parameters.Add("@movie_id", MySqlDbType.Int64);
                command.Parameters["@movie_id"].Value = Movie["id"].ToString();

                MySqlDataReader reader = command.ExecuteReader();

                // jika ada record
                if (reader.Read())
                {
                    UpdatePosition();
                }
                else
                {
                    CreateLastWatchedRecord();
                }
                axVLCPlugin21.Dispose();

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
    }
}
