namespace C969PA_CodyBurkholz_001248460
{
    partial class AddAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddAppointmentFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddAppointmentFormLabel
            // 
            this.AddAppointmentFormLabel.AutoSize = true;
            this.AddAppointmentFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentFormLabel.Location = new System.Drawing.Point(13, 13);
            this.AddAppointmentFormLabel.Name = "AddAppointmentFormLabel";
            this.AddAppointmentFormLabel.Size = new System.Drawing.Size(133, 20);
            this.AddAppointmentFormLabel.TabIndex = 0;
            this.AddAppointmentFormLabel.Text = "Add Appointment";
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAppointmentFormLabel);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddAppointmentFormLabel;
    }
}