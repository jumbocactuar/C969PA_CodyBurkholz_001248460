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
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.u06vbiDataSet.appointment);

            Globals.CurrentDataGridSelection = null;
        }

        private void ManageAppointmentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ManageAppointmentsDataGridView.ClearSelection();
            ManageAppointmentsDataGridView.ReadOnly = true;
        }

        private void ManageAppointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selection = ManageAppointmentsDataGridView.CurrentCell.RowIndex;

            Globals.CurrentDataGridSelection = ManageAppointmentsDataGridView.Rows[selection].Cells[0].Value.ToString();
        }

        private void ManageAppointmentsAddButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm f = new AddAppointmentForm(this);
            f.Show();
        }

        private void ManageAppointmentsModifyButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentDataGridSelection != null)
            {
                ModifyAppointmentForm f = new ModifyAppointmentForm(this);
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

        private void ManageAppointmentsViewCalendarButton_Click(object sender, EventArgs e)
        {
            AppointmentCalendarForm f = new AppointmentCalendarForm();
            f.Show();
        }

        private void ManageAppointmentsCancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentDataGridSelection = null;

            Close();
        }

        public void DataGridViewRefresh()
        {
            this.appointmentTableAdapter.Fill(this.u06vbiDataSet.appointment);

            ManageAppointmentsDataGridView.ClearSelection();
        }
    }
}
