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
        DatabaseAccess db = new DatabaseAccess();

        string loggedInUser = string.Empty;

        List<Label> labels = new List<Label>();

        List<Button> buttons = new List<Button>();

        UserNames us = new UserNames();

        public HomeForm(string loginName)
        {

            InitializeComponent();

            loggedInUser = loginName;

            DatabaseAccess db = new DatabaseAccess();
            db.GetContacts(loggedInUser);

            

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

            Button b = (Button)sender;
            Contacts c = (Contacts)b.Tag;

            string receiver;
            receiver = b.Text.ToString();

            
            us.SaveReceiver(receiver);
            us.SaveUsername(loggedInUser);

            txt_message.Show();
            btn_sendMessage.Show();

            showMessages();
        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            lbl_login.Text += "  ["+ loggedInUser + "]";

        }


        public void btn_sendMessage_Click(object sender, EventArgs e)
        { 
            string message = txt_message.Text;

            if (us.receiver != "")
            {
                db.SendMessage(message, us.receiver, us.user);
                db.GetMessages(us.receiver, us.user);
            }
            else
            {
                MessageBox.Show("Sie haben keinen Empfänger ausgewählt");
            }

            showMessages();
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void showMessages()
        {
            List<ChatMessage> messages = new List<ChatMessage>();

            messages = db.GetMessages(us.receiver, us.user);

            int ypos = 90;
            int xpos = 400;

            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
            }

            foreach (ChatMessage ms in messages)
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
    }
}
