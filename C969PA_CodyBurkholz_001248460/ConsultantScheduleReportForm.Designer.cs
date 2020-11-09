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
            this.ConsultantScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultantScheduleCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantScheduleDataGridView)).BeginInit();
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
            // ConsultantScheduleDataGridView
            // 
            this.ConsultantScheduleDataGridView.AllowUserToAddRows = false;
            this.ConsultantScheduleDataGridView.AllowUserToDeleteRows = false;
            this.ConsultantScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultantScheduleDataGridView.Location = new System.Drawing.Point(17, 48);
            this.ConsultantScheduleDataGridView.Name = "ConsultantScheduleDataGridView";
            this.ConsultantScheduleDataGridView.ReadOnly = true;
            this.ConsultantScheduleDataGridView.RowHeadersVisible = false;
            this.ConsultantScheduleDataGridView.Size = new System.Drawing.Size(303, 335);
            this.ConsultantScheduleDataGridView.TabIndex = 1;
            // 
            // ConsultantScheduleCloseButton
            // 
            this.ConsultantScheduleCloseButton.Location = new System.Drawing.Point(245, 406);
            this.ConsultantScheduleCloseButton.Name = "ConsultantScheduleCloseButton";
            this.ConsultantScheduleCloseButton.Size = new System.Drawing.Size(75, 23);
            this.ConsultantScheduleCloseButton.TabIndex = 2;
            this.ConsultantScheduleCloseButton.Text = "Close";
            this.ConsultantScheduleCloseButton.UseVisualStyleBackColor = true;
            this.ConsultantScheduleCloseButton.Click += new System.EventHandler(this.ConsultantScheduleCloseButton_Click);
            // 
            // ConsultantScheduleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.ConsultantScheduleCloseButton);
            this.Controls.Add(this.ConsultantScheduleDataGridView);
            this.Controls.Add(this.ConsultantScheduleReportFormLabel);
            this.Name = "ConsultantScheduleReportForm";
            this.Text = "Consultant Schedule";
            this.Load += new System.EventHandler(this.ConsultantScheduleReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultantScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultantScheduleReportFormLabel;
        private System.Windows.Forms.DataGridView ConsultantScheduleDataGridView;
        private System.Windows.Forms.Button ConsultantScheduleCloseButton;
    }
}