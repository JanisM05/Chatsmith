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
            this.lbl_login = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.RichTextBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_login.Location = new System.Drawing.Point(0, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Padding = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.lbl_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_login.Size = new System.Drawing.Size(368, 46);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Chatsmith";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richTextBox1.Location = new System.Drawing.Point(365, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 586);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(552, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(368, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chatsmith";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(381, 524);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(489, 43);
            this.txt_message.TabIndex = 6;
            this.txt_message.Text = "";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(888, 524);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(140, 43);
            this.btn_sendMessage.TabIndex = 7;
            this.btn_sendMessage.Text = "Senden";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(292, 68);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(24, 13);
            this.test.TabIndex = 8;
            this.test.Text = "test";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(414, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 579);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.btn_sendMessage);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_login);
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
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_message;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.ListBox listBox1;
    }
}