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
    public partial class EditAppointment_form : Form
    {

        private List<Appointment> appointments;
        private Appointment selectedAppointment;

        public EditAppointment_form(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
            DisplayAppointments();

            dataGridViewAppointments.SelectionChanged += dataGridViewAppointments_SelectionChanged;
        }

        private void DisplayAppointments() 
        {
            // Set up columns in the DataGridView
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.AutoGenerateColumns = true;

            dataGridViewAppointments.DataSource = appointments;
        }
        private void dataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
        {
            // Handle the selection change event
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAppointments.SelectedRows[0].Index;
                selectedAppointment = appointments[selectedIndex];

                // Display selected appointment details for editing
                DisplaySelectedAppointment();
            }
        }

        private void DisplaySelectedAppointment()
        {
            // Display the selected appointment details in the textboxes
            txt_fullName.Text = selectedAppointment.FullName;
            txt_nicNo.Text = selectedAppointment.NicNo;
            txt_mobileNo.Text = selectedAppointment.MobileNo;
            txt_address.Text = selectedAppointment.Address;
            dateTimePicker.Value = selectedAppointment.Date;
            txt_time.Text = selectedAppointment.Time;   
        }

        private void ClearInputFields()
        {
            txt_fullName.Text = string.Empty;
            txt_nicNo.Text = string.Empty;
            txt_mobileNo.Text = string.Empty;
            txt_address.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            txt_time.Text = string.Empty;
        }

        private void EditAppointment_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Update the selected appointment with edited details
            selectedAppointment.FullName = txt_fullName.Text;
            selectedAppointment.NicNo = txt_nicNo.Text;
            selectedAppointment.MobileNo = txt_mobileNo.Text;
            selectedAppointment.Address = txt_address.Text;
            selectedAppointment.Date = dateTimePicker.Value;
            selectedAppointment.Time= txt_time.Text;

            MessageBox.Show("The record has been edited");

            ClearInputFields();

            // Refresh the DataGridView
            dataGridViewAppointments.DataSource = null;
            dataGridViewAppointments.DataSource = appointments; 

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Check if an appointment is selected
            if (selectedAppointment != null)
            {
                // Confirm with the user before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected appointment from the list
                    appointments.Remove(selectedAppointment);

                    // Refresh the DataGridView
                    dataGridViewAppointments.DataSource = null;
                    dataGridViewAppointments.DataSource = appointments;

                    // Clear the input fields after deletion
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        public void getUsername(string username)
        {
            lbl_username.Text = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showAppointment_form viewAppointments = new showAppointment_form(appointments);
            viewAppointments.Show();    
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminDashboard_form bookAppointment = new AdminDashboard_form(appointments);
            bookAppointment.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            payment_form payments = new payment_form(appointments);
            payments.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
