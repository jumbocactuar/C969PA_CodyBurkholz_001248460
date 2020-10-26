using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA_CodyBurkholz_001248460
{
    public partial class ManageAddressesForm : Form
    {
        private AddCustomerForm sourceForm = null;

        private ModifyCustomerForm sourceForm2 = null;

        public ManageAddressesForm()
        {
            InitializeComponent();
        }

        public ManageAddressesForm(Form callingForm)
        {
            sourceForm = callingForm as AddCustomerForm;

            sourceForm2 = callingForm as ModifyCustomerForm;

            InitializeComponent();
        }

        private void ManageAddresses_Load(object sender, EventArgs e)
        {
            this.addressTableAdapter.Fill(this.u06vbiDataSet.address);
        }

        private void ManageAddressesForm_Activated(object sender, EventArgs e) // FIXME: Unclear whether this is needed
        {
            this.addressTableAdapter.Fill(this.u06vbiDataSet.address);
        }

        private void ManageAddressesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageAddressesDataGridView.ClearSelection();
            ManageAddressesDataGridView.ReadOnly = true;
        }

        private void ManageAddressesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageAddressesDataGridView.CurrentCell.RowIndex;

            Globals.CurrentDataGridSelection = ManageAddressesDataGridView.Rows[selection].Cells[0].Value.ToString();

            Object[] selectionContents = Globals.GetSelectedRowContents("address", int.Parse(Globals.CurrentDataGridSelection));
        }

        private void ManageAddressesAddButton_Click(object sender, EventArgs e)
        {
            AddAddressForm f = new AddAddressForm();
            f.Show();

            Close();
        }

        private void ManageAddressesModifyButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                ModifyAddressForm f = new ModifyAddressForm();
                f.Show();
            }

            else
            {
                MessageBox.Show("Please select an address to modify.");
            }
        }

        private void ManageAddressesDeleteButton_Click(object sender, EventArgs e) // FIXME: dgv doesn't refresh after delete, dgv.refresh doesn't seem to do it
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                string message = "Delete the selected address?";
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.OK)
                {
                    Globals.DeleteRecord("address", int.Parse(Globals.CurrentDataGridSelection));

                    Globals.CurrentDataGridSelection = null;

                    this.addressTableAdapter.Fill(this.u06vbiDataSet.address);
                }
            }

            else
            {
                MessageBox.Show("Please select an address to delete.");
            }
        }

        private void ManageAddressesUseSelectedButton_Click(object sender, EventArgs e)
        {
            if (this.sourceForm != null)
            {
                this.sourceForm.FillAddressInfo();
            }

            else
            {
                this.sourceForm2.FillAddressInfo();
            }
            
            Close();
        }

        private void ManageAddressesCancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentDataGridSelection = null;

            Close();
        }
    }
}
