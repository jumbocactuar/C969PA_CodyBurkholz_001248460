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
    public partial class AppointmentTypesReportForm : Form
    {
        public AppointmentTypesReportForm()
        {
            InitializeComponent();
        }

        private void AppointmentTypesReportForm_Load(object sender, EventArgs e)
        {
            AppointmentTypesDataGridView.DataSource = GenerateApptTypesReport();
        }

        private void AppointmentTypesCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private delegate bool ApptType(string type);

        // Lambda used to determine if the selected appointment type is a Consultation
        private static bool Consult(string type) => type == "Consultation (15 min)";

        // Lambda used to determine if the selected appointment type is a Short Appointment
        private static bool Short(string type) => type == "Short Appointment (30 min)";

        // Lambda used to determine if the selected appointment type is a Long Appointment
        private static bool Long(string type) => type == "Long Appointment (60 min)";

        private static List<Object[]> FilterList(List<Object[]> inputList, ApptType type)
        {
            List<Object[]> outputList = new List<object[]>();

            foreach (Object[] appt in inputList)
            {
                if (appt[7] != null)
                {
                    string inputType = appt[7].ToString();

                    if (type(inputType))
                    {
                        outputList.Add(appt);
                    }
                }
                
                else
                {
                    continue;
                }
            }

            return outputList;
        }

        private static DataTable GenerateApptTypesReport()
        {
            // Create a data table in which to store the selected info
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Month");
            dt.Columns.Add("Consultation");
            dt.Columns.Add("Short Appointment");
            dt.Columns.Add("Long Appointment");
            dt.Rows.Add("January");
            dt.Rows.Add("February");
            dt.Rows.Add("March");
            dt.Rows.Add("April");
            dt.Rows.Add("May");
            dt.Rows.Add("June");
            dt.Rows.Add("July");
            dt.Rows.Add("August");
            dt.Rows.Add("September");
            dt.Rows.Add("October");
            dt.Rows.Add("November");
            dt.Rows.Add("December");

            // Generate a list of all appointments
            List<Object[]> appointmentList = Globals.GenerateTableList("appointment");

            // Generate a list of all Consultation appointments
            List<Object[]> consultList = FilterList(appointmentList, Consult);

            //Generate a list of all Short appointments
            List<Object[]> shortList = FilterList(appointmentList, Short);

            //Generate a list of all Long appointments
            List<Object[]> longList = FilterList(appointmentList, Long);

            // Create lists to hold each appointment type count
            List<int> consultCount = Enumerable.Repeat(0, 12).ToList();
            List<int> shortCount = Enumerable.Repeat(0, 12).ToList();
            List<int> longCount = Enumerable.Repeat(0, 12).ToList();

            // Count the number of each appointment type by month
            foreach (Object[] appt in consultList)
            {
                string month = appt[9].ToString().Substring(0, 2);

                switch (month)
                {
                    case "01":
                        consultCount[0]++;
                        break;
                    case "02":
                        consultCount[1]++;
                        break;
                    case "03":
                        consultCount[2]++;
                        break;
                    case "04":
                        consultCount[3]++;
                        break;
                    case "05":
                        consultCount[4]++;
                        break;
                    case "06":
                        consultCount[5]++;
                        break;
                    case "07":
                        consultCount[6]++;
                        break;
                    case "08":
                        consultCount[7]++;
                        break;
                    case "09":
                        consultCount[8]++;
                        break;
                    case "10":
                        consultCount[9]++;
                        break;
                    case "11":
                        consultCount[10]++;
                        break;
                    case "12":
                        consultCount[11]++;
                        break;
                    default:
                        break;
                }
            }

            foreach (Object[] appt in shortList)
            {
                string month = appt[9].ToString().Substring(0, 2);

                switch (month)
                {
                    case "01":
                        shortCount[0]++;
                        break;
                    case "02":
                        shortCount[1]++;
                        break;
                    case "03":
                        shortCount[2]++;
                        break;
                    case "04":
                        shortCount[3]++;
                        break;
                    case "05":
                        shortCount[4]++;
                        break;
                    case "06":
                        shortCount[5]++;
                        break;
                    case "07":
                        shortCount[6]++;
                        break;
                    case "08":
                        shortCount[7]++;
                        break;
                    case "09":
                        shortCount[8]++;
                        break;
                    case "10":
                        shortCount[9]++;
                        break;
                    case "11":
                        shortCount[10]++;
                        break;
                    case "12":
                        shortCount[11]++;
                        break;
                    default:
                        break;
                }
            }

            foreach (Object[] appt in longList)
            {
                string month = appt[9].ToString().Substring(0, 2);

                switch (month)
                {
                    case "01":
                        longCount[0]++;
                        break;
                    case "02":
                        longCount[1]++;
                        break;
                    case "03":
                        longCount[2]++;
                        break;
                    case "04":
                        longCount[3]++;
                        break;
                    case "05":
                        longCount[4]++;
                        break;
                    case "06":
                        longCount[5]++;
                        break;
                    case "07":
                        longCount[6]++;
                        break;
                    case "08":
                        longCount[7]++;
                        break;
                    case "09":
                        longCount[8]++;
                        break;
                    case "10":
                        longCount[9]++;
                        break;
                    case "11":
                        longCount[10]++;
                        break;
                    case "12":
                        longCount[11]++;
                        break;
                    default:
                        break;
                }
            }

            // Put the count values in the data table
            for (int i = 0; i < consultCount.Count; i++)
            {
                dt.Rows[i][1] = consultCount[i];
            }

            for (int i = 0; i < shortCount.Count; i++)
            {
                dt.Rows[i][2] = shortCount[i];
            }

            for (int i = 0; i < longCount.Count; i++)
            {
                dt.Rows[i][3] = longCount[i];
            }

            return dt;
        }
    }
}
