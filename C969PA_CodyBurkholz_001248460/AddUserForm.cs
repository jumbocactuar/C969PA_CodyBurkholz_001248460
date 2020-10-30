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
    public partial class AddUserForm : Form
    {
        private ManageUsersForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false };

        public AddUserForm()
        {
            InitializeComponent();
        }

        public AddUserForm(Form callingForm)
        {
            sourceForm = callingForm as ManageUsersForm;

            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            AddUserSaveButton.Enabled = false;
        }

        private void AddUserUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddUserUserNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void AddUserPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddUserPasswordTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void AddUserSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Insert method
            string userName = AddUserUserNameTextBox.Text;
            string password = AddUserPasswordTextBox.Text;
            byte active;

            if (AddUserActiveCheckBox.Checked == true)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            // Create a record in the User table
            Globals.InsertUserRecord(userName, password, active);

            // Clear the current data grid selection
            Globals.CurrentDataGridSelection = null;

            // Close the Add User form and refresh the Manage Users datagridview
            this.sourceForm.DataGridViewRefresh();

            Close();
        }

        private void AddUserCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                AddUserSaveButton.Enabled = false;
            }

            else
            {
                AddUserSaveButton.Enabled = true;
            }
        }
    }
}
