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
        Label[] lbl_contact = new Label[10];

        public HomeForm()
        {
            InitializeComponent();
            us = new UserNames();

            DatabaseAccess db = new DatabaseAccess();
            db.GetContacts();

            foreach(Contacts contact in db.listContacts)
            {
                int i = 0;
                lbl_contact[i] = new Label();
                lbl_contact[i].Location = new System.Drawing.Point(xpos, ypos);
                lbl_contact[i].Text = contact.UserName;
                this.Controls.Add(lbl_contact[i]);
                ypos += 30;
                lbl_contact[i].AutoSize = true;
                i++;
            }
        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            string useroutput = us.user;
            lbl_user.Text = useroutput;
        }

        public void lbl_contact_Click(object sender, EventArgs e)
        {
            string receiver = "";
            receiver = lbl_contact.ToString();

            UserNames us = new UserNames();
            us.SaveReveiver(receiver);

        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
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
