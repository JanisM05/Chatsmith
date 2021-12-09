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
    public partial class frmLogin : Form
    {

        Timer timer = new Timer();

        public frmLogin()
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
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                
            }
            else
            {
                lbl_errors.Text = "Sie müssen beide Felder ausfüllen!";
            }
        }
    }
}
