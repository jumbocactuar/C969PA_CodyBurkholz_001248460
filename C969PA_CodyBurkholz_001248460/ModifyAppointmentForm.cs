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
    public partial class ModifyAppointmentForm : Form
    {
        private ManageAppointmentsForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false, false, false };

        public static int AppointmentID;
        
        public static int CustomerID;

        public static int UserID;

        public ModifyAppointmentForm()
        {
            InitializeComponent();

            ModifyAppointmentStartDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
            ModifyAppointmentEndDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
        }

        public ModifyAppointmentForm(Form callingForm)
        {
            sourceForm = callingForm as ManageAppointmentsForm;

            InitializeComponent();

            ModifyAppointmentStartDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
            ModifyAppointmentEndDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
        }

        private void ModifyAppointmentForm_Load(object sender, EventArgs e)
        {
            ModifyAppointmentSaveButton.Enabled = false;

            Object[] selectedAppointment = Globals.GetSelectedRowContents("appointment", int.Parse(Globals.CurrentDataGridSelection));

            AppointmentID = Convert.ToInt32(selectedAppointment[0]);

            CustomerID = Convert.ToInt32(selectedAppointment[1]);

            UserID = Convert.ToInt32(selectedAppointment[2]);

            Object[] associatedUser = Globals.GetSelectedRowContents("user", UserID);

            Object[] associatedCustomer = Globals.GetSelectedRowContents("customer", CustomerID);

            ModifyAppointmentTitleTextBox.Text = selectedAppointment[3].ToString();

            ModifyAppointmentDescriptionTextBox.Text = selectedAppointment[4].ToString();

            ModifyAppointmentLocationComboBox.SelectedItem = selectedAppointment[5].ToString();

            ModifyAppointmentContactTextBox.Text = selectedAppointment[6].ToString();

            ModifyAppointmentTypeComboBox.SelectedItem = selectedAppointment[7].ToString();

            if (selectedAppointment[8] != null)
            {
                ModifyAppointmentUrlTextBox.Text = selectedAppointment[8].ToString();
            }

            ModifyAppointmentStartDateTimePicker.Value = Convert.ToDateTime(selectedAppointment[9]); // FIMXE: Need to recall these datetimes in local time

            ModifyAppointmentEndDateTimePicker.Value = Convert.ToDateTime(selectedAppointment[10]);

            ModifyAppointmentConsultantTextBox.Text = associatedUser[1].ToString();

            ModifyAppointmentCustomerTextBox.Text = associatedCustomer[1].ToString();
        }

        private void ModifyAppointmentTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentTitleTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentDescriptionTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentLocationComboBox.Text != null)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentContactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentContactTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentTypeComboBox.Text != null)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentConsultantTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentConsultantTextBox.TextLength > 0)
            {
                FieldStateTracker[5] = true;
            }

            else
            {
                FieldStateTracker[5] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAppointmentCustomerTextBox.TextLength > 0)
            {
                FieldStateTracker[6] = true;
            }

            else
            {
                FieldStateTracker[6] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAppointmentSelectConsultantButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm f = new ManageUsersForm(this);
            f.Show();
        }

        private void ModifyAppointmentSelectCustomerButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm(this);
            f.Show();
        }

        private void ModifyAppointmentSaveButton_Click(object sender, EventArgs e)
        {
            if (ModifyAppointmentStartDateTimePicker.Value < ModifyAppointmentEndDateTimePicker.Value)
            {
                // Put the text field inputs into types acceptable by the Update method
                string title = ModifyAppointmentTitleTextBox.Text;
                string description = ModifyAppointmentDescriptionTextBox.Text;
                string location = ModifyAppointmentLocationComboBox.SelectedItem.ToString();
                string contact = ModifyAppointmentContactTextBox.Text;
                string type = ModifyAppointmentTypeComboBox.SelectedItem.ToString();
                string url = ModifyAppointmentUrlTextBox.Text;
                DateTime startDate = ModifyAppointmentStartDateTimePicker.Value.ToUniversalTime();
                string start = startDate.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime endDate = ModifyAppointmentEndDateTimePicker.Value.ToUniversalTime();
                string end = endDate.ToString("yyyy-MM-dd HH:mm:ss");

                // Update the record in the Appointment table
                Globals.UpdateAppointmentRecord(AppointmentID, CustomerID, UserID, title, description, location, contact, type, url, start, end);

                // Clear the current datagridview selection
                Globals.CurrentDataGridSelection = null;

                // Close the Add Customer Form and refresh the Manage Customers datagridview
                this.sourceForm.DataGridViewRefresh();

                Close();
            }
            
            else
            {
                MessageBox.Show("Please select an end date/time that is after the start date/time.");
            }
        }

        private void ModifyAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any required text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                ModifyAppointmentSaveButton.Enabled = false;
            }

            else
            {
                ModifyAppointmentSaveButton.Enabled = true;
            }
        }

        public void FillConsultantName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                UserID = int.Parse(Globals.CurrentDataGridSelection);

                Object[] selectionContents = Globals.GetSelectedRowContents("user", UserID);

                ModifyAppointmentConsultantTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null;
        }

        public void FillCustomerName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                CustomerID = int.Parse(Globals.CurrentDataGridSelection);

                Object[] selectionContents = Globals.GetSelectedRowContents("customer", CustomerID);

                ModifyAppointmentCustomerTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null;
        }
    }
}
