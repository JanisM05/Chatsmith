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

        private void lbl_contact_Click(object sender, EventArgs e)
        {

        }

    }
}
