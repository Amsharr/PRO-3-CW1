﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_CW_1
{
    public partial class SurgeonDashboard_form : Form
    {

        public SurgeonDashboard_form()
        {
            InitializeComponent();

        }

        //getUsername method is used to show the username of the user currently logged in 
        public void getUsername(string username) 
        { 
           lbl_username.Text = ("Dr. " + username);    
        }

        private void SurgeonDashboard_form_Load(object sender, EventArgs e)
        {

        }
    }
}