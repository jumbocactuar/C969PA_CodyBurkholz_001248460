namespace C969PA_CodyBurkholz_001248460
{
    partial class CustomerScheduleReportForm
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
            this.CustomerScheduleReportFormLabel = new System.Windows.Forms.Label();
            this.CustomerScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerScheduleFormCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerScheduleReportFormLabel
            // 
            this.CustomerScheduleReportFormLabel.AutoSize = true;
            this.CustomerScheduleReportFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerScheduleReportFormLabel.Location = new System.Drawing.Point(13, 13);
            this.CustomerScheduleReportFormLabel.Name = "CustomerScheduleReportFormLabel";
            this.CustomerScheduleReportFormLabel.Size = new System.Drawing.Size(149, 20);
            this.CustomerScheduleReportFormLabel.TabIndex = 0;
            this.CustomerScheduleReportFormLabel.Text = "Customer Schedule";
            // 
            // CustomerScheduleDataGridView
            // 
            this.CustomerScheduleDataGridView.AllowUserToAddRows = false;
            this.CustomerScheduleDataGridView.AllowUserToDeleteRows = false;
            this.CustomerScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerScheduleDataGridView.Location = new System.Drawing.Point(17, 52);
            this.CustomerScheduleDataGridView.Name = "CustomerScheduleDataGridView";
            this.CustomerScheduleDataGridView.ReadOnly = true;
            this.CustomerScheduleDataGridView.RowHeadersVisible = false;
            this.CustomerScheduleDataGridView.Size = new System.Drawing.Size(303, 335);
            this.CustomerScheduleDataGridView.TabIndex = 1;
            // 
            // CustomerScheduleFormCloseButton
            // 
            this.CustomerScheduleFormCloseButton.Location = new System.Drawing.Point(245, 406);
            this.CustomerScheduleFormCloseButton.Name = "CustomerScheduleFormCloseButton";
            this.CustomerScheduleFormCloseButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerScheduleFormCloseButton.TabIndex = 2;
            this.CustomerScheduleFormCloseButton.Text = "Close";
            this.CustomerScheduleFormCloseButton.UseVisualStyleBackColor = true;
            this.CustomerScheduleFormCloseButton.Click += new System.EventHandler(this.CustomerScheduleFormCloseButton_Click);
            // 
            // CustomerScheduleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.CustomerScheduleFormCloseButton);
            this.Controls.Add(this.CustomerScheduleDataGridView);
            this.Controls.Add(this.CustomerScheduleReportFormLabel);
            this.Name = "CustomerScheduleReportForm";
            this.Text = "Customer Schedule";
            this.Load += new System.EventHandler(this.CustomerScheduleReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerScheduleReportFormLabel;
        private System.Windows.Forms.DataGridView CustomerScheduleDataGridView;
        private System.Windows.Forms.Button CustomerScheduleFormCloseButton;
    }
}