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

        private static string GetMySqlNow()
        {
            DateTime utcTime = new DateTime();
            utcTime = DateTime.UtcNow;
            string mySqlNow = utcTime.ToString("yyyy-MM-dd HH:mm:ss");

            return mySqlNow;
        }

        private static int ExecuteThisQueryReturnInt(string query)
        {
            int result;

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            result = cmd.ExecuteNonQuery();
            cxn.Close();

            return result;
        }

        private static string ExecuteThisQueryReturnString(string query)
        {
            /*string result;
            
            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            result = cmd.ExecuteScalar().ToString();
            cxn.Close();

            return result;*/

            string resultString;

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            var result = cmd.ExecuteScalar();

            if (result == null)
            {
                resultString = "null";
            }

            else
            {
                resultString = result.ToString();
            }

            cxn.Close();

            return resultString;
        }


        private static int CreateID(string table)
        {
            string existentialQuery = $"SELECT * FROM {table}";

            int id = ExecuteThisQueryReturnInt(existentialQuery);

            if (id == 0)
            {
                id = 1;
            }

            else
            {
                id++;
            }

            return id;
        }

        private static int GetID(string table, string condition)
        {
            // Given a target table and a condition for the WHERE clause, return the result record's ID
            string query = $"SELECT {table}Id from {table} WHERE {table} = '{condition}'";

            string result = ExecuteThisQueryReturnString(query);

            return int.Parse(result);
        }

        public static string GetLoginInfo(string infoType, string info)
        {
            string query = $"SELECT {infoType} FROM user WHERE {infoType} = '{info}'";

            string result = ExecuteThisQueryReturnString(query);

            return result;
        }

        public static void InsertCountryRecord(string country)
        {
            int id = CreateID("country");

            string query = $"INSERT INTO country VALUES ({id}, '{country}', '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQueryReturnInt(query);
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

            ExecuteThisQueryReturnInt(query);
        }

        public static int InsertAddressRecord(string address, string address2, string city, string postalCode, string phone)
        {
            int id = CreateID("address");

            int cityID = GetID("city", city);

            string query = $"INSERT INTO address VALUES ({id}, '{address}', '{address2}', {cityID}, '{postalCode}', '{phone}', '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQueryReturnInt(query);
            
            return id;
        }

        public static int InsertCustomerRecord(string name, int addressID, byte active)
        {
            int id = CreateID("customer");

            string query = $"INSERT INTO customer VALUES ({id}, '{name}', {addressID}, {active}, '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQueryReturnInt(query);
            
            return id;
        }

        public static int InsertUserRecord(string userName, string password, byte active)
        {
            int id = CreateID("user");

            string query = $"INSERT INTO user VALUES ({id}, '{userName}', '{password}', {active}, '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQueryReturnInt(query);

            return id;
        }

        public static int InsertAppointmentRecord(int customerID, int userID, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end)
        {
            // FIXME: Unsure whether string is right for location (what do I get from a dropdown selection), or if DateTime is right for start/end, may need to grab and convert?
            int id = CreateID("appointment");

            string query = $"INSERT INTO appointment VALUES ({id})";

            ExecuteThisQueryReturnInt(query);

            return id;
        }
    }
}
