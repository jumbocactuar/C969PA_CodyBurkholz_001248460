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

        private void AddCustomerSaveButton_Click(object sender, EventArgs e)
        {
            //U06vbiDataSet.customerRow newCustomerRow;
            //newCustomerRow = U06vbiDataSet.customer
            //U06vbiDataSetTableAdapters.customerTableAdapter customerTableAdapter = U06vbiDataSetTableAdapters.customerTableAdapter();

            //customerTableAdapter.Insert("Jimbo Jones", 3, 1, DateTime.Now, "This Guy", DateTime.UtcNow, "That Guy");
        }

        private void AddCustomerCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
