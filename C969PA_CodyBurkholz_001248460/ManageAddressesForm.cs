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

        private void ManageAddressesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageAddressesDataGridView.ClearSelection();
            ManageAddressesDataGridView.ReadOnly = true;
        }

        private void ManageAddressesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageAddressesDataGridView.CurrentCell.RowIndex;

            var addressID = ManageAddressesDataGridView.Rows[selection].Cells[0].Value.ToString();

            Globals.CurrentDataGridSelection = addressID;

            textBox1.Text = Globals.CurrentDataGridSelection; // FIXME: Remove this before submission
        }

        private void ManageAddressesAddButton_Click(object sender, EventArgs e)
        {
            AddAddressForm f = new AddAddressForm();
            f.Show();
        }

        private void ManageAddressesModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void ManageAddressesDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ManageAddressesUseSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void ManageAddressesCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
