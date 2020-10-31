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
    public partial class ModifyCustomerForm : Form // FIXME: Modify fails if you don't change the address (the addressId used is the same as the selected customerId)
    {
        private ManageCustomerForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false, false };

        public static string CustomerID;

        public static string AddressID;

        public ModifyCustomerForm()
        {
            InitializeComponent();
        }

        public ModifyCustomerForm(Form callingForm)
        {
            sourceForm = callingForm as ManageCustomerForm;

            InitializeComponent();
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Object[] selectedCustomer = Globals.GetSelectedRowContents("customer", int.Parse(Globals.CurrentDataGridSelection));

            CustomerID = selectedCustomer[0].ToString();

            string name = selectedCustomer[1].ToString();

            int spacePos = name.IndexOf(" ");

            ModifyCustomerFirstNameTextBox.Text = name.Substring(spacePos + 1);

            ModifyCustomerLastNameTextBox.Text = name.Substring(0, (spacePos - 1));

            string active = selectedCustomer[3].ToString();

            if (active == "True")
            {
                ModifyCustomerActiveCheckBox.Checked = true;
            }

            AddressID = selectedCustomer[2].ToString();

            Object[] selectedAddress = Globals.GetSelectedRowContents("address", int.Parse(AddressID));

            ModifyCustomerAddress1TextBox.Text = selectedAddress[1].ToString();
            
            if (selectedAddress[2] != null)
            {
                ModifyCustomerAddress2TextBox.Text = selectedAddress[2].ToString();
            }

            switch (selectedAddress[3])
            {
                case 1:
                    ModifyCustomerCityTextBox.Text = "London";
                    break;

                case 2:
                    ModifyCustomerCityTextBox.Text = "New York";
                    break;

                case 3:
                    ModifyCustomerCityTextBox.Text = "Phoenix";
                    break;
                default:
                    break;
            }

            ModifyCustomerPostalCodeTextBox.Text = selectedAddress[4].ToString();

            ModifyCustomerPhoneTextBox.Text = selectedAddress[5].ToString();
        }

        private void ModifyCustomerFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyCustomerFirstNameTextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyCustomerLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyCustomerLastNameTextBox.TextLength > 0)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyCustomerAddress1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyCustomerAddress1TextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyCustomerSelectAddressButton_Click(object sender, EventArgs e)
        {
            ManageAddressesForm f = new ManageAddressesForm(this);
            f.Show();
        }

        private void ModifyCustomerSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Update method
            int customerID = int.Parse(CustomerID);
            string name = $"{ModifyCustomerLastNameTextBox.Text}, {ModifyCustomerFirstNameTextBox.Text}";
            int addressID = int.Parse(AddressID);
            byte active;

            if (ModifyCustomerActiveCheckBox.Checked == true)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            // Update the record in the Customer table
            Globals.UpdateCustomerRecord(customerID, name, active, addressID);

            // Clear the current datagridview selection
            Globals.CurrentDataGridSelection = null;

            // Close the Add Customer Form and refresh the Manage Customers datagridview
            this.sourceForm.DataGridViewRefresh();

            Close();
        }

        private void ModifyCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FillAddressInfo()
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                Object[] selectionContents = Globals.GetSelectedRowContents("address", int.Parse(Globals.CurrentDataGridSelection));

                ModifyCustomerAddress1TextBox.Text = selectionContents[1].ToString();

                if (selectionContents[2] != null)
                {
                    ModifyCustomerAddress2TextBox.Text = selectionContents[2].ToString();
                }

                switch (selectionContents[3])
                {
                    case 1:
                        ModifyCustomerCityTextBox.Text = "London";
                        break;

                    case 2:
                        ModifyCustomerCityTextBox.Text = "New York";
                        break;

                    case 3:
                        ModifyCustomerCityTextBox.Text = "Phoenix";
                        break;
                    default:
                        break;
                }

                ModifyCustomerPostalCodeTextBox.Text = selectionContents[4].ToString();
                ModifyCustomerPhoneTextBox.Text = selectionContents[5].ToString();
            }
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                ModifyCustomerSaveButton.Enabled = false;
            }

            else
            {
                ModifyCustomerSaveButton.Enabled = true;
            }
        }
    }
}
