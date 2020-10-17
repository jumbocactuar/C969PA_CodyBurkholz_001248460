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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Populate the Country table
            Globals.InsertCountryRecord("United Kingdom");
            Globals.InsertCountryRecord("United States");

            // Populate the City table
            Globals.InsertCityRecord("London");
            Globals.InsertCityRecord("New York");
            Globals.InsertCityRecord("Phoenix");
        }

        private void BypassButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm();
            f.Show();
        }
    }
}
