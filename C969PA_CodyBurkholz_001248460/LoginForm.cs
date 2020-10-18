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
           /* // Populate the User table
            Globals.InsertUserRecord("test", "test", 1);*/
        }

        private void BypassButton_Click(object sender, EventArgs e)
        {
            ManagementPortalForm f = new ManagementPortalForm();
            f.Show();
        }

        private void LoginLogInButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser = LoginUserNameTextBox.Text;

            string tempPass = LoginPasswordTextBox.Text;

            string userName = Globals.GetLoginInfo("userName", Globals.CurrentUser);

            string password = Globals.GetLoginInfo("password", tempPass);

            if (userName == Globals.CurrentUser && password == tempPass)
            {
                ManagementPortalForm f = new ManagementPortalForm();
                f.Show(); // FIXME: Figure out how to close the form upon successful login, figure out how to handle when GetLoginInfo encounters a null value
            }

            else
            {
                MessageBox.Show("Incorrect User Name or Password");
            }
        }
    }
}
