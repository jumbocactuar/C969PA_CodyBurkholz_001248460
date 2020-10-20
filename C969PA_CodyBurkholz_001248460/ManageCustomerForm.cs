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

            //cxnString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

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
            // TODO: This line of code loads data into the 'u06vbiCustomerDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u06vbiDataSet.customer);
        }

        private void ManageCustomerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageCustomerDataGridView.ClearSelection();
        }

        private void ManageCustomerAddButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.Show();
        }
    }
}
