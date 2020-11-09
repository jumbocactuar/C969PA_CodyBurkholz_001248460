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
    public partial class ManagementPortalForm : Form
    {
        public ManagementPortalForm()
        {
            InitializeComponent();
        }

        private void ManagementPortalForm_Load(object sender, EventArgs e)
        {

        }

        private void ManagementPortalCustomersButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm();
            f.Show();
        }

        private void ManagementPortalAppointmentsButton_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm f = new ManageAppointmentsForm();
            f.Show();
        }

        private void ManagementPortalAppointmentCalendarButton_Click(object sender, EventArgs e)
        {
            AppointmentCalendarForm f = new AppointmentCalendarForm();
            f.Show();
        }

        private void ManagementPortalManageUsersButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm f = new ManageUsersForm();
            f.Show();
        }

        private void ManagementPortalReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm f = new ReportsForm();
            f.Show();
        }
    }
}
