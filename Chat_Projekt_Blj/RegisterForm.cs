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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lbl_gotologin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                MessageBox.Show("Sie müssen einen Benutzernamen eingeben");
            }
            else if (txt_password.Text == "" || txt_confpassword.Text == "")
            {
                MessageBox.Show("Sie müssen beide Passwort-Felder ausfüllen");
            }
            else if (txt_password.Text != txt_confpassword.Text)
            {
                MessageBox.Show("Die Passwörter stimmen nich überein");
            }
            else
            {
                string userName = txt_user.Text;
                string passWord = txt_password.Text;


                DatabaseAccess da = new DatabaseAccess();
                da.OpenConnection();
                da.RegisterUser(userName, passWord);
                da.CloseConnection();
            }
        }
    }
}
