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


            while (reader.Read())
            {
                User us = new User();
                us.UserName = reader["username"].ToString();
                us.PassWord = reader["password"].ToString();
                result.Add(us);
            }

            reader.Close();
            reader.Dispose();

            CloseConnection();

            foreach (User user in result)
            {
                if (user.UserName == userName)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsLoginCorrect (string userName, string passWord)
        {
            List<User> result = new List<User>();

            OpenConnection();
            string sql = "SELECT * FROM user_chat";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User us = new User();
                us.UserName = reader["username"].ToString();
                us.PassWord = reader["password"].ToString();
                result.Add(us);
            }

            reader.Close();
            reader.Dispose ();

            foreach (User user in result)
            {
                if (user.UserName == userName)
                {
                    if (user.PassWord == passWord)
                    {
                        return true;
                    }
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

        public List<Contacts> GetContacts()
        {
            List<Contacts> result = new List<Contacts>();

            OpenConnection();
            string sql = "SELECT username FROM user_chat";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Contacts us = new Contacts();
                us.UserName = reader["username"].ToString();
                result.Add(us);
            }

            reader.Close();
            reader.Dispose();

            return result;
        }


       
       
    }
}
