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
    public partial class AppointmentCalendarForm : Form
    {
        private static List<List<string>> appointmentList = GenerateAppointmentList();

        public AppointmentCalendarForm()
        {
            InitializeComponent();
        }

        private void AppointmentCalendarForm_Load(object sender, EventArgs e)
        {
            AppointmentCalendarMonthRadioButton.Checked = true;
        }

        private void AppointmentCalendarMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (AppointmentCalendarMonthRadioButton.Checked == true)
            {

            }

            else
            {

            }
        }

        private void AppointmentCalendarMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentCalendarWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AppointmentCalendarCloseButton_Click(object sender, EventArgs e)
        {
            Close();
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

                    if (tempID == appt[0])
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

        private static DataTable GenerateSpecificTable(DateTime startDate, DateTime endDate)
        {
            List<List<string>> originalList = appointmentList;

            // Create a data table in which to store the selected info
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Consultant");
            dt.Columns.Add("Customer");
            dt.Columns.Add("Appointment Start");
            dt.Columns.Add("Appointment End");

            // If the date of the appointment falls between the dates provided, add the appointment into to the data table
            foreach (List<string> appt in originalList)
            {
                DateTime start = Convert.ToDateTime(appt[2]);
                DateTime end = Convert.ToDateTime(appt[3]);

                if (startDate <= start && endDate >= end)
                {
                    DataRow row = dt.NewRow();

                    row[0] = appt[0];
                    row[1] = appt[1];
                    row[2] = appt[2];
                    row[3] = appt[3];

                    dt.Rows.Add(row);
                }

                else
                {
                    continue;
                }

                /*var filtered =
                    from value in appt
                    where value > "2020-11-02 12:00:00 AM" && value < "2020-11-06 11:59:59 PM"
                    select value;*/
            }

            return dt;
        }

        private void SpecifyMonth()
        {
            AppointmentCalendarMonthCalendar.RemoveAllBoldedDates();


        }

        private void SpecifyWeek()
        {
            AppointmentCalendarMonthCalendar.RemoveAllBoldedDates();


        }

        // FIXME: SELECT * FROM appointment WHERE start BETWEEN '2020-11-02 00:00:00' AND '2020-11-06 23:59:59' ORDER BY start ASC
    }
}
