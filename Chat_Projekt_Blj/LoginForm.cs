using System;
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

        Timer timer = new Timer();
        private object txt_user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick;
            timer.Interval = 5000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop(); MessageBox.Show("Benutzer schliesst formular.");
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
            da.IsUserExisting(userName, passWord);
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
