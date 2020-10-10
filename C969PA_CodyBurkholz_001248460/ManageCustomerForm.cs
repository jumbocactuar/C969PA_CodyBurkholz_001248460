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
        //U06vbiDataSetTableAdapters.customerTableAdapter customerTableAdapter = new customerTableAdapter();
        //customerTableAdapter.Fill(U06vbiDataSet.customer);

        public ManageCustomerForm()
        {
            InitializeComponent();

            string connectionString;
            DataTable dt = new DataTable();
            //DataGridView dgv = new DataGridView();

            connectionString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

            MySqlConnection cxnToMySQL = new MySqlConnection(connectionString);
            cxnToMySQL.Open();
            string initString = "SELECT * FROM customer";
            MySqlCommand cmdToMySQL = new MySqlCommand(initString, cxnToMySQL); // FIXME: Replace initString with the value from a textbox?
            MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);
            adapterToMySQL.Fill(dt);
            ManageCustomerDataGridView.DataSource = dt;
            cxnToMySQL.Close();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u06vbiCustomerDataSet.customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.u06vbiDataSet.customer);
        }

        private void ManageCustomerAddButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.Show();
        }
    }
}
