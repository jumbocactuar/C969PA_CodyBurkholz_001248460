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
        private ManageAppointmentsForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false, false, false, false };

        public static int CustomerID;

        public static int UserID;

        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        public AddAppointmentForm(Form callingForm)
        {
            sourceForm = callingForm as ManageAppointmentsForm;
            
            InitializeComponent();

            AddAppointmentStartDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
            AddAppointmentEndDateTimePicker.CustomFormat = "HH:mm:ss yyyy/MM/dd";
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            AddAppointmentSaveButton.Enabled = false;
        }

        private void AddAppointmentTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAppointmentTitleTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAppointmentDescriptionTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddAppointmentLocationComboBox.Text != null)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentContactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAppointmentContactTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddAppointmentTypeComboBox.Text != null)
            {
                FieldStateTracker[4] = true;
            }

            else
            {
                FieldStateTracker[4] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentConsultantTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAppointmentConsultantTextBox.TextLength > 0)
            {
                FieldStateTracker[5] = true;
            }

            else
            {
                FieldStateTracker[5] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAppointmentCustomerTextBox.TextLength > 0)
            {
                FieldStateTracker[6] = true;
            }

            else
            {
                FieldStateTracker[6] = false;
            }

            UpdateSaveButton();
        }

        private void AddAppointmentSelectConsultantButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm f = new ManageUsersForm(this);
            f.Show();
        }

        private void AddAppointmentSelectCustomerButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm(this);
            f.Show();
        }

        private void AddAppointmentSaveButton_Click(object sender, EventArgs e)
        {
            if (AddAppointmentStartDateTimePicker.Value < AddAppointmentEndDateTimePicker.Value)
            {
                // Put the text field inputs into types acceptable by the Insert method
                string title = AddAppointmentTitleTextBox.Text;
                string description = AddAppointmentDescriptionTextBox.Text;
                string location = AddAppointmentLocationComboBox.SelectedItem.ToString();
                string contact = AddAppointmentContactTextBox.Text;
                string type = AddAppointmentTypeComboBox.SelectedItem.ToString();
                string url = AddAppointmentUrlTextBox.Text;
                DateTime startDate = AddAppointmentStartDateTimePicker.Value.ToUniversalTime();
                string start = startDate.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime endDate = AddAppointmentEndDateTimePicker.Value.ToUniversalTime();
                string end = endDate.ToString("yyyy-MM-dd HH:mm:ss");

                // Create a record in the Appointment table
                Globals.InsertAppointmentRecord(CustomerID, UserID, title, description, location, contact, type, url, start, end);

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

        private void AddAppointmentCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any required text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                AddAppointmentSaveButton.Enabled = false;
            }

            else
            {
                AddAppointmentSaveButton.Enabled = true;
            }
        }

        public void FillConsultantName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                UserID = int.Parse(Globals.CurrentDataGridSelection);

                Object[] selectionContents = Globals.GetSelectedRowContents("user", UserID);

                AddAppointmentConsultantTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null; // FIXME: Make sure this doens't interfere with anything
        }

        public void FillCustomerName()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                CustomerID = int.Parse(Globals.CurrentDataGridSelection);

                Object[] selectionContents = Globals.GetSelectedRowContents("customer", CustomerID);

                AddAppointmentCustomerTextBox.Text = selectionContents[1].ToString();
            }

            Globals.CurrentDataGridSelection = null; // FIXME: Make sure this doesn't interfere with anything
        }
    }
}
