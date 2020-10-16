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
using MySql.Data.Types;

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
            Application.Run(new LoginForm());
        }
    }

    /* FIXME: This is their fancy way of saying you have to have to have the ability to add a customer when making an appointment and also 
     * be able to change customer in an update. For display customer id is ok, customer name might be helpful. ( humans don't usually remember all ids)*/

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

        private static string GetMySqlNow()
        {
            DateTime utcTime = new DateTime();
            utcTime = DateTime.UtcNow;
            string mySqlNow = utcTime.ToString("yyyy-MM-dd HH:mm:ss");

            return mySqlNow;
        }

        private static void ExecuteThisQuery(string query)
        {
            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            cmd.ExecuteNonQuery();
            cxn.Close();
        }

        private static string ExecuteThisQueryAndReturn(string query)
        {
            string result;
            
            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            result = cmd.ExecuteScalar().ToString();
            cxn.Close();

            return result;
        }


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

        private static int GetID(string table, string condition)
        {
            // Given a target table and a condition for the WHERE clause, return the result record's ID
            string query = $"SELECT {table}Id from {table} WHERE {table} = '{condition}'";

            string result = ExecuteThisQueryAndReturn(query);

            return int.Parse(result);
        }

        /*public static int InsertRecord(string table) // Seeing as each table has a unique set of fields, can I overload this method and make one for each table?
        {
            int id = CreateID(table);
            string insRecord;

            insRecord = $"INSERT INTO {table} VALUES ({id})";

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(insRecord, cxn);
            cmd.ExecuteNonQuery();
            cxn.Close();

            return id; // FIXME: Why am I returning anything?
        }*/

        public static int InsertCountryRecord(string country) // FIXME: These might have to be table-specific methods since country and city hasve the same sig
        {
            int id = CreateID("country");

            string query = $"INSERT INTO country VALUES ({id}, '{country}', '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQuery(query);

            return id; // FIXME: Do I need to be returning anything?
        }

        public static void InsertCityRecord(string city)
        {
            int id = CreateID("city");

            string country;

            if (city == "London") // FIXME: May need to revisit this after seeing how to deal with values in a dropdown list
            {
                country = "United Kingdom";
            }

            else
            {
                country = "United States";
            }

            int countryID = GetID("country", country);

            string query = $"INSERT INTO city VALUES ({id}, '{city}', {countryID}, '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQuery(query);
        }
    }
}
