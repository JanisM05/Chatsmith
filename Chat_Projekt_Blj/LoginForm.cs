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



            if (txt_username.Text != "" && txt_password.Text != "")
            {
                
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}
