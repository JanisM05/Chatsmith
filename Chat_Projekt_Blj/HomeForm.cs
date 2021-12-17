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
    public partial class HomeForm : Form
    {
        UserNames us;

        int ypos = 90;
        int xpos = 0;
        Button[] btn_contact = new Button[10];

        public HomeForm()
        {
            InitializeComponent();
            us = new UserNames();

            DatabaseAccess db = new DatabaseAccess();
            db.GetContacts();

            foreach(Contacts contact in db.listContacts)
            {
                int i = 0;
                btn_contact[i] = new Button();
                btn_contact[i].Location = new System.Drawing.Point(xpos, ypos);
                btn_contact[i].Text = contact.UserName;
                this.Controls.Add(btn_contact[i]);
                ypos += 30;
                btn_contact[i].AutoSize = true;
                i++;
            }

            txt_message.Hide();
            btn_sendMessage.Hide();
        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            string useroutput = us.user;
            lbl_user.Text = useroutput;
        }

        public void btn_contact_Click(object sender, EventArgs e)
        {
            string receiver; ;
            receiver = btn_contact.ToString();

            UserNames us = new UserNames();
            us.SaveReveiver(receiver);

            txt_message.Show();
            btn_sendMessage.Show();
        }

        public void btn_sendMessage_Click(object sender, EventArgs e)
        {
            string message = txt_message.Text;

            DatabaseAccess db = new DatabaseAccess();

            if (us.receiver != "")
            {
                db.SendMessage(message);
            }
            else
            {
                MessageBox.Show("Sie haben keinen Empfänger ausgewählt");
            }
        }
    }
}
