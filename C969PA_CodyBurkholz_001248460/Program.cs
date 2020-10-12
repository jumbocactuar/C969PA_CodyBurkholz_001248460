using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters;
using MySql.Data.MySqlClient;

namespace C969PA_CodyBurkholz_001248460
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManageCustomerForm());

            //Populate the Country table
            Globals.InsertRecord("country", "United States");
            Globals.InsertRecord("country", "United Kingdom");
        }
    }

    public class Globals
    {
        public static string cxnString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

        public static string CurrentUser { get; set; }
        public static int UserIDCounter { get; set; }
        public static int AppointmentIDCounter { get; set; }
        public static int CustomerIDcounter { get; set; }
        public static int AddressIDCounter { get; set; }
        public static int CityIDCounter { get; set; }
        public static int CountryIDCounter { get; set; }

        public static int CreateID(string table)
        {
            int counter = -1;

            switch(table)
            {
                case "user":
                    UserIDCounter++;
                    counter = UserIDCounter;
                    break;

                case "appointment":
                    AppointmentIDCounter++;
                    counter = AppointmentIDCounter;
                    break;

                case "customer":
                    CustomerIDcounter++;
                    counter = CustomerIDcounter;
                    break;

                case "address":
                    AddressIDCounter++;
                    counter = AddressIDCounter;
                    break;

                case "city":
                    CityIDCounter++;
                    counter = CityIDCounter;
                    break;

                case "country":
                    CountryIDCounter++;
                    counter = CountryIDCounter;
                    break;

                default:
                    MessageBox.Show("Please provide a valid table name."); // FIXME: Is this good, or should I throw an exception?
                    break;
            }
            return counter;
        }

        public static int InsertRecord(string table) // Seeing as each table has a unique set if fields, can I overload this method and make one for each table?
        {
            int id = CreateID(table);
            string insRecord;

            insRecord = $"INSERT INTO {table} VALUES ({id})";

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(insRecord, cxn);
            cmd.ExecuteNonQuery(); // FIXME: Is this the right method?
            cxn.Close();

            return id; // FIXME: Why am I returning anything?
        }

        public static int InsertRecord(string table, string country)
        {
            // Country table record insertion method
            int id = CreateID(table);
            DateTime timestamp = DateTime.UtcNow;
            
            string insRecord;

            insRecord = $"INSERT INTO {table} VALUES ({id}, '{country}', '{timestamp}', '{Globals.CurrentUser}', '{timestamp}', '{Globals.CurrentUser}')"; // FIXME: "Incorrect datetime value"?

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(insRecord, cxn);
            cmd.ExecuteNonQuery();
            cxn.Close();

            return id;
        }
    }
}
