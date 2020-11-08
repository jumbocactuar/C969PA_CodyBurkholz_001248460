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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void AppointmentTypesButton_Click(object sender, EventArgs e)
        {
            AppointmentTypesReportForm f = new AppointmentTypesReportForm();
            f.Show();
        }

        private void ConsultantScheduleButton_Click(object sender, EventArgs e)
        {
            ConsultantScheduleReportForm f = new ConsultantScheduleReportForm();
            f.Show();
        }

        private void CustomerScheduleButton_Click(object sender, EventArgs e)
        {
            CustomerScheduleReportForm f = new CustomerScheduleReportForm();
            f.Show();
        }

        private void ActivityLogButton_Click(object sender, EventArgs e)
        {

        }
    }
}
