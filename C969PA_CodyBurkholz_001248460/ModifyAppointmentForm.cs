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
        }

        private void AddAppointmentTitleTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddAppointmentDescriptionTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddAppointmentLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void AddAppointmentContactTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddAppointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void AddAppointmentConsultantTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddAppointmentCustomerTextBox_TextChanged(object sender, EventArgs e)
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

            // Create a record in the Appointment table
            Globals.UpdateAppointmentRecord(CustomerID, UserID, title, description, location, contact, type, url, start, end);

            // Clear the current datagridview selection
            Globals.CurrentDataGridSelection = null;

            // Close the Add Customer Form and refresh the Manage Customers datagridview
            this.sourceForm.DataGridViewRefresh();

            Close();
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
