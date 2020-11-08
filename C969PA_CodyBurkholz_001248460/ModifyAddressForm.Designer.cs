namespace C969PA_CodyBurkholz_001248460
{
    partial class ModifyAddressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyAddressCancelButton = new System.Windows.Forms.Button();
            this.ModifyAddressSaveButton = new System.Windows.Forms.Button();
            this.ModifyAddressPhoneLabel = new System.Windows.Forms.Label();
            this.ModifyAddressPhoneTextBox = new System.Windows.Forms.TextBox();
            this.ModifyAddressPostalCodeLabel = new System.Windows.Forms.Label();
            this.ModifyAddressCityComboBox = new System.Windows.Forms.ComboBox();
            this.ModifyAddressCityLabel = new System.Windows.Forms.Label();
            this.ModifyAddressAddress2Label = new System.Windows.Forms.Label();
            this.ModifyAddressAddress1Label = new System.Windows.Forms.Label();
            this.ModifyAddressPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.ModifyAddressAddress2TextBox = new System.Windows.Forms.TextBox();
            this.ModifyAddressAddress1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Address";
            // 
            // ModifyAddressCancelButton
            // 
            this.ModifyAddressCancelButton.Location = new System.Drawing.Point(168, 363);
            this.ModifyAddressCancelButton.Name = "ModifyAddressCancelButton";
            this.ModifyAddressCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyAddressCancelButton.TabIndex = 6;
            this.ModifyAddressCancelButton.Text = "Cancel";
            this.ModifyAddressCancelButton.UseVisualStyleBackColor = true;
            this.ModifyAddressCancelButton.Click += new System.EventHandler(this.ModifyAddressCancelButton_Click);
            // 
            // ModifyAddressSaveButton
            // 
            this.ModifyAddressSaveButton.Location = new System.Drawing.Point(87, 363);
            this.ModifyAddressSaveButton.Name = "ModifyAddressSaveButton";
            this.ModifyAddressSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyAddressSaveButton.TabIndex = 5;
            this.ModifyAddressSaveButton.Text = "Save";
            this.ModifyAddressSaveButton.UseVisualStyleBackColor = true;
            this.ModifyAddressSaveButton.Click += new System.EventHandler(this.ModifyAddressSaveButton_Click);
            // 
            // ModifyAddressPhoneLabel
            // 
            this.ModifyAddressPhoneLabel.AutoSize = true;
            this.ModifyAddressPhoneLabel.Location = new System.Drawing.Point(84, 290);
            this.ModifyAddressPhoneLabel.Name = "ModifyAddressPhoneLabel";
            this.ModifyAddressPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.ModifyAddressPhoneLabel.TabIndex = 48;
            this.ModifyAddressPhoneLabel.Text = "Phone";
            // 
            // ModifyAddressPhoneTextBox
            // 
            this.ModifyAddressPhoneTextBox.Location = new System.Drawing.Point(128, 287);
            this.ModifyAddressPhoneTextBox.Name = "ModifyAddressPhoneTextBox";
            this.ModifyAddressPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyAddressPhoneTextBox.TabIndex = 4;
            this.ModifyAddressPhoneTextBox.TextChanged += new System.EventHandler(this.ModifyAddressPhoneTextBox_TextChanged);
            // 
            // ModifyAddressPostalCodeLabel
            // 
            this.ModifyAddressPostalCodeLabel.AutoSize = true;
            this.ModifyAddressPostalCodeLabel.Location = new System.Drawing.Point(58, 238);
            this.ModifyAddressPostalCodeLabel.Name = "ModifyAddressPostalCodeLabel";
            this.ModifyAddressPostalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.ModifyAddressPostalCodeLabel.TabIndex = 46;
            this.ModifyAddressPostalCodeLabel.Text = "Postal Code";
            // 
            // ModifyAddressCityComboBox
            // 
            this.ModifyAddressCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifyAddressCityComboBox.FormattingEnabled = true;
            this.ModifyAddressCityComboBox.Items.AddRange(new object[] {
            "London",
            "New York",
            "Phoenix"});
            this.ModifyAddressCityComboBox.Location = new System.Drawing.Point(128, 180);
            this.ModifyAddressCityComboBox.Name = "ModifyAddressCityComboBox";
            this.ModifyAddressCityComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModifyAddressCityComboBox.TabIndex = 2;
            this.ModifyAddressCityComboBox.SelectedIndexChanged += new System.EventHandler(this.ModifyAddressCityComboBox_SelectedIndexChanged);
            // 
            // ModifyAddressCityLabel
            // 
            this.ModifyAddressCityLabel.AutoSize = true;
            this.ModifyAddressCityLabel.Location = new System.Drawing.Point(98, 183);
            this.ModifyAddressCityLabel.Name = "ModifyAddressCityLabel";
            this.ModifyAddressCityLabel.Size = new System.Drawing.Size(24, 13);
            this.ModifyAddressCityLabel.TabIndex = 44;
            this.ModifyAddressCityLabel.Text = "City";
            // 
            // ModifyAddressAddress2Label
            // 
            this.ModifyAddressAddress2Label.AutoSize = true;
            this.ModifyAddressAddress2Label.Location = new System.Drawing.Point(68, 129);
            this.ModifyAddressAddress2Label.Name = "ModifyAddressAddress2Label";
            this.ModifyAddressAddress2Label.Size = new System.Drawing.Size(54, 13);
            this.ModifyAddressAddress2Label.TabIndex = 43;
            this.ModifyAddressAddress2Label.Text = "Address 2";
            // 
            // ModifyAddressAddress1Label
            // 
            this.ModifyAddressAddress1Label.AutoSize = true;
            this.ModifyAddressAddress1Label.Location = new System.Drawing.Point(68, 81);
            this.ModifyAddressAddress1Label.Name = "ModifyAddressAddress1Label";
            this.ModifyAddressAddress1Label.Size = new System.Drawing.Size(54, 13);
            this.ModifyAddressAddress1Label.TabIndex = 42;
            this.ModifyAddressAddress1Label.Text = "Address 1";
            // 
            // ModifyAddressPostalCodeTextBox
            // 
            this.ModifyAddressPostalCodeTextBox.Location = new System.Drawing.Point(128, 235);
            this.ModifyAddressPostalCodeTextBox.Name = "ModifyAddressPostalCodeTextBox";
            this.ModifyAddressPostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyAddressPostalCodeTextBox.TabIndex = 3;
            this.ModifyAddressPostalCodeTextBox.TextChanged += new System.EventHandler(this.ModifyAddressPostalCodeTextBox_TextChanged);
            // 
            // ModifyAddressAddress2TextBox
            // 
            this.ModifyAddressAddress2TextBox.Location = new System.Drawing.Point(128, 126);
            this.ModifyAddressAddress2TextBox.Name = "ModifyAddressAddress2TextBox";
            this.ModifyAddressAddress2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyAddressAddress2TextBox.TabIndex = 1;
            // 
            // ModifyAddressAddress1TextBox
            // 
            this.ModifyAddressAddress1TextBox.Location = new System.Drawing.Point(128, 78);
            this.ModifyAddressAddress1TextBox.Name = "ModifyAddressAddress1TextBox";
            this.ModifyAddressAddress1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyAddressAddress1TextBox.TabIndex = 0;
            this.ModifyAddressAddress1TextBox.TextChanged += new System.EventHandler(this.ModifyAddressAddress1TextBox_TextChanged);
            // 
            // ModifyAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.ModifyAddressCancelButton);
            this.Controls.Add(this.ModifyAddressSaveButton);
            this.Controls.Add(this.ModifyAddressPhoneLabel);
            this.Controls.Add(this.ModifyAddressPhoneTextBox);
            this.Controls.Add(this.ModifyAddressPostalCodeLabel);
            this.Controls.Add(this.ModifyAddressCityComboBox);
            this.Controls.Add(this.ModifyAddressCityLabel);
            this.Controls.Add(this.ModifyAddressAddress2Label);
            this.Controls.Add(this.ModifyAddressAddress1Label);
            this.Controls.Add(this.ModifyAddressPostalCodeTextBox);
            this.Controls.Add(this.ModifyAddressAddress2TextBox);
            this.Controls.Add(this.ModifyAddressAddress1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "ModifyAddressForm";
            this.Text = "Modify Address";
            this.Load += new System.EventHandler(this.ModifyAddressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifyAddressCancelButton;
        private System.Windows.Forms.Button ModifyAddressSaveButton;
        private System.Windows.Forms.Label ModifyAddressPhoneLabel;
        private System.Windows.Forms.TextBox ModifyAddressPhoneTextBox;
        private System.Windows.Forms.Label ModifyAddressPostalCodeLabel;
        private System.Windows.Forms.ComboBox ModifyAddressCityComboBox;
        private System.Windows.Forms.Label ModifyAddressCityLabel;
        private System.Windows.Forms.Label ModifyAddressAddress2Label;
        private System.Windows.Forms.Label ModifyAddressAddress1Label;
        private System.Windows.Forms.TextBox ModifyAddressPostalCodeTextBox;
        private System.Windows.Forms.TextBox ModifyAddressAddress2TextBox;
        private System.Windows.Forms.TextBox ModifyAddressAddress1TextBox;
    }
}