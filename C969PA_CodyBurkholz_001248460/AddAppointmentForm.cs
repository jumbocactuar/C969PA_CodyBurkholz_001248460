using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA_CodyBurkholz_001248460
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();

            AddAppointmentStartDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
            AddAppointmentEndDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void AddAppointmentTitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentConsultantTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentCustomerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAppointmentSelectConsultantButton_Click(object sender, EventArgs e)
        {

        }

        private void AddAppointmentSelectCustomerButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm(this);
            f.Show();
        }

        private void AddAppointmentSaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm f = new ManageAppointmentsForm();
            f.Show();

            Close();
        }

        public void FillConsultantName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                Object[] selectionContents = Globals.GetSelectedRowContents("user", int.Parse(Globals.CurrentDataGridSelection));

                AddAppointmentCustomerTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null; // FIXME: Make sure this doens't interfere with anything
        }

        public void FillCustomerName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                Object[] selectionContents = Globals.GetSelectedRowContents("customer", int.Parse(Globals.CurrentDataGridSelection));

                AddAppointmentCustomerTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null; // FIXME: Make sure this doesn't interfere with anything
        }
    }
}
