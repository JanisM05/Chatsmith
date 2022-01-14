namespace Chat_Projekt_Blj
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.RichTextBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_textuser = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.lbl_textreceiver = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.customInstaller2 = new MySql.Data.MySqlClient.CustomInstaller();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_title.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.lbl_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_title.Size = new System.Drawing.Size(368, 46);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Chatsmith";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(423, 531);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(447, 36);
            this.txt_message.TabIndex = 6;
            this.txt_message.Text = "";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendMessage.Location = new System.Drawing.Point(888, 531);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(140, 36);
            this.btn_sendMessage.TabIndex = 7;
            this.btn_sendMessage.Text = "Senden";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(12, 531);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(346, 36);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_textuser
            // 
            this.lbl_textuser.AutoSize = true;
            this.lbl_textuser.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textuser.Location = new System.Drawing.Point(8, 55);
            this.lbl_textuser.Name = "lbl_textuser";
            this.lbl_textuser.Size = new System.Drawing.Size(204, 20);
            this.lbl_textuser.TabIndex = 9;
            this.lbl_textuser.Text = "Sie sind eingeloggt als:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(218, 55);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(59, 20);
            this.lbl_user.TabIndex = 10;
            this.lbl_user.Text = "label3";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.line.Location = new System.Drawing.Point(365, 0);
            this.line.MinimumSize = new System.Drawing.Size(10, 580);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(10, 580);
            this.line.TabIndex = 11;
            // 
            // lbl_textreceiver
            // 
            this.lbl_textreceiver.AutoSize = true;
            this.lbl_textreceiver.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textreceiver.Location = new System.Drawing.Point(404, 10);
            this.lbl_textreceiver.Name = "lbl_textreceiver";
            this.lbl_textreceiver.Size = new System.Drawing.Size(238, 26);
            this.lbl_textreceiver.TabIndex = 12;
            this.lbl_textreceiver.Text = "Nachricht senden an:";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receiver.Location = new System.Drawing.Point(648, 10);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(0, 26);
            this.lbl_receiver.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(423, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(586, 419);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 579);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.lbl_textreceiver);
            this.Controls.Add(this.line);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_textuser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_sendMessage);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.lbl_title);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox txt_message;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_textuser;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label lbl_textreceiver;
        private System.Windows.Forms.Label lbl_receiver;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}