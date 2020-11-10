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
        private static List<List<string>> appointmentList = GenerateAppointmentList();

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
                    UpcomingAppointmentCheck();

                    Logger.LoginLog(Globals.CurrentUser);

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

        private static List<List<string>> GenerateAppointmentList()
        {
            // Generate a list of all appointments
            List<Object[]> appointmentList = Globals.GenerateTableList("appointment");

            // Generate a list of all users from which to get their names
            List<Object[]> userList = Globals.GenerateTableList("user");

            // Generate a list of all customers from which to get their names
            List<Object[]> customerList = Globals.GenerateTableList("customer");

            // Generate a list f appointments ready for presentation
            List<List<string>> presentableList = new List<List<string>>();

            foreach (Object[] appointment in appointmentList)
            {
                if (appointment[1] != null)
                {
                    string userID = appointment[2].ToString();
                    string customerID = appointment[1].ToString();
                    string start = appointment[9].ToString();
                    string end = appointment[10].ToString();

                    List<string> temp = new List<string> { userID, customerID, start, end };

                    presentableList.Add(temp);
                }

                else
                {
                    continue;
                }

            }

            foreach (List<string> appt in presentableList)
            {
                foreach (Object[] user in userList)
                {
                    string tempID = user[0].ToString();

                    if (tempID == appt[0])
                    {
                        appt[0] = user[1].ToString();
                    }

                    else
                    {
                        continue;
                    }
                }

            }

            foreach (List<string> appt in presentableList)
            {
                foreach (Object[] customer in customerList)
                {
                    string tempID = customer[0].ToString();

                    if (tempID == appt[1])
                    {
                        appt[1] = customer[1].ToString();
                    }

                    else
                    {
                        continue;
                    }
                }

            }

            return presentableList;
        }

        public static void UpcomingAppointmentCheck()
        {
            // Create a new list to hold the appointments associated with the current user
            List<List<string>> associatedAppts = new List<List<string>>();

            // Find all appointments associated with the current user
            foreach (List<string> appt in appointmentList)
            {
                string userName = appt[0];

                if (userName == Globals.CurrentUser)
                {
                    associatedAppts.Add(appt);

                    // Find any appointment scheduled to start within the next 15 minutes
                    foreach (List<string> appointment in associatedAppts)
                    {
                        DateTime start = Convert.ToDateTime(appointment[2]);
                        DateTime now = Convert.ToDateTime(Globals.GetMySqlNow());
                        DateTime now15 = now.AddMinutes(15);
                        DateTime presentableStart = Convert.ToDateTime(appointment[2]);
                        presentableStart = presentableStart.ToLocalTime();

                        if ((start >= now) && (start <= now15))
                        {
                            MessageBox.Show($"You have an appointment with {appointment[1]} at {presentableStart}.");
                        }

                        else
                        {
                            continue;
                        }
                    }
                }

                else
                {
                    continue;
                }
            }
        }
    }
}
