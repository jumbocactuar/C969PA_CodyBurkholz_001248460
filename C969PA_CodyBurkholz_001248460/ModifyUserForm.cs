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
    public partial class ModifyUserForm : Form
    {
        private ManageUsersForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false };

        public ModifyUserForm()
        {
            InitializeComponent();
        }

        public ModifyUserForm(Form callingForm)
        {
            sourceForm = callingForm as ManageUsersForm;

            InitializeComponent();
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {
            // Get the selected user
            Object[] selectedUser = Globals.GetSelectedRowContents("user", int.Parse(Globals.CurrentDataGridSelection));

            // Fill the textboxes with the selected address info
            ModifyUserUserNameTextBox.Text = selectedUser[1].ToString();
            ModifyUserPasswordTextBox.Text = selectedUser[2].ToString();

            string active = selectedUser[3].ToString();

            if (active == "1")
            {
                ModifyUserActiveCheckBox.Checked = true;
            }
        }

        private void ModifyUserUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyUserUserNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyUserPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyUserPasswordTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyUserSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Insert method
            int userID = int.Parse(Globals.CurrentDataGridSelection);
            string userName = ModifyUserUserNameTextBox.Text;
            string password = ModifyUserPasswordTextBox.Text;
            byte active;

            if (ModifyUserActiveCheckBox.Checked == true)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            // Update the record in the User table
            Globals.UpdateUserRecord(userID, userName, password, active);

            // Clear the current data grid selection
            Globals.CurrentDataGridSelection = null;

            // Close the Modify User form and refresh the Manage Users datagridview
            this.sourceForm.DataGridViewRefresh();

            Close();
        }

        private void ModifyUserCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                ModifyUserSaveButton.Enabled = false;
            }

            else
            {
                ModifyUserSaveButton.Enabled = true;
            }
        }
    }
}
