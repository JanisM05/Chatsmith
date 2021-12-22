using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows.Documents;

namespace Chat_Projekt_Blj
{
    public class DatabaseAccess
    {

        public List<Contacts> listContacts = new List<Contacts>();

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

        public void SendMessage(string message, string receiver, string user)
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToString("yyyy-MM-dd hh:mm:ss");

            OpenConnection();
            string sql = "INSERT INTO message_chat (text, receiver, date, sender) VALUES ('" + message + "','" + receiver + "','" + time + "','" + user + "')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteReader();
            CloseConnection();
        }

        public List<ChatMessage> GetMessages(string receiver, string user)
        {
            if (receiver != null)
            {
                List<ChatMessage> result = new List<ChatMessage>();

                OpenConnection();
                string sql = "SELECT * FROM message_chat WHERE (receiver ='" + user + "' AND sender = '" + receiver + "') OR (receiver ='" + receiver + "' AND sender = '" + user + "')";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ChatMessage ms = new ChatMessage();
                    ms.Message = reader["text"].ToString();
                    ms.SendDate = reader["date"].ToString();
                    ms.Sender = reader["sender"].ToString();
                    result.Add(ms);
                }

                CloseConnection();

                return result;
            }
            else
            {
                throw new Exception("Der Receiver ist null");
            }
        } 

        public List<Contacts> GetContacts(string user)
        {
            List<Contacts> result = new List<Contacts>();

            OpenConnection();
            string sql = "SELECT username FROM user_chat where username != '" + user + "'";
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
            CloseConnection();

            listContacts = result;

            return result;
        }


       
       
    }
}
