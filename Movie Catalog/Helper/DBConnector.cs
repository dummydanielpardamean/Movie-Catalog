using Movie_Catalog.ClassSchema;
using Movie_Catalog.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Movie_Catalog
{
    class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnector()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = ConfigurationManager.AppSettings["database"];
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(string query)
        {
            try
            {
                this.OpenConnection();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1062:
                        MessageBox.Show("Terdapat duplikat data");
                        break;
                }
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public bool Update(string query)
        {
            try
            {
                this.OpenConnection();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        ////Delete statement
        public bool Delete(string query)
        {
            try
            {
                this.OpenConnection();

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        //Select statement
        public List<Movie> SelectForBrowseMovie(string query)
        {

            List<Movie> list = new List<Movie>();
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie(
                            reader["id"].ToString(),
                            reader["title"].ToString(),
                            reader["description"].ToString(),
                            reader["release_year"].ToString(),
                            reader["poster_path"].ToString(),
                            reader["movie_path"].ToString()
                        );

                        list.Add(movie);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        public List<LastWatched> SelectForLastWatched(string query)
        {

            List<LastWatched> list = new List<LastWatched>();
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LastWatched lastWatched = new LastWatched(
                            reader["movie_id"].ToString(),
                            Convert.ToDouble(reader["current_position"]),
                            Convert.ToDouble(reader["movie_duration"])
                        );

                        list.Add(lastWatched);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        public List<Movie> SelectForMoviePlus(string query)
        {

            List<Movie> list = new List<Movie>();
            try
            {
                connection.Open();

                using (MySqlDataReader reader = new MySqlCommand(query, connection).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(
                                new Movie(
                                reader["id"].ToString(),
                                reader["title"].ToString(),
                                reader["description"].ToString(),
                                reader["release_year"].ToString(),
                                reader["poster_path"].ToString(),
                                reader["movie_path"].ToString(),
                                Convert.ToDouble(reader["current_position"]),
                                Convert.ToDouble(reader["movie_duration"]),
                                reader["last_watched_date"].ToString()
                            )
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return list;
        }

        ////Count statement
        //public int Count()
        //{
        //}

        ////Backup
        //public void Backup()
        //{
        //}

        ////Restore
        //public void Restore()
        //{
        //}
    }
}
