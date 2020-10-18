namespace C969PA_CodyBurkholz_001248460
{
    partial class ManagementPortalForm
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
            this.ManagementPortalCustomersButton = new System.Windows.Forms.Button();
            this.ManagementPortalLabel = new System.Windows.Forms.Label();
            this.ManagementPortalAppointmentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagementPortalCustomersButton
            // 
            this.ManagementPortalCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementPortalCustomersButton.Location = new System.Drawing.Point(109, 86);
            this.ManagementPortalCustomersButton.Name = "ManagementPortalCustomersButton";
            this.ManagementPortalCustomersButton.Size = new System.Drawing.Size(160, 60);
            this.ManagementPortalCustomersButton.TabIndex = 0;
            this.ManagementPortalCustomersButton.Text = "Manage Customers";
            this.ManagementPortalCustomersButton.UseVisualStyleBackColor = true;
            this.ManagementPortalCustomersButton.Click += new System.EventHandler(this.ManagementPortalCustomersButton_Click);
            // 
            // ManagementPortalLabel
            // 
            this.ManagementPortalLabel.AutoSize = true;
            this.ManagementPortalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementPortalLabel.Location = new System.Drawing.Point(13, 13);
            this.ManagementPortalLabel.Name = "ManagementPortalLabel";
            this.ManagementPortalLabel.Size = new System.Drawing.Size(148, 20);
            this.ManagementPortalLabel.TabIndex = 1;
            this.ManagementPortalLabel.Text = "Management Portal";
            // 
            // ManagementPortalAppointmentsButton
            // 
            this.ManagementPortalAppointmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementPortalAppointmentsButton.Location = new System.Drawing.Point(109, 189);
            this.ManagementPortalAppointmentsButton.Name = "ManagementPortalAppointmentsButton";
            this.ManagementPortalAppointmentsButton.Size = new System.Drawing.Size(160, 60);
            this.ManagementPortalAppointmentsButton.TabIndex = 2;
            this.ManagementPortalAppointmentsButton.Text = "Manage Appointments";
            this.ManagementPortalAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // ManagementPortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.ManagementPortalAppointmentsButton);
            this.Controls.Add(this.ManagementPortalLabel);
            this.Controls.Add(this.ManagementPortalCustomersButton);
            this.Name = "ManagementPortalForm";
            this.Text = "Management Portal";
            this.Load += new System.EventHandler(this.ManagementPortalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManagementPortalCustomersButton;
        private System.Windows.Forms.Label ManagementPortalLabel;
        private System.Windows.Forms.Button ManagementPortalAppointmentsButton;
    }
}