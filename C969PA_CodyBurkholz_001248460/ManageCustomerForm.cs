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
        private AddAppointmentForm sourceForm = null;

        private ModifyAppointmentForm sourceForm2 = null;

        public ManageCustomerForm()
        {
            InitializeComponent();

            /*//string cxnString;
            DataTable dt = new DataTable();

            // FIXME: Reevaluate whether some of the below is necessary (but if it ain't broke, don't fix it)

            MySqlConnection cxnToMySQL = new MySqlConnection(Globals.cxnString);
            cxnToMySQL.Open();
            string initString = "SELECT * FROM customer";
            MySqlCommand cmdToMySQL = new MySqlCommand(initString, cxnToMySQL);
            MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);
            adapterToMySQL.Fill(dt);
            ManageCustomerDataGridView.DataSource = dt;
            cxnToMySQL.Close();*/

            ManageCustomerUseSelectedButton.Hide();
        }

        public ManageCustomerForm(Form callingForm)
        {
            sourceForm = callingForm as AddAppointmentForm;

            sourceForm2 = callingForm as ModifyAppointmentForm;

            InitializeComponent();
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
            AddCustomerForm f = new AddCustomerForm(this);
            f.Show();
        }

        private void ManageCustomerModifyButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                ModifyCustomerForm f = new ModifyCustomerForm(this);
                f.Show();
            }

            else
            {
                MessageBox.Show("Please select a customer to modify.");
            }
        }

        private void ManageCustomerDeleteButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                string message = "Delete the selected customer?";
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.OK)
                {
                    Globals.DeleteRecord("customer", int.Parse(Globals.CurrentDataGridSelection));

                    Globals.CurrentDataGridSelection = null;

                    this.customerTableAdapter.Fill(this.u06vbiDataSet.customer);

                    ManageCustomerDataGridView.ClearSelection();
                }
            }

            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void ManageCustomerUseSelectedButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                if (this.sourceForm != null)
                {
                    this.sourceForm.FillCustomerName();

                    Close();
                }
                
                else
                {
                    this.sourceForm2.FillCustomerName();

                    Close();
                }
            }
            
            else
            {
                MessageBox.Show("Please select a customer.");
            }
        }

        private void ManageCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentDataGridSelection = null;

            Close();
        }

        public void DataGridViewRefresh()
        {
            this.customerTableAdapter.Fill(this.u06vbiDataSet.customer);

            ManageCustomerDataGridView.ClearSelection();
        }
    }
}
