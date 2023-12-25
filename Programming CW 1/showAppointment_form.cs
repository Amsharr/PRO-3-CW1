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
    public partial class showAppointment_form : Form
    {
        private List<Appointment> appointments;
        private List<Appointment> filteredAppointments;
        public showAppointment_form(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
            filteredAppointments = new List<Appointment>(appointments);
            DisplayAppointments();
        }


        private void DisplayAppointments()
        {
            // Set up columns in the DataGridView
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.AutoGenerateColumns = true;

            // Apply filtering based on appointmentId or date
            int appointmentIdFilter;
            DateTime dateFilter = dateTimePicker.Value;

            if (int.TryParse(txt_searchAppointmentId.Text, out appointmentIdFilter))
            {
                // Filter by appointmentId
                filteredAppointments = appointments.Where(a => a.AppointmentID == appointmentIdFilter).ToList();
            }
            else
            {
                // Filter by date
                filteredAppointments = appointments.Where(a => a.Date.Date == dateFilter.Date).ToList();
            }

            dataGridViewAppointments.DataSource = filteredAppointments;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayAppointments();
        }

        public void getUsername(string username)
        {
            lbl_username.Text = username;
        }

        private void showAppointment_form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminDashboard_form bookAppointments = new AdminDashboard_form(appointments);
            bookAppointments.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            EditAppointment_form editAppointment = new EditAppointment_form(appointments);  
            editAppointment.Show(); 
            this.Hide();    
        }

        private void dataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            payment_form payments = new payment_form(appointments);
            payments.Show();
            this.Hide();
        }
    }
}
