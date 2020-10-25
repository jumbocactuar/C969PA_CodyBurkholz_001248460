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
    public partial class ModifyCustomerForm : Form
    {
        public ModifyCustomerForm()
        {
            InitializeComponent();
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            Object[] selectedCustomer = Globals.GetSelectedRowContents("customer", int.Parse(Globals.CurrentDataGridSelection));

            string name = selectedCustomer[1].ToString();

            int spacePos = name.IndexOf(" ");

            ModifyCustomerFirstNameTextBox.Text = name.Substring(spacePos + 1);

            ModifyCustomerLastNameTextBox.Text = name.Substring(0, (spacePos - 1));

            string active = selectedCustomer[3].ToString();

            if (active == "True")
            {
                ModifyCustomerActiveCheckBox.Checked = true;
            }

            string addressID = selectedCustomer[2].ToString();

            Object[] selectedAddress = Globals.GetSelectedRowContents("address", int.Parse(addressID));

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

        private void ModifyCustomerSelectAddressButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyCustomerSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
