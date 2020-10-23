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
        public ManageAddressesForm()
        {
            InitializeComponent();
        }

        private void ManageAddresses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u06vbiDataSet.address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.u06vbiDataSet.address);
        }

        private void ManageAddressesForm_Activated(object sender, EventArgs e)
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

            textBox1.Text = Globals.CurrentDataGridSelection; // FIXME: Remove this before submission
            textBox2.Text = selectionContents[1].ToString();
        }

        private void ManageAddressesAddButton_Click(object sender, EventArgs e)
        {
            AddAddressForm f = new AddAddressForm();
            f.Show();

            Close();
        }

        private void ManageAddressesModifyButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageAddressesDeleteButton_Click(object sender, EventArgs e)
        {
            // FIXME: Delete the record and then this.addresstableadapter.fill?
        }

        private void ManageAddressesUseSelectedButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageAddressesCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
