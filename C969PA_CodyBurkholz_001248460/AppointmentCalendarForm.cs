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
            DateTime selectedDay = AppointmentCalendarMonthCalendar.SelectionRange.Start;
        }

        private void AppointmentCalendarMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AppointmentCalendarDataGridView.DataSource = GenerateSpecificTable(SpecifyRange());
        }

        private void AppointmentCalendarWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AppointmentCalendarDataGridView.DataSource = GenerateSpecificTable(SpecifyRange());
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

            // Sort the presentable list by start date
            // Lambda used to define comparison terms for sorting
            presentableList.Sort((x, y) => string.Compare(x[2], y[2]));

            return presentableList;
        }

        private static DataTable GenerateSpecificTable(List<DateTime> dates)
        {
            List<List<string>> originalList = appointmentList;

            DateTime startDate = dates[0];
            DateTime endDate = dates[1];

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
            }

            return dt;
        }

        private List<DateTime> SpecifyRange()
        {
            // Create a list into which the selected date range can be placed
            List<DateTime> selectedRange = new List<DateTime>();

            DateTime selectedDate = AppointmentCalendarMonthCalendar.SelectionRange.Start;

            // Break down the selected date
            int selectedYear = Convert.ToInt32(selectedDate.Year);
            int selectedMonth = Convert.ToInt32(selectedDate.Month);
            int selectedDay = Convert.ToInt32(selectedDate.Day);
            string selectedDayOfWeek = selectedDate.DayOfWeek.ToString();
            int numDays = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // Depending on whether Month or Week is selected, define the start and end dates of the requested range
            if (AppointmentCalendarMonthRadioButton.Checked == true)
            {
                string rangeStart = $"{selectedMonth}/1/{selectedYear} 12:00:00 AM";
                string rangeEnd = $"{selectedMonth}/{numDays}/{selectedYear} 11:59:59 PM";

                selectedRange.Add(Convert.ToDateTime(rangeStart));
                selectedRange.Add(Convert.ToDateTime(rangeEnd));
            }

            if (AppointmentCalendarWeekRadioButton.Checked == true)
            {
                string tempDayOfWeek = selectedDayOfWeek.ToString();
                int dowOffset = 0;

                // Determine the number of days between the selected day and the beginning of the week
                switch (tempDayOfWeek)
                {
                    case "Monday":
                        dowOffset = 1;
                        break;
                    case "Tuesday":
                        dowOffset = 2;
                        break;
                    case "Wednesday":
                        dowOffset = 3;
                        break;
                    case "Thursday":
                        dowOffset = 4;
                        break;
                    case "Friday":
                        dowOffset = 5;
                        break;
                    case "Saturday":
                        dowOffset = 6;
                        break;
                    default:
                        break;
                }

                int rangeStartDay = Convert.ToInt32(selectedDay);
                rangeStartDay -= dowOffset;
                int rangeEndDay = rangeStartDay + 7;
                int rangeStartMonth = selectedMonth;
                int rangeEndMonth = selectedMonth;
                int rangeStartYear = selectedYear;
                int rangeEndYear = selectedYear;

                // If the selected week straddles two months, adjust the selected start/end day/month/year
                if (rangeStartDay < 1)
                {
                    int tempNum = 0;

                    rangeStartMonth--;

                    if (rangeStartMonth == 0)
                    {
                        rangeStartMonth = 12;
                        rangeStartYear--;
                        tempNum = DateTime.DaysInMonth(rangeStartYear, rangeStartMonth);
                        rangeStartDay += tempNum; 
                    }

                    else
                    {
                        tempNum = DateTime.DaysInMonth(rangeStartYear, rangeStartMonth);
                        rangeStartDay += tempNum;
                    }
                }
                
                if (rangeEndDay > numDays)
                {
                    rangeEndDay -= numDays;
                    rangeEndMonth++;

                    if (rangeEndMonth == 13)
                    {
                        rangeEndMonth = 1;
                        rangeEndYear++;
                    }
                }

                string rangeStart = $"{rangeStartMonth}/{rangeStartDay}/{rangeStartYear} 12:00:00 AM";
                string rangeEnd = $"{rangeEndMonth}/{rangeEndDay}/{rangeEndYear} 11:59:59 PM";

                selectedRange.Add(Convert.ToDateTime(rangeStart));
                selectedRange.Add(Convert.ToDateTime(rangeEnd));
            }

            return selectedRange;
        }
    }
}
