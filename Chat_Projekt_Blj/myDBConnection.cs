using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Projekt_Blj
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        //server = "127.0.0.1";
        //    database = "wordpress";
        //    user = "root";
        //    password = "";
        //    port = "3306";
        //    sslM = "none";

        //    connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

        //    connection = new MySqlConnection("Db_connected");


        public void OpenConnection()
        {

        }

        public void CloseConnection()
        {

        }

        public void Getusernames()
        {

        }

        public void Sendusernames()
        {

        }

        public void Sendmessage()
        {

        }

        public void Getmessages()
        {

        }


    }
}
