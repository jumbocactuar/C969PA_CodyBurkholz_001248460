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
    /* FIXME NOTES
     * A. Create a log-in form that can determine the user’s location and translate log-in and error control messages 
     * (e.g., “The username and password did not match.”) into the user’s language and in one additional language.
     * D. Provide the ability to view the calendar by month and by week. - Jan 24 webinar
     * E. Provide the ability to automatically adjust appointment times based on user time zones and daylight saving time.
     * Exception preventing appointment outside business hours is based on the local time where the app was started (the local time of the user who logged in).
     */

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

    public class Globals
    {
        public static string cxnString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

        public static string[] BusinessHours = { "09", "10", "11", "12", "13", "14", "15", "16" };

        public static string CurrentUser { get; set; }

        public static string CurrentDataGridSelection { get; set; }

        private static string GetMySqlNow()
        {
            DateTime utcTime = new DateTime();
            utcTime = DateTime.UtcNow;
            string mySqlNow = utcTime.ToString("yyyy-MM-dd HH:mm:ss");

            return mySqlNow;
        }

        private static int ExecuteThisQueryReturnInt(string query)
        {
            int result = 0;

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);

            try
            {
                result = cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("This record cannot be deleted, as one or more records depend on it.");
            }

            cxn.Close();

            return result;
        }

        private static string ExecuteThisQueryReturnString(string query)
        {
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

        public static void DeleteRecord(string table, int id)
        {
            string query = $"DELETE FROM {table} WHERE {table}Id = {id}";

            ExecuteThisQueryReturnInt(query);
        }

        public static Object[] GetSelectedRowContents(string table, int id)
        {
            string query = $"SELECT * FROM {table} WHERE {table}Id = {id}";

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(query, cxn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();

            Object[] objList = new Object[reader.FieldCount];
            int fieldCount = reader.GetValues(objList);

            reader.Close();
            cxn.Close();

            return objList;
        }

        public static bool CheckAppointmentTime(string apptHour)
        {
            bool invalidHour = true;
            int i = 0;

            // Check whether the appointment time submitted is within business hours
            do
            {
                foreach (string hour in Globals.BusinessHours)
                {
                    if (hour == apptHour)
                    {
                        invalidHour = false;

                        return invalidHour;
                    }

                    else
                    {
                        ++i;
                    }
                }
            } while (i < 8);

            return invalidHour;
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

            if (city == "London")
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

        public static int InsertAppointmentRecord(int customerID, int userID, string title, string description, string location, string contact, string type, string url, string start, string end)
        {
            int id = CreateID("appointment");

            string query = $"INSERT INTO appointment VALUES ({id}, {customerID}, {userID}, '{title}', '{description}', '{location}', '{contact}', '{type}', '{url}', '{start}', '{end}', '{GetMySqlNow()}', '{CurrentUser}', '{GetMySqlNow()}', '{CurrentUser}')";

            ExecuteThisQueryReturnInt(query);

            return id;
        }

        public static int UpdateCountryRecord() // FIXME: Make this functional
        {
            int id = 0;

            return id;
        }

        public static int UpdateCityRecord() // FIXME: Make this functional
        {
            int id = 0;

            return id;
        }

        public static void UpdateAddressRecord(int addressID, string address, string address2, string city, string postalCode, string phone)
        {
            int cityID = GetID("city", city);

            string query = $"UPDATE address SET " +
                $"address = '{address}', " +
                $"address2 = '{address2}', " +
                $"cityId = '{cityID}', " +
                $"postalCode = '{postalCode}', " +
                $"phone = '{phone}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE addressId = '{addressID}'";

            ExecuteThisQueryReturnInt(query);
        }

        public static void UpdateCustomerRecord(int customerID, string name, byte active, int addressID)
        {
            string query = $"UPDATE customer SET " +
                $"customerName = '{name}', " +
                $"addressId = '{addressID}', " +
                $"active = '{active}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE customerId = '{customerID}'";

            ExecuteThisQueryReturnInt(query);
        }

        public static void UpdateUserRecord(int userID, string userName, string password, byte active)
        {
            string query = $"UPDATE user SET " +
                $"userName = '{userName}', " +
                $"password = '{password}', " +
                $"active = '{active}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE userId = '{userID}'";

            ExecuteThisQueryReturnInt(query);
        }

        public static void UpdateAppointmentRecord(int appointmentID, int customerID, int userID, string title, string description, string location, string contact, string type, string url, string start, string end)
        {
            string query = $"UPDATE appointment SET " +
                $"customerId = '{customerID}', " +
                $"userId = '{userID}', " +
                $"title = '{title}', " +
                $"description = '{description}', " +
                $"location = '{location}', " +
                $"contact = '{contact}', " +
                $"type = '{type}', " +
                $"url = '{url}', " +
                $"start = '{start}', " +
                $"end = '{end}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE appointmentId = '{appointmentID}'";

            ExecuteThisQueryReturnInt(query);
        }
    }

    public class InvalidAppointmentTimeException : Exception
    {
        public InvalidAppointmentTimeException()
            : base("The specified appointment times overlap or are outside business hours.")
        {

        }

        public InvalidAppointmentTimeException(string messageValue)
            : base(messageValue)
        {

        }

        public InvalidAppointmentTimeException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }

    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException()
            : base("Invalid user name or password")
        {

        }

        public InvalidCredentialsException(string messageValue)
            : base(messageValue)
        {

        }

        public InvalidCredentialsException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }

    public class InvalidCustomerDataException : Exception
    {
        public InvalidCustomerDataException()
            : base("The data entered is invalid.")
        {

        }

        public InvalidCustomerDataException(string messageValue)
            : base(messageValue)
        {

        }

        public InvalidCustomerDataException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
