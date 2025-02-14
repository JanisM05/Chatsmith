﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Projekt_Blj
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //List<ChatMessage> messages = new List<ChatMessage>();


            // for (int i = 1; i <= 10; i++)
            // {
            //     ChatMessage m = new ChatMessage();
            //     m[0] = "von db" + i;
            //     m.Receiver = "von db" + i;

            //     messages.Add(m);

            // }


            // foreach (ChatMessage m2 in messages) 
            // {
            //     MessageBox.Show(m2.Sender);
            // }



            string userName = txt_username.Text;
            string passWord = txt_password.Text;

            DatabaseAccess da = new DatabaseAccess();
            da.OpenConnection();
            if (da.IsLoginCorrect(userName, passWord) == false)
            {
                MessageBox.Show("Die Login-Daten sind falsch");
            }
            else if (da.IsLoginCorrect(userName, passWord) == true)
            {

                HomeForm homeForm = new HomeForm(userName);
                homeForm.Show();
                this.Hide();
            }
            da.CloseConnection();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}
