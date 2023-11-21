using System;
using System.Windows.Forms;

namespace Programming_CW_1
{
    public partial class AdminDashboard_form : Form
    {
        public AdminDashboard_form()
        {
            InitializeComponent();
        }

        public void setUsername(string username) 
        { 
            lbl_username.Text = username;
        }

        private void AdminDashboard_form_Load(object sender, EventArgs e)
        {

        }
    }
}
