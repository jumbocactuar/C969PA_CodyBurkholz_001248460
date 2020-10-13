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
            //Populate the Country table if it is empty
            if (Globals.CountryIDCounter == 0) // FIXME: This won't work--the counter resets every time the app is closed; need to look into the DB
            {
                Globals.InsertRecord("country", "United Kingdom");
                Globals.InsertRecord("country", "United States");
            }
        }

        private void BypassButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm f = new ManageCustomerForm();
            f.Show();
        }
    }
}
