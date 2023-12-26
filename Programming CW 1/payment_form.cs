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
    public partial class payment_form : Form
    {
        private int registrationFee = 1000;
        private Treatment selectedTreatment;

        private List<Appointment> appointments;
        private List<Appointment> filteredAppointments;
        private Appointment selectedAppointment;
        public payment_form(List<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
            filteredAppointments = new List<Appointment>(appointments);
            DisplayAppointments();

            dataGridViewAppointments.SelectionChanged += dataGridViewAppointments_SelectionChanged;
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
            txt_patientName.Text = selectedAppointment.FullName;
            txt_appointmentId.Text = selectedAppointment.AppointmentID.ToString();
        }

        private void payment_form_Load(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            // Check if a treatment type is selected
            if (cmb_treatmentType.SelectedItem != null)
            {
                // Get the selected treatment type from the combo box
                string selectedTreatmentType = cmb_treatmentType.SelectedItem.ToString();

                // Create an instance of the selected treatment type
                switch (selectedTreatmentType)
                {
                    case "Cleanings":
                        selectedTreatment = new Cleanings();
                        break;
                    case "Whitening":
                        selectedTreatment = new Whitening();
                        break;
                    case "Filling":
                        selectedTreatment = new Filling();
                        break;
                    case "Nerve Filling":
                        selectedTreatment = new NerveFilling();
                        break;
                    case "Root Canal Therapy":
                        selectedTreatment = new RootCanalTherapy();
                        break;  
                }

                // Calculate the total fee
                int totalFee = registrationFee + selectedTreatment.price;

                // Display the total fee 
                txt_total.Text = totalFee.ToString("Rs.");

                // Capture appointment details before removing it
                DateTime appointmentDate = selectedAppointment.Date;
                string patientName = selectedAppointment.FullName;
                int appointmentId = selectedAppointment.AppointmentID;
                string selectedPaymentMethod = cmb_paymentMethod.SelectedItem.ToString();

                // Remove the paid appointment from the list
                appointments.Remove(selectedAppointment);

                // Display the total fee 
                txt_total.Text = totalFee.ToString("Rs.");

                // Create an instance of the invoice form
                invoice_form invoiceForm = new invoice_form();

                // Set the data in the invoice form
                invoiceForm.SetInvoiceData(DateTime.Now, appointmentId, patientName, selectedPaymentMethod, selectedTreatmentType, registrationFee, selectedTreatment.price, totalFee);

                // Show the invoice form
                invoiceForm.Show();
            }
            else
            {
               
                MessageBox.Show("Please select a treatment type.");
            }
        }

        public void DisplayAppointments()
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a treatment type is selected
            if (cmb_treatmentType.SelectedItem != null)
            {
                // Get the selected treatment type from the combo box
                string selectedTreatmentType = cmb_treatmentType.SelectedItem.ToString();

                // Create an instance of the selected treatment type
                switch (selectedTreatmentType)
                {
                    case "Cleanings":
                        selectedTreatment = new Cleanings();
                        break;
                    case "Whitening":
                        selectedTreatment = new Whitening();
                        break;
                    case "Filling":
                        selectedTreatment = new Filling();
                        break;
                    case "Nerve Filling":
                        selectedTreatment = new NerveFilling();
                        break;
                    case "Root Canal Therapy":
                        selectedTreatment = new RootCanalTherapy();
                        break;
                }

                // Calculate the total fee
                int totalFee = registrationFee + selectedTreatment.price;

                // Display the total fee 
                txt_total.Text = totalFee.ToString("Rs.");
            }
            else
            {
                MessageBox.Show("Please select a treatment type.");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

    public class Treatment
    {
        public string type { get; set; }
        public int price { get; set; }
    }

    public class Cleanings : Treatment
    {
        public Cleanings()
        {
            type = "Cleanings";
            price = 2000;
        }
    }

    public class Whitening : Treatment
    {
        public Whitening()
        {
            type = "Whitening";
            price = 3000;
        }
    }

    public class Filling : Treatment
    {
        public Filling()
        {
            type = "Filling";
            price = 4000;
        }
    }

    public class NerveFilling : Treatment
    {
        public NerveFilling()
        {
            type = "Nerve Filling";
            price = 5000;
        }
    }

    public class RootCanalTherapy : Treatment
    {
        public RootCanalTherapy()
        {
            type = "Root Canal Therapy";
            price = 6000;
        }
    }
}
