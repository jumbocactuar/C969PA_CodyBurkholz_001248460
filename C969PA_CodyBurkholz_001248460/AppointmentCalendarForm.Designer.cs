namespace C969PA_CodyBurkholz_001248460
{
    partial class AppointmentCalendarForm
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
            this.AppointmentCalendarFormLabel = new System.Windows.Forms.Label();
            this.AppointmentCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.AppointmentCalendarCloseButton = new System.Windows.Forms.Button();
            this.AppointmentCalendarMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.AppointmentCalendarWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.AppointmentCalendarMonthCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentCalendarFormLabel
            // 
            this.AppointmentCalendarFormLabel.AutoSize = true;
            this.AppointmentCalendarFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentCalendarFormLabel.Location = new System.Drawing.Point(13, 13);
            this.AppointmentCalendarFormLabel.Name = "AppointmentCalendarFormLabel";
            this.AppointmentCalendarFormLabel.Size = new System.Drawing.Size(168, 20);
            this.AppointmentCalendarFormLabel.TabIndex = 0;
            this.AppointmentCalendarFormLabel.Text = "Appointment Calendar";
            // 
            // AppointmentCalendarDataGridView
            // 
            this.AppointmentCalendarDataGridView.AllowUserToAddRows = false;
            this.AppointmentCalendarDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentCalendarDataGridView.Location = new System.Drawing.Point(12, 54);
            this.AppointmentCalendarDataGridView.Name = "AppointmentCalendarDataGridView";
            this.AppointmentCalendarDataGridView.ReadOnly = true;
            this.AppointmentCalendarDataGridView.RowHeadersVisible = false;
            this.AppointmentCalendarDataGridView.Size = new System.Drawing.Size(407, 325);
            this.AppointmentCalendarDataGridView.TabIndex = 1;
            // 
            // AppointmentCalendarCloseButton
            // 
            this.AppointmentCalendarCloseButton.Location = new System.Drawing.Point(625, 395);
            this.AppointmentCalendarCloseButton.Name = "AppointmentCalendarCloseButton";
            this.AppointmentCalendarCloseButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentCalendarCloseButton.TabIndex = 2;
            this.AppointmentCalendarCloseButton.Text = "Close";
            this.AppointmentCalendarCloseButton.UseVisualStyleBackColor = true;
            this.AppointmentCalendarCloseButton.Click += new System.EventHandler(this.AppointmentCalendarCloseButton_Click);
            // 
            // AppointmentCalendarMonthRadioButton
            // 
            this.AppointmentCalendarMonthRadioButton.AutoSize = true;
            this.AppointmentCalendarMonthRadioButton.Location = new System.Drawing.Point(554, 260);
            this.AppointmentCalendarMonthRadioButton.Name = "AppointmentCalendarMonthRadioButton";
            this.AppointmentCalendarMonthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.AppointmentCalendarMonthRadioButton.TabIndex = 5;
            this.AppointmentCalendarMonthRadioButton.TabStop = true;
            this.AppointmentCalendarMonthRadioButton.Text = "Month";
            this.AppointmentCalendarMonthRadioButton.UseVisualStyleBackColor = true;
            this.AppointmentCalendarMonthRadioButton.CheckedChanged += new System.EventHandler(this.AppointmentCalendarMonthRadioButton_CheckedChanged);
            // 
            // AppointmentCalendarWeekRadioButton
            // 
            this.AppointmentCalendarWeekRadioButton.AutoSize = true;
            this.AppointmentCalendarWeekRadioButton.Location = new System.Drawing.Point(554, 304);
            this.AppointmentCalendarWeekRadioButton.Name = "AppointmentCalendarWeekRadioButton";
            this.AppointmentCalendarWeekRadioButton.Size = new System.Drawing.Size(54, 17);
            this.AppointmentCalendarWeekRadioButton.TabIndex = 6;
            this.AppointmentCalendarWeekRadioButton.TabStop = true;
            this.AppointmentCalendarWeekRadioButton.Text = "Week";
            this.AppointmentCalendarWeekRadioButton.UseVisualStyleBackColor = true;
            this.AppointmentCalendarWeekRadioButton.CheckedChanged += new System.EventHandler(this.AppointmentCalendarWeekRadioButton_CheckedChanged);
            // 
            // AppointmentCalendarMonthCalendar
            // 
            this.AppointmentCalendarMonthCalendar.Location = new System.Drawing.Point(460, 54);
            this.AppointmentCalendarMonthCalendar.MaxSelectionCount = 1;
            this.AppointmentCalendarMonthCalendar.Name = "AppointmentCalendarMonthCalendar";
            this.AppointmentCalendarMonthCalendar.TabIndex = 7;
            this.AppointmentCalendarMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AppointmentCalendarMonthCalendar_DateSelected);
            // 
            // AppointmentCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.AppointmentCalendarMonthCalendar);
            this.Controls.Add(this.AppointmentCalendarWeekRadioButton);
            this.Controls.Add(this.AppointmentCalendarMonthRadioButton);
            this.Controls.Add(this.AppointmentCalendarCloseButton);
            this.Controls.Add(this.AppointmentCalendarDataGridView);
            this.Controls.Add(this.AppointmentCalendarFormLabel);
            this.Name = "AppointmentCalendarForm";
            this.Text = "Appointment Calendar";
            this.Load += new System.EventHandler(this.AppointmentCalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentCalendarFormLabel;
        private System.Windows.Forms.DataGridView AppointmentCalendarDataGridView;
        private System.Windows.Forms.Button AppointmentCalendarCloseButton;
        private System.Windows.Forms.RadioButton AppointmentCalendarMonthRadioButton;
        private System.Windows.Forms.RadioButton AppointmentCalendarWeekRadioButton;
        private System.Windows.Forms.MonthCalendar AppointmentCalendarMonthCalendar;
    }
}