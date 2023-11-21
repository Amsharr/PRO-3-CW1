using System;
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
    public partial class login_form : Form
    {
        private string dentalSurgeonUsername = "A.D.Ranasinghe";
        private string dentalSurgeonPassword = "123";

        private string frontOfficeOperatorUsername = "admin";
        private string frontOfficeOperatorPassword = "123";
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_singIn_Click(object sender, EventArgs e)
        {
            string username, password;  

            username = txt_username.Text;   
            password = txt_password.Text;

            // To verify the credentials this conditional statement is used 
            if (DentalSurgeon(username, password))
            {                
                SurgeonDashboard_form surgeonDashboard = new SurgeonDashboard_form();

                surgeonDashboard.setUsername(txt_username.Text);
                surgeonDashboard.Show();
                this.Hide();

                MessageBox.Show("Welcome back Dr. " + username);

            }
            
            else if (FrontOfficeOperator(username, password))
            {
                AdminDashboard_form adminDashboard = new AdminDashboard_form();

                adminDashboard.setUsername(txt_username.Text);
                adminDashboard.Show();
                this.Hide();

                MessageBox.Show("Welcome back " + username);
               
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool DentalSurgeon(string username, string password)
        {
            return username == dentalSurgeonUsername && password == dentalSurgeonPassword;  
        }

        private bool FrontOfficeOperator(string username, string password)
        {
            return username == frontOfficeOperatorUsername && password == frontOfficeOperatorPassword;  
        }
    }
}
