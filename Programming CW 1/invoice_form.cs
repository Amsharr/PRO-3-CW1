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
    public partial class invoice_form : Form
    {
        public invoice_form()
        {
            InitializeComponent();
        }

        internal void SetInvoiceData(DateTime now, int appointmentId, string patientName, string selectedPaymentMethod, string selectedTreatmentType, int registrationFee, int price, int totalFee)
        {
            // Set the values in the textboxes or controls in the invoice form
            lbl_date.Text = now.ToString("yyyy-MM-dd");
            txt_appointmentId.Text = appointmentId.ToString();
            txt_patientName.Text = patientName;
            txt_treatmentType.Text =selectedTreatmentType;
            txt_paymentMethod.Text = selectedPaymentMethod;
            txt_registrationFee.Text = registrationFee.ToString("Rs.");
            txt_treatment.Text = price.ToString("Rs.");
            txt_total.Text = totalFee.ToString("Rs.");
        }

        private void invoice_form_Load(object sender, EventArgs e)
        {

        }
    }
}
