using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using static Programming_CW_1.AdminDashboard_form;

namespace Programming_CW_1
{
    public partial class AdminDashboard_form : Form
    {
        
        private List<Appointment> appointments = new List<Appointment>();
        public AdminDashboard_form(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;   
        }

        public AdminDashboard_form()
        {
            InitializeComponent();
        }

        public class Appointment
        {
            private int appointmentCount = 0;

            private int appointmentID;
            private string fullName;
            private string nicNo;
            private string mobileNo;
            private string address;
            private DateTime date;
            private string time;

            public Appointment()
            {
                appointmentCount++;
                appointmentID = appointmentCount;
            }            

            public int AppointmentID { get => appointmentID; set => appointmentID = value; }
            public string FullName { get => fullName; set => fullName = value; }
            public string NicNo { get => nicNo; set => nicNo = value; }
            public string MobileNo { get => mobileNo; set => mobileNo = value; }
            public string Address { get => address; set => address = value; }
            public DateTime Date { get => date; set => date = value; }
            public string Time { get => time; set => time = value; }
        }

        

        public void setUsername(string username) 
        { 
            lbl_username.Text = username;
        }
        
        private void AdminDashboard_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            //Creating a new object called appointment 
            Appointment appointment = NewAppointment();

            // New appointment is added to the list 
            appointments.Add(appointment);           

            // Clear the input fields after appointment has been added 
            ClearInputFields();

            // navigate to view appointments page and show message.
            MessageBox.Show("Appointment successfully added");
            showAppointment_form viewAppointments = new showAppointment_form(appointments);
            viewAppointments.Show();
            this.Hide();
        }

        private Appointment NewAppointment()
        {
            // Create a new appointment object using encapsulation
            return new Appointment
            {
                FullName = txt_fullName.Text,
                NicNo = txt_nicNo.Text,
                MobileNo = txt_mobileNo.Text,
                Address = txt_address.Text,
                Date = dateTimePicker.Value,
                Time = txt_time.Text
            };
        }
        private void ClearInputFields()
        {
            // Clear all input fields
            txt_fullName.Text = string.Empty;
            txt_nicNo.Text = string.Empty;
            txt_mobileNo.Text = string.Empty;
            txt_address.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            txt_time.Text = string.Empty;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fullName.Text = string.Empty;
            txt_nicNo.Text = string.Empty;
            txt_mobileNo.Text = string.Empty;
            txt_address.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now;
            txt_time.Text = string.Empty;   
        }

        private void label9_Click(object sender, EventArgs e)
        {
            EditAppointment_form editAppointment = new EditAppointment_form(appointments);
            editAppointment.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            payment_form payments = new payment_form(appointments);
            payments.Show();
            this.Hide();
        }
    }
}

