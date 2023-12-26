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
    public partial class invoice_form : Form
    {
        private payment_form _paymentForm;

        public invoice_form()
        {
            InitializeComponent();
        }

        public void getUsername(string username)
        {
            lbl_username.Text = username;
        }

        internal void SetInvoiceData(DateTime now, int appointmentId, string patientName, 
        string selectedPaymentMethod, string selectedTreatmentType, int registrationFee, int price, int totalFee)
        {
            // Set the values in the textboxes or controls in the invoice form
            lbl_date.Text = now.ToString("yyyy-MM-dd");
            lbl_appointmenId.Text = appointmentId.ToString();
            lbl_patientName.Text = patientName;
            lbl_treatmentType.Text =selectedTreatmentType;
            lbl_paymentMethod.Text = selectedPaymentMethod;
            lbl_registrationAmount.Text = registrationFee.ToString("Rs.");
            lbl_treatmentAmount.Text = price.ToString("Rs.");
            lbl_total.Text = totalFee.ToString("Rs.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current invoice form
            this.Close();

            // Show the payments
            _paymentForm.Show();
        }

        private void invoice_form_Load(object sender, EventArgs e)
        {

        }        

        private void label2_Click(object sender, EventArgs e)
        {
              
        }

        private void lbl_viewAppointments_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
