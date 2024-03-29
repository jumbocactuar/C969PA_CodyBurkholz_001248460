﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

    public class Globals
    {
        public static string cxnString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

        public static string[] BusinessHours = { "09", "10", "11", "12", "13", "14", "15", "16" };

        public static string CurrentDataGridSelection { get; set; }

        public static string CurrentUser { get; set; }

        public static bool CheckAppointmentTime(string apptHour)
        {
            bool invalidHour = true;
            int i = 0;

            // Check whether the appointment time submitted is within business hours (local time)
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

        public static bool ConflictCheck(int userID, int customerID, string start, string end)
        {
            bool conflict = false;
            List<Object[]> appointmentRows = Globals.GenerateTableList("appointment");
            DateTime proposedStart = DateTime.Parse(start);
            DateTime proposedEnd = DateTime.Parse(end);

            foreach (Object[] appointment in appointmentRows)
            {
                int existingUser = Convert.ToInt32(appointment[2]);
                int existingCustomer = Convert.ToInt32(appointment[1]);

                // Find existing appointments associated with the consultant selected in the proposed appointment
                if (existingUser == userID)
                {
                    DateTime existingStart = DateTime.Parse(appointment[9].ToString());
                    DateTime existingEnd = DateTime.Parse(appointment[10].ToString());

                    if ((existingStart >= proposedStart) && (existingEnd <= proposedEnd)) // between existing times
                    {
                        return conflict = true;
                    }

                    if ((existingStart <= proposedStart) && (existingEnd >= proposedEnd)) // between existing times
                    {
                        return conflict = true;
                    }

                    if (((existingStart > proposedStart) && (existingStart < proposedEnd)) || ((existingEnd > proposedStart) && (existingEnd < proposedEnd))) // overlapping beginning or end
                    {
                        return conflict = true;
                    }
                }

                // Find existing appointment associated with the customer selected in the proposed appointment
                if (existingCustomer == customerID)
                {
                    DateTime existingStart = DateTime.Parse(appointment[9].ToString());
                    DateTime existingEnd = DateTime.Parse(appointment[10].ToString());

                    if ((existingStart >= proposedStart) && (existingEnd <= proposedEnd)) // between existing times
                    {
                        return conflict = true;
                    }

                    if ((existingStart <= proposedStart) && (existingEnd >= proposedEnd)) // between existing times
                    {
                        return conflict = true;
                    }

                    if (((existingStart > proposedStart) && (existingStart < proposedEnd)) || ((existingEnd > proposedStart) && (existingEnd < proposedEnd))) // overlapping beginning or end
                    {
                        return conflict = true;
                    }
                }
            }

            return conflict;
        }

        // Overloaded ConflictCheck for Modify Appointment
        public static bool ConflictCheck(int appointmentID, int userID, int customerID, string start, string end)
        {
            bool conflict = false;
            List<Object[]> appointmentRows = Globals.GenerateTableList("appointment");
            DateTime proposedStart = DateTime.Parse(start);
            DateTime proposedEnd = DateTime.Parse(end);

            foreach (Object[] appointment in appointmentRows)
            {
                int existingUser = Convert.ToInt32(appointment[2]);
                int existingCustomer = Convert.ToInt32(appointment[1]);
                int existingAppt = Convert.ToInt32(appointment[0]);

                // Proceed only if the appointment being examined below is not the appointment being modified in Modify Appointment
                if (existingAppt != appointmentID)
                {
                    // Find existing appointments associated with the consultant selected in the proposed appointment
                    if (existingUser == userID)
                    {
                        DateTime existingStart = DateTime.Parse(appointment[9].ToString());
                        DateTime existingEnd = DateTime.Parse(appointment[10].ToString());

                        if ((existingStart >= proposedStart) && (existingEnd <= proposedEnd)) // between existing times
                        {
                            return conflict = true;
                        }

                        if ((existingStart <= proposedStart) && (existingEnd >= proposedEnd)) // between existing times
                        {
                            return conflict = true;
                        }

                        if (((existingStart > proposedStart) && (existingStart < proposedEnd)) || ((existingEnd > proposedStart) && (existingEnd < proposedEnd))) // overlapping beginning or end
                        {
                            return conflict = true;
                        }
                    }

                    // Find existing appointment associated with the customer selected in the proposed appointment
                    if (existingCustomer == customerID)
                    {
                        DateTime existingStart = DateTime.Parse(appointment[9].ToString());
                        DateTime existingEnd = DateTime.Parse(appointment[10].ToString());

                        if ((existingStart >= proposedStart) && (existingEnd <= proposedEnd)) // between existing times
                        {
                            return conflict = true;
                        }

                        if ((existingStart <= proposedStart) && (existingEnd >= proposedEnd)) // between existing times
                        {
                            return conflict = true;
                        }

                        if (((existingStart > proposedStart) && (existingStart < proposedEnd)) || ((existingEnd > proposedStart) && (existingEnd < proposedEnd))) // overlapping beginning or end
                        {
                            return conflict = true;
                        }
                    }
                }
            }

            return conflict;
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

        public static void DeleteRecord(string table, int id)
        {
            string query = $"DELETE FROM {table} WHERE {table}Id = {id}";

            ExecuteThisQueryReturnInt(query);
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

            catch (MySqlException)
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

        public static List<Object[]> GenerateTableList(string table)
        {
            // Generate a list of arrays of objects containing the data of the specified table
            Object[] GetTableRow(int id)
            {
                string subQuery = $"SELECT * FROM {table} WHERE {table}Id = {id}";

                MySqlConnection cxn = new MySqlConnection(cxnString);
                cxn.Open();
                MySqlCommand cmd = new MySqlCommand(subQuery, cxn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();

                Object[] objList = new Object[reader.FieldCount];

                if (reader.HasRows == false)
                {
                    objList[0] = id;

                    reader.Close();
                    cxn.Close();

                    return objList;
                }

                else
                {
                    int fieldCount = reader.GetValues(objList);
                }

                reader.Close();
                cxn.Close();

                return objList;
            }

            string query = $"SELECT * FROM {table} ORDER BY {table}Id DESC";
            int rowCount = Convert.ToInt32(ExecuteThisQueryReturnString(query));
            List<Object[]> rowList = new List<object[]>(rowCount);
            int i;

            for (i = 0; i < rowCount; ++i)
            {
                rowList.Add(GetTableRow((i + 1)));
            }

            return rowList;
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

        public static string GetMySqlNow()
        {
            // Get the current time in a format acceptable by MySQL
            DateTime utcTime = new DateTime();
            utcTime = DateTime.UtcNow;
            string mySqlNow = utcTime.ToString("yyyy-MM-dd HH:mm:ss");

            return mySqlNow;
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

        public static bool InvalidPhoneCheck(string input)
        {
            bool invalid = false;
            List<char> allowed = new List<char> { '(', ')', '-', '+', ' ' };

            // If the string does not contain only numbers or allowed chatacters, mark it as invalid
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    if (allowed.Contains(c) == false)
                    {
                        return invalid = true;
                    }
                }
            }

            return invalid;
        }

        public static bool InvalidPostalCodeCheck(string postalCode, string city)
        {
            bool invalid = false;

            // If the string does not contain only numbers (for New York and Phoenix), mark it as invalid
            if (city == "New York" || city == "Phoenix")
            {
                foreach (char c in postalCode)
                {
                    if (c < '0' || c > '9')
                    {
                        return invalid = true;
                    }
                }
            }

            return invalid;
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

        public static void UpdateCountryRecord(int countryID, string country)
        {
            string query = $"UPDATE country SET " +
                $"country = '{country}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE addressId = '{countryID}'";

            ExecuteThisQueryReturnInt(query);
        }

        public static void UpdateCityRecord(int cityID, string city, string country)
        {
            int countryID = GetID("country", country);

            string query = $"UPDATE city SET " +
                $"city = '{city}', " +
                $"countryId = '{countryID}', " +
                $"lastUpdate = '{GetMySqlNow()}', " +
                $"lastUpdateBy = '{CurrentUser}' " +
                $"WHERE addressId = '{cityID}'";

            ExecuteThisQueryReturnInt(query);
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

    class Logger
    {
        public static void LoginLog(string userName)
        {
            string path = "loginlog.txt";

            string log = $"\r\n{userName} - {Globals.GetMySqlNow()} UTC";

            File.AppendAllText(path, log);
        }
    }
}
