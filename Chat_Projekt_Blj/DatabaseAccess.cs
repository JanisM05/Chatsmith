using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Projekt_Blj
{
    public class DatabaseAccess
    {
        const string ConnString = "Server=localhost;Database=wordpress;Uid=root;Pwd=;";

        private MySqlConnection connection;



        public void OpenConnection()
        {
            connection = new MySqlConnection(ConnString);
         
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public bool IsUserExisting(string userName)
        {
            return false;
        }

        public void RegisterUser(string userName, string passWord)
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                throw new Exception("Datenbankverbindung nicht geöffnet! User kann nicht registriert werden.");
            }

            // Insert into user (usernamen, pwd) values( ...

            string sql = "INSERT INTO user_chat (username, password) VALUES ('test'','test')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteReader();
        }

        public void SendMessage(string message, string user)
        {

        }

        public List<ChatMessage> GetMessages(string userName)
        {
            List<ChatMessage> result = new List<ChatMessage>();


            string sql = "SELECT * FROM ...";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"]);
                string user = reader["Username"].ToString();
            }


            ChatMessage msg = new ChatMessage();
            msg.Sender = "Hans";
            msg.SendDate = new DateTime(2021, 11, 12);
            msg.Message = "Hallo Peter, wie gehts?";
            result.Add(msg);

            return result;
        } 


       
       
    }
}
