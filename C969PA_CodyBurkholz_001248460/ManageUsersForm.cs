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
    public partial class ManageUsersForm : Form
    {
        private AddAppointmentForm sourceForm = null;

        public ManageUsersForm()
        {
            InitializeComponent();

            ManageUsersUseSelectedButton.Hide();
        }

        public ManageUsersForm(Form callingForm)
        {
            sourceForm = callingForm as AddAppointmentForm;

            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.u06vbiDataSet.user);
        }

        private void ManageUsersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageUsersDataGridView.ClearSelection();
        }

        private void ManageUsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageUsersDataGridView.CurrentCell.RowIndex;

            Globals.CurrentDataGridSelection = ManageUsersDataGridView.Rows[selection].Cells[0].Value.ToString();
        }

        private void ManageUsersAddButton_Click(object sender, EventArgs e)
        {
            AddUserForm f = new AddUserForm();
            f.Show();

            Close();
        }

        private void ManageUsersModifyButton_Click(object sender, EventArgs e)
        {
            ModifyUserForm f = new ModifyUserForm();
            f.Show();

            Close();
        }

        private void ManageUsersDeleteButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                string message = "Delete the selected user?";
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.OK)
                {
                    Globals.DeleteRecord("user", int.Parse(Globals.CurrentDataGridSelection));

                    Globals.CurrentDataGridSelection = null;

                    this.userTableAdapter.Fill(this.u06vbiDataSet.user);

                    ManageUsersDataGridView.ClearSelection();
                }
            }

            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ManageUsersUseSelectedButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                this.sourceForm.FillConsultantName();

                Close();
            }

            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private void ManageUsersCancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentDataGridSelection = null;

            Close();
        }
    }
}
