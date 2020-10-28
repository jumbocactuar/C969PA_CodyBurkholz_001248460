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
    public partial class ManageAppointmentsForm : Form
    {
        /*C. Provide the ability to add, update, and delete appointments, capturing the type of appointment and a link to the specific customer record in the database.
        D. Provide the ability to view the calendar by month and by week. - Jan 24 webinar
        E. Provide the ability to automatically adjust appointment times based on user time zones and daylight saving time.*/

        /* FIXME: This is their fancy way of saying you have to have to have the ability to add a customer when making an appointment and also 
        be able to change customer in an update. For display customer id is ok, customer name might be helpful. ( humans don't usually remember all ids)*/

        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.u06vbiDataSet.appointment);
        }

        private void ManageAppointmentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageAppointmentsDataGridView.ClearSelection();
            ManageAppointmentsDataGridView.ReadOnly = true;
        }

        private void ManageAppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageAppointmentsDataGridView.CurrentCell.RowIndex;

            Globals.CurrentDataGridSelection = ManageAppointmentsDataGridView.Rows[selection].Cells[0].Value.ToString();

            Object[] selectionContents = Globals.GetSelectedRowContents("appointment", int.Parse(Globals.CurrentDataGridSelection));
        }

        private void ManageAppointmentsAddButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm f = new AddAppointmentForm();
            f.Show();

            Close();
        }

        private void ManageAppointmentsModifyButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                ModifyAppointmentForm f = new ModifyAppointmentForm();
                f.Show();
            }

            else
            {
                MessageBox.Show("Please select an appointment to modify.");
            }
        }

        private void ManageAppointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                string message = "Delete the selected appointment?";
                string caption = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.OK)
                {
                    Globals.DeleteRecord("appointment", int.Parse(Globals.CurrentDataGridSelection));

                    Globals.CurrentDataGridSelection = null;

                    this.appointmentTableAdapter.Fill(this.u06vbiDataSet.appointment);
                }
            }

            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        private void ManageAppointmentsCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
