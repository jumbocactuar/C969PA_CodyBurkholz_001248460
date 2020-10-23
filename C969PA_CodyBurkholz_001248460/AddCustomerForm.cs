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
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null) // FIXME: I don't think this can happen at load because the Add Customer form doesn't reload - can I just ask for the name later and have the Manage Addresses form come up first?
            {
                Object[] selectionContents = Globals.GetSelectedRowContents("address", int.Parse(Globals.CurrentDataGridSelection));

                AddCustomerAddress1TextBox.Text = selectionContents[1].ToString();
                AddCustomerAddress2TextBox.Text = selectionContents[2].ToString();

                switch (selectionContents[3])
                {
                    case 1: AddCustomerCityTextBox.Text = "London";
                        break;

                    case 2: AddCustomerCityTextBox.Text = "New York";
                        break;

                    case 3: AddCustomerCityTextBox.Text = "Phoenix";
                        break;
                }

                AddCustomerPostalCodeTextBox.Text = selectionContents[4].ToString();
                AddCustomerPhoneTextBox.Text = selectionContents[5].ToString();
            }
        }

        private void AddCustomerSelectAddressButton_Click(object sender, EventArgs e)
        {
            ManageAddressesForm f = new ManageAddressesForm();
            f.Show();
        }

        private void AddCustomerSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Insert methods
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
            Globals.InsertCustomerRecord(name, addressID, active); // FIXME: The record above isn't getting entered before this one does, need to delay, somehow wait and check that it's in the db?

            // Close the Add Customer Form and reopen the Manage Customer form
            ManageCustomerForm f = new ManageCustomerForm();
            f.Show();

            Close();
        }

        private void AddCustomerCancelButton_Click(object sender, EventArgs e)
        {
            // Close the Add Customer Form and reopen the Manage Customer form
            ManageCustomerForm f = new ManageCustomerForm();
            f.Show();

            Close();
        }
    }
}
