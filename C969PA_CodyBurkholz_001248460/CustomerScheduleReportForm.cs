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
    public partial class CustomerScheduleReportForm : Form
    {
        public CustomerScheduleReportForm()
        {
            InitializeComponent();
        }

        private void CustomerScheduleReportForm_Load(object sender, EventArgs e)
        {
            CustomerScheduleDataGridView.DataSource = Globals.GenerateCustomerReport();
        }

        private void CustomerScheduleFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
