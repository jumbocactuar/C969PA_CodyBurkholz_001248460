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
        public AddAddressForm()
        {
            InitializeComponent();
        }

        private void AddCustomerSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Insert methods
            string address1 = AddAddressAddress1TextBox.Text;
            string address2 = AddAddressAddress2TextBox.Text;
            string city = AddAddressCityComboBox.SelectedItem.ToString();
            string postalCode = AddAddressPostalCodeTextBox.Text;
            string phone = AddAddressPhoneTextBox.Text;

            // Create a record in the Address table
            Globals.InsertAddressRecord(address1, address2, city, postalCode, phone);

            // Close the Add Address form
            Close(); // FIXME: Figure out how to refresh dgv after adding an address
        }

        private void AddAddressCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
