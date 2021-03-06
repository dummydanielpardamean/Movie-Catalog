﻿using MySql.Data.MySqlClient;
using System.Configuration;

namespace Movie_Catalog
{
    class SqlConnector
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public SqlConnector()
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
    }
}
