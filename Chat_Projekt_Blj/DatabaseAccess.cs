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

        public bool IsUserExisting(string userName, string passWord)
        {
            List<User> result = new List<User>();
            OpenConnection();
            string sql = "SELECT * FROM user_chat";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.HasRows)
            {
                reader.Read();
                string username = reader["username"].ToString();
                string password = reader["password"].ToString();

                User us = new User();
                us.UserName = username;
                us.PassWord = password;
                result.Add(us);
            }




            CloseConnection();

            foreach (User UserName in result)
            {
               string user = Convert.ToString(UserName);
                if (userName == user)
                {
                    return true;
                }
            }

            return false;
        }

        public void RegisterUser(string userName, string passWord)
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                throw new Exception("Datenbankverbindung nicht geöffnet! User kann nicht registriert werden.");
            }

            // Insert into user (usernamen, pwd) values( ...
            string sql = "INSERT INTO user_chat (username, password) VALUES ('"+userName+"','"+passWord+"')";
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
