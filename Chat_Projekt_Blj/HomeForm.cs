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
        public static UserNames us = new UserNames();

        List<Label> labels = new List<Label>();

        List<Button> buttons = new List<Button>();

        public HomeForm()
        {
            InitializeComponent();
            us = new UserNames();

            DatabaseAccess db = new DatabaseAccess();
            db.GetContacts();

            int ypos = 90;
            int xpos = 0;

            foreach (Contacts contact in db.listContacts)
            {
                Button btn_contact = new Button();

                btn_contact.Location = new System.Drawing.Point(xpos, ypos);
                btn_contact.Text = contact.UserName;
                this.Controls.Add(btn_contact);
                ypos += 30;
                btn_contact.AutoSize = true;
                btn_contact.Tag = contact;
                btn_contact.Click += ContactButton_Click;
                buttons.Add(btn_contact);
            }
            txt_message.Hide();
            btn_sendMessage.Hide();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {

            DatabaseAccess db = new DatabaseAccess();

            Button b = (Button)sender;
            Contacts c = (Contacts)b.Tag;

            string receiver;
            receiver = b.Text.ToString();

            UserNames us = DatabaseAccess.us;
            us.SaveReceiver(receiver);

            txt_message.Show();
            btn_sendMessage.Show();

            db.GetMessages();

            int ypos = 90;
            int xpos = 400;

            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
            }

            foreach (ChatMessage ms in db.GetMessages())
            {
                xpos = 400;

                if (ms.Sender == us.user)
                {
                    xpos += 200;
                }

                Label lbl_message = new Label();

                labels.Add(lbl_message);

                lbl_message.Location = new System.Drawing.Point(xpos, ypos);
                lbl_message.Text = ms.Message;
                this.Controls.Add(lbl_message);
                ypos += 30;
                lbl_message.AutoSize = true;
            }
        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
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

        private void test_Click(object sender, EventArgs e)
        {
            string receiver;
            receiver = "test";

            UserNames us = DatabaseAccess.us;
            us.SaveReceiver(receiver);

            txt_message.Show();
            btn_sendMessage.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
