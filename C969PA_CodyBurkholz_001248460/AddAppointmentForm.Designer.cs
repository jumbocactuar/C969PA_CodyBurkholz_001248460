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
            this.AddAppointmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentTitleLabel = new System.Windows.Forms.Label();
            this.AddAppointmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.AddAppointmentLocationComboBox = new System.Windows.Forms.ComboBox();
            this.AddAppointmentLocationLabel = new System.Windows.Forms.Label();
            this.AddAppointmentContactTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentContactLabel = new System.Windows.Forms.Label();
            this.AddAppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddAppointmentTypeLabel = new System.Windows.Forms.Label();
            this.AddAppointmentUrlTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentUrlLabel = new System.Windows.Forms.Label();
            this.AddAppointmentStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAppointmentStartLabel = new System.Windows.Forms.Label();
            this.AddAppointmentEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddAppointmentEndLabel = new System.Windows.Forms.Label();
            this.AddAppointmentConsultantTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentConsultantLabel = new System.Windows.Forms.Label();
            this.AddAppointmentCustomerTextBox = new System.Windows.Forms.TextBox();
            this.AddAppointmentCustomerLabel = new System.Windows.Forms.Label();
            this.AddAppointmentSelectConsultantButton = new System.Windows.Forms.Button();
            this.AddAppointmentSelectCustomerButton = new System.Windows.Forms.Button();
            this.AddAppointmentSaveButton = new System.Windows.Forms.Button();
            this.AddAppointmentCancelButton = new System.Windows.Forms.Button();
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
            // AddAppointmentTitleTextBox
            // 
            this.AddAppointmentTitleTextBox.Location = new System.Drawing.Point(94, 78);
            this.AddAppointmentTitleTextBox.Name = "AddAppointmentTitleTextBox";
            this.AddAppointmentTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentTitleTextBox.TabIndex = 1;
            this.AddAppointmentTitleTextBox.TextChanged += new System.EventHandler(this.AddAppointmentTitleTextBox_TextChanged);
            // 
            // AddAppointmentTitleLabel
            // 
            this.AddAppointmentTitleLabel.AutoSize = true;
            this.AddAppointmentTitleLabel.Location = new System.Drawing.Point(61, 81);
            this.AddAppointmentTitleLabel.Name = "AddAppointmentTitleLabel";
            this.AddAppointmentTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.AddAppointmentTitleLabel.TabIndex = 2;
            this.AddAppointmentTitleLabel.Text = "Title";
            // 
            // AddAppointmentDescriptionTextBox
            // 
            this.AddAppointmentDescriptionTextBox.Location = new System.Drawing.Point(94, 128);
            this.AddAppointmentDescriptionTextBox.Multiline = true;
            this.AddAppointmentDescriptionTextBox.Name = "AddAppointmentDescriptionTextBox";
            this.AddAppointmentDescriptionTextBox.Size = new System.Drawing.Size(200, 100);
            this.AddAppointmentDescriptionTextBox.TabIndex = 3;
            this.AddAppointmentDescriptionTextBox.TextChanged += new System.EventHandler(this.AddAppointmentDescriptionTextBox_TextChanged);
            // 
            // AddAppointmentDescriptionLabel
            // 
            this.AddAppointmentDescriptionLabel.AutoSize = true;
            this.AddAppointmentDescriptionLabel.Location = new System.Drawing.Point(28, 131);
            this.AddAppointmentDescriptionLabel.Name = "AddAppointmentDescriptionLabel";
            this.AddAppointmentDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.AddAppointmentDescriptionLabel.TabIndex = 4;
            this.AddAppointmentDescriptionLabel.Text = "Description";
            // 
            // AddAppointmentLocationComboBox
            // 
            this.AddAppointmentLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddAppointmentLocationComboBox.FormattingEnabled = true;
            this.AddAppointmentLocationComboBox.Items.AddRange(new object[] {
            "London",
            "New York",
            "Phoenix"});
            this.AddAppointmentLocationComboBox.Location = new System.Drawing.Point(94, 260);
            this.AddAppointmentLocationComboBox.Name = "AddAppointmentLocationComboBox";
            this.AddAppointmentLocationComboBox.Size = new System.Drawing.Size(200, 21);
            this.AddAppointmentLocationComboBox.TabIndex = 5;
            this.AddAppointmentLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.AddAppointmentLocationComboBox_SelectedIndexChanged);
            // 
            // AddAppointmentLocationLabel
            // 
            this.AddAppointmentLocationLabel.AutoSize = true;
            this.AddAppointmentLocationLabel.Location = new System.Drawing.Point(40, 263);
            this.AddAppointmentLocationLabel.Name = "AddAppointmentLocationLabel";
            this.AddAppointmentLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.AddAppointmentLocationLabel.TabIndex = 6;
            this.AddAppointmentLocationLabel.Text = "Location";
            // 
            // AddAppointmentContactTextBox
            // 
            this.AddAppointmentContactTextBox.Location = new System.Drawing.Point(94, 314);
            this.AddAppointmentContactTextBox.Name = "AddAppointmentContactTextBox";
            this.AddAppointmentContactTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentContactTextBox.TabIndex = 7;
            this.AddAppointmentContactTextBox.TextChanged += new System.EventHandler(this.AddAppointmentContactTextBox_TextChanged);
            // 
            // AddAppointmentContactLabel
            // 
            this.AddAppointmentContactLabel.AutoSize = true;
            this.AddAppointmentContactLabel.Location = new System.Drawing.Point(44, 317);
            this.AddAppointmentContactLabel.Name = "AddAppointmentContactLabel";
            this.AddAppointmentContactLabel.Size = new System.Drawing.Size(44, 13);
            this.AddAppointmentContactLabel.TabIndex = 8;
            this.AddAppointmentContactLabel.Text = "Contact";
            // 
            // AddAppointmentTypeComboBox
            // 
            this.AddAppointmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddAppointmentTypeComboBox.FormattingEnabled = true;
            this.AddAppointmentTypeComboBox.Items.AddRange(new object[] {
            "Consultation (15 min)",
            "Short Appointment (30 min)",
            "Long Appointment (60 min)"});
            this.AddAppointmentTypeComboBox.Location = new System.Drawing.Point(94, 371);
            this.AddAppointmentTypeComboBox.Name = "AddAppointmentTypeComboBox";
            this.AddAppointmentTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.AddAppointmentTypeComboBox.TabIndex = 9;
            this.AddAppointmentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AddAppointmentTypeComboBox_SelectedIndexChanged);
            // 
            // AddAppointmentTypeLabel
            // 
            this.AddAppointmentTypeLabel.AutoSize = true;
            this.AddAppointmentTypeLabel.Location = new System.Drawing.Point(57, 374);
            this.AddAppointmentTypeLabel.Name = "AddAppointmentTypeLabel";
            this.AddAppointmentTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.AddAppointmentTypeLabel.TabIndex = 10;
            this.AddAppointmentTypeLabel.Text = "Type";
            // 
            // AddAppointmentUrlTextBox
            // 
            this.AddAppointmentUrlTextBox.Location = new System.Drawing.Point(94, 430);
            this.AddAppointmentUrlTextBox.Name = "AddAppointmentUrlTextBox";
            this.AddAppointmentUrlTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentUrlTextBox.TabIndex = 11;
            // 
            // AddAppointmentUrlLabel
            // 
            this.AddAppointmentUrlLabel.AutoSize = true;
            this.AddAppointmentUrlLabel.Location = new System.Drawing.Point(59, 433);
            this.AddAppointmentUrlLabel.Name = "AddAppointmentUrlLabel";
            this.AddAppointmentUrlLabel.Size = new System.Drawing.Size(29, 13);
            this.AddAppointmentUrlLabel.TabIndex = 12;
            this.AddAppointmentUrlLabel.Text = "URL";
            // 
            // AddAppointmentStartDateTimePicker
            // 
            this.AddAppointmentStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddAppointmentStartDateTimePicker.Location = new System.Drawing.Point(433, 128);
            this.AddAppointmentStartDateTimePicker.Name = "AddAppointmentStartDateTimePicker";
            this.AddAppointmentStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentStartDateTimePicker.TabIndex = 13;
            // 
            // AddAppointmentStartLabel
            // 
            this.AddAppointmentStartLabel.AutoSize = true;
            this.AddAppointmentStartLabel.Location = new System.Drawing.Point(398, 131);
            this.AddAppointmentStartLabel.Name = "AddAppointmentStartLabel";
            this.AddAppointmentStartLabel.Size = new System.Drawing.Size(29, 13);
            this.AddAppointmentStartLabel.TabIndex = 14;
            this.AddAppointmentStartLabel.Text = "Start";
            // 
            // AddAppointmentEndDateTimePicker
            // 
            this.AddAppointmentEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddAppointmentEndDateTimePicker.Location = new System.Drawing.Point(433, 208);
            this.AddAppointmentEndDateTimePicker.Name = "AddAppointmentEndDateTimePicker";
            this.AddAppointmentEndDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentEndDateTimePicker.TabIndex = 15;
            // 
            // AddAppointmentEndLabel
            // 
            this.AddAppointmentEndLabel.AutoSize = true;
            this.AddAppointmentEndLabel.Location = new System.Drawing.Point(401, 211);
            this.AddAppointmentEndLabel.Name = "AddAppointmentEndLabel";
            this.AddAppointmentEndLabel.Size = new System.Drawing.Size(26, 13);
            this.AddAppointmentEndLabel.TabIndex = 16;
            this.AddAppointmentEndLabel.Text = "End";
            // 
            // AddAppointmentConsultantTextBox
            // 
            this.AddAppointmentConsultantTextBox.Location = new System.Drawing.Point(433, 261);
            this.AddAppointmentConsultantTextBox.Name = "AddAppointmentConsultantTextBox";
            this.AddAppointmentConsultantTextBox.ReadOnly = true;
            this.AddAppointmentConsultantTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentConsultantTextBox.TabIndex = 17;
            this.AddAppointmentConsultantTextBox.TextChanged += new System.EventHandler(this.AddAppointmentConsultantTextBox_TextChanged);
            // 
            // AddAppointmentConsultantLabel
            // 
            this.AddAppointmentConsultantLabel.AutoSize = true;
            this.AddAppointmentConsultantLabel.Location = new System.Drawing.Point(370, 264);
            this.AddAppointmentConsultantLabel.Name = "AddAppointmentConsultantLabel";
            this.AddAppointmentConsultantLabel.Size = new System.Drawing.Size(57, 13);
            this.AddAppointmentConsultantLabel.TabIndex = 18;
            this.AddAppointmentConsultantLabel.Text = "Consultant";
            // 
            // AddAppointmentCustomerTextBox
            // 
            this.AddAppointmentCustomerTextBox.Location = new System.Drawing.Point(433, 314);
            this.AddAppointmentCustomerTextBox.Name = "AddAppointmentCustomerTextBox";
            this.AddAppointmentCustomerTextBox.ReadOnly = true;
            this.AddAppointmentCustomerTextBox.Size = new System.Drawing.Size(200, 20);
            this.AddAppointmentCustomerTextBox.TabIndex = 19;
            this.AddAppointmentCustomerTextBox.TextChanged += new System.EventHandler(this.AddAppointmentCustomerTextBox_TextChanged);
            // 
            // AddAppointmentCustomerLabel
            // 
            this.AddAppointmentCustomerLabel.AutoSize = true;
            this.AddAppointmentCustomerLabel.Location = new System.Drawing.Point(376, 317);
            this.AddAppointmentCustomerLabel.Name = "AddAppointmentCustomerLabel";
            this.AddAppointmentCustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.AddAppointmentCustomerLabel.TabIndex = 20;
            this.AddAppointmentCustomerLabel.Text = "Customer";
            // 
            // AddAppointmentSelectConsultantButton
            // 
            this.AddAppointmentSelectConsultantButton.Location = new System.Drawing.Point(677, 259);
            this.AddAppointmentSelectConsultantButton.Name = "AddAppointmentSelectConsultantButton";
            this.AddAppointmentSelectConsultantButton.Size = new System.Drawing.Size(125, 23);
            this.AddAppointmentSelectConsultantButton.TabIndex = 21;
            this.AddAppointmentSelectConsultantButton.Text = "Select Consultant";
            this.AddAppointmentSelectConsultantButton.UseVisualStyleBackColor = true;
            this.AddAppointmentSelectConsultantButton.Click += new System.EventHandler(this.AddAppointmentSelectConsultantButton_Click);
            // 
            // AddAppointmentSelectCustomerButton
            // 
            this.AddAppointmentSelectCustomerButton.Location = new System.Drawing.Point(677, 312);
            this.AddAppointmentSelectCustomerButton.Name = "AddAppointmentSelectCustomerButton";
            this.AddAppointmentSelectCustomerButton.Size = new System.Drawing.Size(125, 23);
            this.AddAppointmentSelectCustomerButton.TabIndex = 22;
            this.AddAppointmentSelectCustomerButton.Text = "Select Customer";
            this.AddAppointmentSelectCustomerButton.UseVisualStyleBackColor = true;
            this.AddAppointmentSelectCustomerButton.Click += new System.EventHandler(this.AddAppointmentSelectCustomerButton_Click);
            // 
            // AddAppointmentSaveButton
            // 
            this.AddAppointmentSaveButton.Location = new System.Drawing.Point(646, 428);
            this.AddAppointmentSaveButton.Name = "AddAppointmentSaveButton";
            this.AddAppointmentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentSaveButton.TabIndex = 23;
            this.AddAppointmentSaveButton.Text = "Save";
            this.AddAppointmentSaveButton.UseVisualStyleBackColor = true;
            this.AddAppointmentSaveButton.Click += new System.EventHandler(this.AddAppointmentSaveButton_Click);
            // 
            // AddAppointmentCancelButton
            // 
            this.AddAppointmentCancelButton.Location = new System.Drawing.Point(727, 428);
            this.AddAppointmentCancelButton.Name = "AddAppointmentCancelButton";
            this.AddAppointmentCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddAppointmentCancelButton.TabIndex = 24;
            this.AddAppointmentCancelButton.Text = "Cancel";
            this.AddAppointmentCancelButton.UseVisualStyleBackColor = true;
            this.AddAppointmentCancelButton.Click += new System.EventHandler(this.AddAppointmentCancelButton_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 485);
            this.Controls.Add(this.AddAppointmentCancelButton);
            this.Controls.Add(this.AddAppointmentSaveButton);
            this.Controls.Add(this.AddAppointmentSelectCustomerButton);
            this.Controls.Add(this.AddAppointmentSelectConsultantButton);
            this.Controls.Add(this.AddAppointmentCustomerLabel);
            this.Controls.Add(this.AddAppointmentCustomerTextBox);
            this.Controls.Add(this.AddAppointmentConsultantLabel);
            this.Controls.Add(this.AddAppointmentConsultantTextBox);
            this.Controls.Add(this.AddAppointmentEndLabel);
            this.Controls.Add(this.AddAppointmentEndDateTimePicker);
            this.Controls.Add(this.AddAppointmentStartLabel);
            this.Controls.Add(this.AddAppointmentStartDateTimePicker);
            this.Controls.Add(this.AddAppointmentUrlLabel);
            this.Controls.Add(this.AddAppointmentUrlTextBox);
            this.Controls.Add(this.AddAppointmentTypeLabel);
            this.Controls.Add(this.AddAppointmentTypeComboBox);
            this.Controls.Add(this.AddAppointmentContactLabel);
            this.Controls.Add(this.AddAppointmentContactTextBox);
            this.Controls.Add(this.AddAppointmentLocationLabel);
            this.Controls.Add(this.AddAppointmentLocationComboBox);
            this.Controls.Add(this.AddAppointmentDescriptionLabel);
            this.Controls.Add(this.AddAppointmentDescriptionTextBox);
            this.Controls.Add(this.AddAppointmentTitleLabel);
            this.Controls.Add(this.AddAppointmentTitleTextBox);
            this.Controls.Add(this.AddAppointmentFormLabel);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddAppointmentFormLabel;
        private System.Windows.Forms.TextBox AddAppointmentTitleTextBox;
        private System.Windows.Forms.Label AddAppointmentTitleLabel;
        private System.Windows.Forms.TextBox AddAppointmentDescriptionTextBox;
        private System.Windows.Forms.Label AddAppointmentDescriptionLabel;
        private System.Windows.Forms.ComboBox AddAppointmentLocationComboBox;
        private System.Windows.Forms.Label AddAppointmentLocationLabel;
        private System.Windows.Forms.TextBox AddAppointmentContactTextBox;
        private System.Windows.Forms.Label AddAppointmentContactLabel;
        private System.Windows.Forms.ComboBox AddAppointmentTypeComboBox;
        private System.Windows.Forms.Label AddAppointmentTypeLabel;
        private System.Windows.Forms.TextBox AddAppointmentUrlTextBox;
        private System.Windows.Forms.Label AddAppointmentUrlLabel;
        private System.Windows.Forms.DateTimePicker AddAppointmentStartDateTimePicker;
        private System.Windows.Forms.Label AddAppointmentStartLabel;
        private System.Windows.Forms.DateTimePicker AddAppointmentEndDateTimePicker;
        private System.Windows.Forms.Label AddAppointmentEndLabel;
        private System.Windows.Forms.TextBox AddAppointmentConsultantTextBox;
        private System.Windows.Forms.Label AddAppointmentConsultantLabel;
        private System.Windows.Forms.TextBox AddAppointmentCustomerTextBox;
        private System.Windows.Forms.Label AddAppointmentCustomerLabel;
        private System.Windows.Forms.Button AddAppointmentSelectConsultantButton;
        private System.Windows.Forms.Button AddAppointmentSelectCustomerButton;
        private System.Windows.Forms.Button AddAppointmentSaveButton;
        private System.Windows.Forms.Button AddAppointmentCancelButton;
    }
}