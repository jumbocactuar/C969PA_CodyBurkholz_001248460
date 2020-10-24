﻿using System;
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
        public ModifyAddressForm()
        {
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

        private void ModifyAddressSaveButton_Click(object sender, EventArgs e)
        {
            // Put the text field inputs into forms acceptable by the Update method
            int addressID = int.Parse(Globals.CurrentDataGridSelection);
            string address1 = ModifyAddressAddress1TextBox.Text;
            string address2 = ModifyAddressAddress2TextBox.Text;
            string city = ModifyAddressCityComboBox.SelectedItem.ToString();
            string postalCode = ModifyAddressPostalCodeTextBox.Text;
            string phone = ModifyAddressPhoneTextBox.Text;

            // Update the record in the Address table
            Globals.UpdateAddressRecord(addressID, address1, address2, city, postalCode, phone);

            // Close the Modify Address form
            Close();
        }

        private void ModifyAddressCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}