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
    public partial class ConsultantScheduleReportForm : Form
    {
        public ConsultantScheduleReportForm()
        {
            InitializeComponent();
        }

        private void ConsultantScheduleReportForm_Load(object sender, EventArgs e)
        {
            ConsultantScheduleDataGridView.DataSource = GenerateConsultantReport();
        }

        private void ConsultantScheduleCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static DataTable GenerateConsultantReport()
        {
            // Create a data table in which to store the selected info
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Consultant");
            dt.Columns.Add("Appointment Start");
            dt.Columns.Add("Appointment End");

            // Generate a list of all appointments
            List<Object[]> appointmentList = Globals.GenerateTableList("appointment");

            // Generate a list of all users from which to get their names
            List<Object[]> userList = Globals.GenerateTableList("user");

            // Sort the list of appointments
            List<List<string>> sortedAppts = new List<List<string>>();

            foreach (Object[] appointment in appointmentList)
            {
                if (appointment[1] != null)
                {
                    string userID = appointment[2].ToString();
                    string start = appointment[9].ToString();
                    string end = appointment[10].ToString();

                    List<string> temp = new List<string> { userID, start, end };

                    sortedAppts.Add(temp);
                }

                else
                {
                    continue;
                }

            }

            // Convert the userIDs to names
            foreach (List<string> appt in sortedAppts)
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

            // Sort the distilled list by user name
            // Lambda used to define comparison terms for sorting
            sortedAppts.Sort((x, y) => string.Compare(x[0], y[0]));

            // Place the pertinent info into the data table
            foreach (List<string> appointment in sortedAppts)
            {
                DataRow row = dt.NewRow();

                row[0] = appointment[0];
                row[1] = appointment[1];
                row[2] = appointment[2];

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
