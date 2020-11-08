namespace C969PA_CodyBurkholz_001248460
{
    partial class ConsultantScheduleReportForm
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
            this.ConsultantScheduleReportFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsultantScheduleReportFormLabel
            // 
            this.ConsultantScheduleReportFormLabel.AutoSize = true;
            this.ConsultantScheduleReportFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantScheduleReportFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ConsultantScheduleReportFormLabel.Name = "ConsultantScheduleReportFormLabel";
            this.ConsultantScheduleReportFormLabel.Size = new System.Drawing.Size(157, 20);
            this.ConsultantScheduleReportFormLabel.TabIndex = 0;
            this.ConsultantScheduleReportFormLabel.Text = "Consultant Schedule";
            // 
            // ConsultantScheduleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsultantScheduleReportFormLabel);
            this.Name = "ConsultantScheduleReportForm";
            this.Text = "Consultant Schedule";
            this.Load += new System.EventHandler(this.ConsultantScheduleReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultantScheduleReportFormLabel;
    }
}