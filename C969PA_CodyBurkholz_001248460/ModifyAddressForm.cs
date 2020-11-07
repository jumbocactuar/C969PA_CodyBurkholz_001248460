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
    public partial class ModifyAddressForm : Form
    {
        private ManageAddressesForm sourceForm = null;
        
        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false };

        public ModifyAddressForm()
        {
            InitializeComponent();
        }

        public ModifyAddressForm(Form callingForm)
        {
            sourceForm = callingForm as ManageAddressesForm;

            InitializeComponent();
        }

        private void ModifyAddressForm_Load(object sender, EventArgs e)
        {
            // Get the selected address
            Object[] selectedAddress = Globals.GetSelectedRowContents("address", int.Parse(Globals.CurrentDataGridSelection));

            // Fill the textboxes with the selected address info
            ModifyAddressAddress1TextBox.Text = selectedAddress[1].ToString();

            ModifyAddressAddress2TextBox.Text = selectedAddress[2].ToString();

            switch (selectedAddress[3])
            {
                case 1:
                    ModifyAddressCityComboBox.SelectedItem = "London";
                    break;

                case 2:
                    ModifyAddressCityComboBox.SelectedItem = "New York";
                    break;

                case 3:
                    ModifyAddressCityComboBox.SelectedItem = "Phoenix";
                    break;
                default:
                    break;
            }

            ModifyAddressPostalCodeTextBox.Text = selectedAddress[4].ToString();

            ModifyAddressPhoneTextBox.Text = selectedAddress[5].ToString();
        }

        private void ModifyAddressAddress1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAddressAddress1TextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAddressCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModifyAddressCityComboBox.Text != null)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAddressPostalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAddressPostalCodeTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAddressPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModifyAddressPhoneTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void ModifyAddressSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Update method
            int addressID = int.Parse(Globals.CurrentDataGridSelection);
            string address1 = ModifyAddressAddress1TextBox.Text;
            string address2 = ModifyAddressAddress2TextBox.Text;
            string city = ModifyAddressCityComboBox.SelectedItem.ToString();
            string postalCode = ModifyAddressPostalCodeTextBox.Text;
            string phone = ModifyAddressPhoneTextBox.Text;

            try
            {
                bool invalid = Globals.InvalidDataCheck(phone);

                if (invalid == true)
                {
                    throw new InvalidCustomerDataException("The phone number entered contains invalid characters.");
                }

                else
                {
                    // Update the record in the Address table
                    Globals.UpdateAddressRecord(addressID, address1, address2, city, postalCode, phone);

                    // Clear the current data grid selection
                    Globals.CurrentDataGridSelection = null;

                    // Close the Modify Address form and refresh the Manage Addresses datagridview
                    this.sourceForm.DataGridViewRefresh();

                    Close();
                }
            }

            catch (InvalidCustomerDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifyAddressCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                ModifyAddressSaveButton.Enabled = false;
            }

            else
            {
                ModifyAddressSaveButton.Enabled = true;
            }
        }
    }
}
