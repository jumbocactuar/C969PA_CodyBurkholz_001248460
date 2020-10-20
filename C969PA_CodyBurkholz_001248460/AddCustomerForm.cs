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

            // Close the Add Customer Form
            Close();
        }

        private void AddCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
