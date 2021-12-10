namespace Chat_Projekt_Blj
{
    partial class RegisterForm
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_passowrd = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_confpassword = new System.Windows.Forms.Label();
            this.txt_confpassword = new System.Windows.Forms.TextBox();
            this.lbl_gotologin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_login.Location = new System.Drawing.Point(10, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Padding = new System.Windows.Forms.Padding(75, 10, 75, 10);
            this.lbl_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_login.Size = new System.Drawing.Size(278, 46);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Chatsmith";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(99, 78);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(118, 19);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Benutzername";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(43, 164);
            this.txt_password.MaximumSize = new System.Drawing.Size(250, 50);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(214, 23);
            this.txt_password.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(43, 100);
            this.txt_user.MaximumSize = new System.Drawing.Size(250, 50);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(214, 23);
            this.txt_user.TabIndex = 4;
            // 
            // lbl_passowrd
            // 
            this.lbl_passowrd.AutoSize = true;
            this.lbl_passowrd.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passowrd.Location = new System.Drawing.Point(117, 142);
            this.lbl_passowrd.Name = "lbl_passowrd";
            this.lbl_passowrd.Size = new System.Drawing.Size(78, 19);
            this.lbl_passowrd.TabIndex = 5;
            this.lbl_passowrd.Text = "Passwort";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(103, 277);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(109, 27);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Registrieren";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_confpassword
            // 
            this.lbl_confpassword.AutoSize = true;
            this.lbl_confpassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confpassword.Location = new System.Drawing.Point(80, 211);
            this.lbl_confpassword.Name = "lbl_confpassword";
            this.lbl_confpassword.Size = new System.Drawing.Size(160, 19);
            this.lbl_confpassword.TabIndex = 7;
            this.lbl_confpassword.Text = "Passwort bestätigen";
            // 
            // txt_confpassword
            // 
            this.txt_confpassword.Font = new System.Drawing.Font("Arial Nova", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confpassword.Location = new System.Drawing.Point(43, 233);
            this.txt_confpassword.MaximumSize = new System.Drawing.Size(250, 50);
            this.txt_confpassword.Name = "txt_confpassword";
            this.txt_confpassword.Size = new System.Drawing.Size(214, 23);
            this.txt_confpassword.TabIndex = 8;
            // 
            // lbl_gotologin
            // 
            this.lbl_gotologin.AutoSize = true;
            this.lbl_gotologin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gotologin.Location = new System.Drawing.Point(100, 323);
            this.lbl_gotologin.Name = "lbl_gotologin";
            this.lbl_gotologin.Size = new System.Drawing.Size(117, 16);
            this.lbl_gotologin.TabIndex = 10;
            this.lbl_gotologin.Text = "Zurück zum Login";
            this.lbl_gotologin.Click += new System.EventHandler(this.lbl_gotologin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(300, 358);
            this.Controls.Add(this.lbl_gotologin);
            this.Controls.Add(this.txt_confpassword);
            this.Controls.Add(this.lbl_confpassword);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lbl_passowrd);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_login);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_passowrd;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_confpassword;
        private System.Windows.Forms.TextBox txt_confpassword;
        private System.Windows.Forms.Label lbl_gotologin;
    }
}