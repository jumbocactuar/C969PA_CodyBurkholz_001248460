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
    public partial class AddAddressForm : Form
    {
        private ManageAddressesForm sourceForm = null;

        public static List<bool> FieldStateTracker = new List<bool> { false, false, false, false };

        public AddAddressForm()
        {
            InitializeComponent();
        }

        public AddAddressForm(Form callingForm)
        {
            sourceForm = callingForm as ManageAddressesForm;
            
            InitializeComponent();
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            AddAddressSaveButton.Enabled = false;
        }

        private void AddAddressAddress1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAddressAddress1TextBox.TextLength > 0)
            {
                FieldStateTracker[0] = true;
            }

            else
            {
                FieldStateTracker[0] = false;
            }

            UpdateSaveButton();
        }

        private void AddAddressCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddAddressCityComboBox.Text != null)
            {
                FieldStateTracker[1] = true;
            }

            else
            {
                FieldStateTracker[1] = false;
            }

            UpdateSaveButton();
        }

        private void AddAddressPostalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAddressPostalCodeTextBox.TextLength > 0)
            {
                FieldStateTracker[2] = true;
            }

            else
            {
                FieldStateTracker[2] = false;
            }

            UpdateSaveButton();
        }

        private void AddAddressPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddAddressPhoneTextBox.TextLength > 0)
            {
                FieldStateTracker[3] = true;
            }

            else
            {
                FieldStateTracker[3] = false;
            }

            UpdateSaveButton();
        }

        private void AddAddressSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into types acceptable by the Insert method
            string address1 = AddAddressAddress1TextBox.Text;
            string address2 = AddAddressAddress2TextBox.Text;
            string city = AddAddressCityComboBox.SelectedItem.ToString();
            string postalCode = AddAddressPostalCodeTextBox.Text;
            string phone = AddAddressPhoneTextBox.Text;

            try
            {
                bool invalid = Globals.InvalidDataCheck(phone);

                if (invalid == true)
                {
                    throw new InvalidCustomerDataException("The phone number entered contains invalid characters.");
                }

                else
                {
                    // Create a record in the Address table
                    Globals.InsertAddressRecord(address1, address2, city, postalCode, phone);

                    // Close the Add Address form and refresh the Manage Addresses datagridview
                    this.sourceForm.DataGridViewRefresh();

                    Close();
                }
            }

            catch (InvalidCustomerDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddAddressCancelButton_Click(object sender, EventArgs e)
        {   
            Close();
        }

        private void UpdateSaveButton()
        {
            // If any FieldStateTracker values are false (i.e., any text boxes are empty), disable the Save button
            if (FieldStateTracker.Contains(false) == true)
            {
                AddAddressSaveButton.Enabled = false;
            }

            else
            {
                AddAddressSaveButton.Enabled = true;
            }
        }
    }
}
