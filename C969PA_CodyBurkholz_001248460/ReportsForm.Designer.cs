namespace C969PA_CodyBurkholz_001248460
{
    partial class ReportsForm
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
            this.AppointmentTypesButton = new System.Windows.Forms.Button();
            this.ConsultantScheduleButton = new System.Windows.Forms.Button();
            this.CustomerScheduleButton = new System.Windows.Forms.Button();
            this.ActivityLogButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppointmentTypesButton
            // 
            this.AppointmentTypesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentTypesButton.Location = new System.Drawing.Point(48, 63);
            this.AppointmentTypesButton.Name = "AppointmentTypesButton";
            this.AppointmentTypesButton.Size = new System.Drawing.Size(195, 70);
            this.AppointmentTypesButton.TabIndex = 0;
            this.AppointmentTypesButton.Text = "Appointment Types Report";
            this.AppointmentTypesButton.UseVisualStyleBackColor = true;
            this.AppointmentTypesButton.Click += new System.EventHandler(this.AppointmentTypesButton_Click);
            // 
            // ConsultantScheduleButton
            // 
            this.ConsultantScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultantScheduleButton.Location = new System.Drawing.Point(48, 155);
            this.ConsultantScheduleButton.Name = "ConsultantScheduleButton";
            this.ConsultantScheduleButton.Size = new System.Drawing.Size(195, 70);
            this.ConsultantScheduleButton.TabIndex = 1;
            this.ConsultantScheduleButton.Text = "Consultant Schedule Report";
            this.ConsultantScheduleButton.UseVisualStyleBackColor = true;
            this.ConsultantScheduleButton.Click += new System.EventHandler(this.ConsultantScheduleButton_Click);
            // 
            // CustomerScheduleButton
            // 
            this.CustomerScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerScheduleButton.Location = new System.Drawing.Point(48, 248);
            this.CustomerScheduleButton.Name = "CustomerScheduleButton";
            this.CustomerScheduleButton.Size = new System.Drawing.Size(195, 70);
            this.CustomerScheduleButton.TabIndex = 2;
            this.CustomerScheduleButton.Text = "Customer Schedule Report";
            this.CustomerScheduleButton.UseVisualStyleBackColor = true;
            this.CustomerScheduleButton.Click += new System.EventHandler(this.CustomerScheduleButton_Click);
            // 
            // ActivityLogButton
            // 
            this.ActivityLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLogButton.Location = new System.Drawing.Point(48, 341);
            this.ActivityLogButton.Name = "ActivityLogButton";
            this.ActivityLogButton.Size = new System.Drawing.Size(195, 70);
            this.ActivityLogButton.TabIndex = 3;
            this.ActivityLogButton.Text = "Download User Activity Log";
            this.ActivityLogButton.UseVisualStyleBackColor = true;
            this.ActivityLogButton.Click += new System.EventHandler(this.ActivityLogButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reports";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActivityLogButton);
            this.Controls.Add(this.CustomerScheduleButton);
            this.Controls.Add(this.ConsultantScheduleButton);
            this.Controls.Add(this.AppointmentTypesButton);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AppointmentTypesButton;
        private System.Windows.Forms.Button ConsultantScheduleButton;
        private System.Windows.Forms.Button CustomerScheduleButton;
        private System.Windows.Forms.Button ActivityLogButton;
        private System.Windows.Forms.Label label1;
    }
}