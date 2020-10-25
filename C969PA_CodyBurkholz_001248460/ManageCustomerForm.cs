using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters;
using MySql.Data.MySqlClient;

namespace C969PA_CodyBurkholz_001248460
{
    public partial class ManageCustomerForm : Form
    {
        public ManageCustomerForm()
        {
            InitializeComponent();

            //string cxnString;
            DataTable dt = new DataTable();

            // FIXME: Reevaluate whether some of the below is necessary (but if it ain't broke, don't fix it)

            MySqlConnection cxnToMySQL = new MySqlConnection(Globals.cxnString);
            cxnToMySQL.Open();
            string initString = "SELECT * FROM customer";
            MySqlCommand cmdToMySQL = new MySqlCommand(initString, cxnToMySQL);
            MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);
            adapterToMySQL.Fill(dt);
            ManageCustomerDataGridView.DataSource = dt;
            cxnToMySQL.Close();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.u06vbiDataSet.customer);

            ManageCustomerDataGridView.ClearSelection();
        }

        private void ManageCustomerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageCustomerDataGridView.ClearSelection();
        }

        private void ManageCustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageCustomerDataGridView.CurrentCell.RowIndex;

            Globals.CurrentDataGridSelection = ManageCustomerDataGridView.Rows[selection].Cells[0].Value.ToString();
        }

        private void ManageCustomerAddButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.Show();

            Close();
        }

        private void ManageCustomerModifyButton_Click(object sender, EventArgs e)
        {
            ModifyCustomerForm f = new ModifyCustomerForm();
            f.Show();
        }

        private void ManageCustomerDeleteButton_Click(object sender, EventArgs e)
        {
            // FIXME: copy confirmation dialog from C968 project, then use CurrentDataGridSelection to delete the record from the db
        }

        private void ManageCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
