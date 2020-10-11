using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }

    public class Globals
    {
        public static string cxnString = ConfigurationManager.ConnectionStrings["MySqlClientKey"].ConnectionString;

        public static int userIDCounter;
        public static int appointmentIDCounter;
        public static int customerIDcounter;
        public static int addressIDCounter;
        
        public static int CreateID()
        {
            // Maintain counters for each table, you have the table name from the InsertRecord table, can use it in a switch statement?
            string table = "none";

            switch(table)
            {
                case "user":
                    userIDCounter++;
                    break;

                case "appointment":
                    appointmentIDCounter++;
                    break;

                case "customer":
                    customerIDcounter++;
                    break;

                case "address":
                    addressIDCounter++;
                    break;

                default:
                    MessageBox.Show("Please provide a valid table name."); // FIXME: Is this good, or should I throw an exception?
                    break;
            }
            return 0; // FIXME: Change this to the ID created
        }

        public static int InsertRecord(string table)
        {
            int id = 0; // FIXME: Change this to the ID created in CreateID
            string insRecord;

            insRecord = $"INSERT INTO {table} VALUES ({id})";

            MySqlConnection cxn = new MySqlConnection(cxnString);
            cxn.Open();
            MySqlCommand cmd = new MySqlCommand(insRecord, cxn);
            cmd.ExecuteNonQuery(); // FIXME: I don't think this is the right method
            cxn.Close();

            return id;
        }
    }
}
