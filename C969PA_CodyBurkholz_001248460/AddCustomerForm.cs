using C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters;
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
    public partial class AddCustomerForm : Form
    {
        private ManageCustomerForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false, false };

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        public AddCustomerForm(Form callingForm)
        {
            sourceForm = callingForm as ManageCustomerForm;

            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            AddCustomerSaveButton.Enabled = false;
        }

        private void AddCustomerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddCustomerFirstNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void AddCustomerLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddCustomerLastNameTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void AddCustomerAddress1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddCustomerAddress1TextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void AddCustomerSelectAddressButton_Click(object sender, EventArgs e)
        {
            ManageAddressesForm f = new ManageAddressesForm(this);
            f.Show();
        }

        private void AddCustomerSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into types acceptable by the Insert method
            string name = $"{AddCustomerLastNameTextBox.Text}, {AddCustomerFirstNameTextBox.Text}";
            int addressID = int.Parse(Globals.CurrentDataGridSelection);
            byte active;

            if (AddCustomerActiveCheckBox.Checked == true)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            // Create a record in the Customer table
            Globals.InsertCustomerRecord(name, addressID, active);

            // Clear the current datagridview selection
            Globals.CurrentDataGridSelection = null;

            // Close the Add Customer Form and refresh the Manage Customers datagridview
            this.sourceForm.DataGridViewRefresh();

            Close();
        }

        private void AddCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentDataGridSelection = null;

            Close();
        }

        public void FillAddressInfo()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                Object[] selectionContents = Globals.GetSelectedRowContents("address", int.Parse(Globals.CurrentDataGridSelection));

                AddCustomerAddress1TextBox.Text = selectionContents[1].ToString();

                if (selectionContents[2] != null)
                {
                    AddCustomerAddress2TextBox.Text = selectionContents[2].ToString();
                }

                switch (selectionContents[3])
                {
                    case 1:
                        AddCustomerCityTextBox.Text = "London";
                        break;

                    case 2:
                        AddCustomerCityTextBox.Text = "New York";
                        break;

                    case 3:
                        AddCustomerCityTextBox.Text = "Phoenix";
                        break;
                    default:
                        break;
                }

                AddCustomerPostalCodeTextBox.Text = selectionContents[4].ToString();
                AddCustomerPhoneTextBox.Text = selectionContents[5].ToString();
            }
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                AddCustomerSaveButton.Enabled = false;
            }

            else
            {
                AddCustomerSaveButton.Enabled = true;
            }
        }
    }
}
