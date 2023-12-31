﻿using System;
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
    public partial class login_form : Form
    {
        private doctor doctor;
        private frontOfficeOperator frontOfficeOperator;

        private List<Appointment> appointments;
        private List<Appointment> filteredAppointments;
        public login_form()
        {
            InitializeComponent();

            doctor = new doctor();
            frontOfficeOperator = new frontOfficeOperator();
        }

        private void btn_singIn_Click(object sender, EventArgs e)
        {
            string usernameEntered = txt_username.Text;
            string passwordEntered = txt_password.Text;

            // Authentication for Dental Surgeon
            if (doctor.Login(usernameEntered, passwordEntered))
            {
                MessageBox.Show("Welcome" + usernameEntered);

                // Open Dental Surgeon's dashboard 
                SurgeonDashboard_form surgeonDashboard = new SurgeonDashboard_form(appointments);
                surgeonDashboard.Show();
                this.Hide();

                //display username in the dashboard
                surgeonDashboard.setUsername(txt_username.Text);

            }
            // Authentication Front Office Operator
            else if (frontOfficeOperator.Login(usernameEntered, passwordEntered))
            {
                MessageBox.Show("Welcome" + usernameEntered);

                // Open Front Office Operator's dashboard or perform other actions
                AdminDashboard_form adminDashboard = new AdminDashboard_form();
                adminDashboard.Show();
                this.Hide();

                //display username in dashboard
                adminDashboard.setUsername(txt_username.Text);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
    public class User
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public void setUsername(string username)
        {
            Username = username;
        }
        public void setPassword(string password)
        {
            Password = password;
        }

        public bool Login(string usernameEntered, string passwordEntered)
        {            
            return Username == usernameEntered && Password == passwordEntered;
        }
    }
    public class doctor : User
    {
       public doctor() {

            setUsername("A.D_Ranasinghe");
            setPassword("123");
       }
    }
    public class frontOfficeOperator : User
    {
        public frontOfficeOperator()
        {
            setUsername("Admin");
            setPassword("123");
        }
    }
    
}
