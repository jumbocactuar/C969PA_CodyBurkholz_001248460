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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void AddUserUserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void AddUserCancelButton_Click(object sender, EventArgs e)
        {
            // FIXME: Upon closing this form, I need to reopen the version of Manage Users that has the Use Selected button, will "this" work? No!
            ManageUsersForm f = new ManageUsersForm(this);
            f.Show();

            Close();
        }
    }
}
