﻿using System;
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

        public HomeForm()
        {
            InitializeComponent();
            us = new UserNames();


        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            string useroutput = us.user;
            lbl_user.Text = useroutput;
        }


    }
}
