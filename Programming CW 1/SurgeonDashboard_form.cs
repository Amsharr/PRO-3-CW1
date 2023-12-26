using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Programming_CW_1.AdminDashboard_form;

namespace Programming_CW_1
{
    public partial class SurgeonDashboard_form : Form
    {
        private List<Appointment> appointments;

        public SurgeonDashboard_form(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
            DisplayAppointments();

        }

        private void DisplayAppointments()
        {
            // Create and fill columns in the DataGridView
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.AutoGenerateColumns = true;

            dataGridViewAppointments.DataSource = appointments;

        }

        private void DisplayFilteredAppointments()
        {
            
        }

        //getUsername method is used to show the username of the user currently logged in 
        public void setUsername(string username) 
        { 
           lbl_username.Text = ("Dr. " + username);    
        }

        private void SurgeonDashboard_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login_form logout = new login_form();   
            logout.Show();
            this.Hide();
        }
    }
}
