using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            //CultureInfo.CurrentUICulture = new CultureInfo("es-MX", false);

            if (CultureInfo.CurrentUICulture.Name == "es-MX")
            {
                LoginFormLabel.Text = "Iniciar Sesión";
                LoginUserNameLabel.Text = "Nombre de usuario";
                LoginPasswordLabel.Text = "Contraseña";
                LoginLogInButton.Text = "Iniciar Sesión";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // FIXME: Remove if not used
        }

        private void LoginLogInButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser = LoginUserNameTextBox.Text;

            string tempPass = LoginPasswordTextBox.Text;

            string userName = Globals.GetLoginInfo("userName", Globals.CurrentUser);

            string password = Globals.GetLoginInfo("password", tempPass);

            try
            {
                if (userName != Globals.CurrentUser | password != tempPass)
                {
                    throw new InvalidCredentialsException();
                }

                else
                {
                    ManagementPortalForm f = new ManagementPortalForm();
                    f.Show();
                }
            }

            catch (InvalidCredentialsException ex)
            {
                if (CultureInfo.CurrentUICulture.Name == "es-MX")
                {
                    MessageBox.Show("El nombre de usuario o la contraseña es inválido/a.");
                }

                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
