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
            /*// Populate the Country table
            Globals.InsertCountryRecord("United Kingdom");
            Globals.InsertCountryRecord("United States");*/

            /*// Populate the City table
            Globals.InsertCityRecord("London");
            Globals.InsertCityRecord("New York");
            Globals.InsertCityRecord("Phoenix");*/

            /*// Populate the Address table
            Globals.InsertAddressRecord("123 5th Ave", "Apt. 4", "New York", "10001", "222-222-2222");*/

            /*// Populate the Customer table
            Globals.InsertCustomerRecord("Jones, Alan", 1, 1);*/
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
