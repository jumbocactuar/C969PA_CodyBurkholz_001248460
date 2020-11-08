namespace C969PA_CodyBurkholz_001248460
{
    partial class AppointmentTypesReportForm
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
            this.AppointmentTypesReportFormLabel = new System.Windows.Forms.Label();
            this.AppointmentTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentTypesCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentTypesReportFormLabel
            // 
            this.AppointmentTypesReportFormLabel.AutoSize = true;
            this.AppointmentTypesReportFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTypesReportFormLabel.Location = new System.Drawing.Point(13, 13);
            this.AppointmentTypesReportFormLabel.Name = "AppointmentTypesReportFormLabel";
            this.AppointmentTypesReportFormLabel.Size = new System.Drawing.Size(215, 20);
            this.AppointmentTypesReportFormLabel.TabIndex = 0;
            this.AppointmentTypesReportFormLabel.Text = "Appointment Types by Month";
            // 
            // AppointmentTypesDataGridView
            // 
            this.AppointmentTypesDataGridView.AllowUserToAddRows = false;
            this.AppointmentTypesDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentTypesDataGridView.Location = new System.Drawing.Point(17, 49);
            this.AppointmentTypesDataGridView.Name = "AppointmentTypesDataGridView";
            this.AppointmentTypesDataGridView.ReadOnly = true;
            this.AppointmentTypesDataGridView.RowHeadersVisible = false;
            this.AppointmentTypesDataGridView.Size = new System.Drawing.Size(404, 303);
            this.AppointmentTypesDataGridView.TabIndex = 1;
            // 
            // AppointmentTypesCloseButton
            // 
            this.AppointmentTypesCloseButton.Location = new System.Drawing.Point(346, 403);
            this.AppointmentTypesCloseButton.Name = "AppointmentTypesCloseButton";
            this.AppointmentTypesCloseButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentTypesCloseButton.TabIndex = 2;
            this.AppointmentTypesCloseButton.Text = "Close";
            this.AppointmentTypesCloseButton.UseVisualStyleBackColor = true;
            this.AppointmentTypesCloseButton.Click += new System.EventHandler(this.AppointmentTypesCloseButton_Click);
            // 
            // AppointmentTypesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.AppointmentTypesCloseButton);
            this.Controls.Add(this.AppointmentTypesDataGridView);
            this.Controls.Add(this.AppointmentTypesReportFormLabel);
            this.Name = "AppointmentTypesReportForm";
            this.Text = "Appointment Types by Month";
            this.Load += new System.EventHandler(this.AppointmentTypesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentTypesReportFormLabel;
        private System.Windows.Forms.DataGridView AppointmentTypesDataGridView;
        private System.Windows.Forms.Button AppointmentTypesCloseButton;
    }
}