namespace C969PA_CodyBurkholz_001248460
{
    partial class ModifyUserForm
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
            this.ModifyUserFormLabel = new System.Windows.Forms.Label();
            this.ModifyUserCancelButton = new System.Windows.Forms.Button();
            this.ModifyUserSaveButton = new System.Windows.Forms.Button();
            this.ModifyUserPasswordLabel = new System.Windows.Forms.Label();
            this.ModifyUserUserNameLabel = new System.Windows.Forms.Label();
            this.ModifyUserActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ModifyUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ModifyUserUserNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModifyUserFormLabel
            // 
            this.ModifyUserFormLabel.AutoSize = true;
            this.ModifyUserFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyUserFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ModifyUserFormLabel.Name = "ModifyUserFormLabel";
            this.ModifyUserFormLabel.Size = new System.Drawing.Size(93, 20);
            this.ModifyUserFormLabel.TabIndex = 0;
            this.ModifyUserFormLabel.Text = "Modify User";
            // 
            // ModifyUserCancelButton
            // 
            this.ModifyUserCancelButton.Location = new System.Drawing.Point(131, 263);
            this.ModifyUserCancelButton.Name = "ModifyUserCancelButton";
            this.ModifyUserCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyUserCancelButton.TabIndex = 14;
            this.ModifyUserCancelButton.Text = "Cancel";
            this.ModifyUserCancelButton.UseVisualStyleBackColor = true;
            this.ModifyUserCancelButton.Click += new System.EventHandler(this.ModifyUserCancelButton_Click);
            // 
            // ModifyUserSaveButton
            // 
            this.ModifyUserSaveButton.Location = new System.Drawing.Point(50, 263);
            this.ModifyUserSaveButton.Name = "ModifyUserSaveButton";
            this.ModifyUserSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyUserSaveButton.TabIndex = 13;
            this.ModifyUserSaveButton.Text = "Save";
            this.ModifyUserSaveButton.UseVisualStyleBackColor = true;
            this.ModifyUserSaveButton.Click += new System.EventHandler(this.ModifyUserSaveButton_Click);
            // 
            // ModifyUserPasswordLabel
            // 
            this.ModifyUserPasswordLabel.AutoSize = true;
            this.ModifyUserPasswordLabel.Location = new System.Drawing.Point(47, 132);
            this.ModifyUserPasswordLabel.Name = "ModifyUserPasswordLabel";
            this.ModifyUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.ModifyUserPasswordLabel.TabIndex = 12;
            this.ModifyUserPasswordLabel.Text = "Password";
            // 
            // ModifyUserUserNameLabel
            // 
            this.ModifyUserUserNameLabel.AutoSize = true;
            this.ModifyUserUserNameLabel.Location = new System.Drawing.Point(40, 73);
            this.ModifyUserUserNameLabel.Name = "ModifyUserUserNameLabel";
            this.ModifyUserUserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.ModifyUserUserNameLabel.TabIndex = 11;
            this.ModifyUserUserNameLabel.Text = "User Name";
            // 
            // ModifyUserActiveCheckBox
            // 
            this.ModifyUserActiveCheckBox.AutoSize = true;
            this.ModifyUserActiveCheckBox.Location = new System.Drawing.Point(106, 190);
            this.ModifyUserActiveCheckBox.Name = "ModifyUserActiveCheckBox";
            this.ModifyUserActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ModifyUserActiveCheckBox.TabIndex = 10;
            this.ModifyUserActiveCheckBox.Text = "Active";
            this.ModifyUserActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModifyUserPasswordTextBox
            // 
            this.ModifyUserPasswordTextBox.Location = new System.Drawing.Point(106, 129);
            this.ModifyUserPasswordTextBox.Name = "ModifyUserPasswordTextBox";
            this.ModifyUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyUserPasswordTextBox.TabIndex = 9;
            this.ModifyUserPasswordTextBox.TextChanged += new System.EventHandler(this.ModifyUserPasswordTextBox_TextChanged);
            // 
            // ModifyUserUserNameTextBox
            // 
            this.ModifyUserUserNameTextBox.Location = new System.Drawing.Point(106, 70);
            this.ModifyUserUserNameTextBox.Name = "ModifyUserUserNameTextBox";
            this.ModifyUserUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModifyUserUserNameTextBox.TabIndex = 8;
            this.ModifyUserUserNameTextBox.TextChanged += new System.EventHandler(this.ModifyUserUserNameTextBox_TextChanged);
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 319);
            this.Controls.Add(this.ModifyUserCancelButton);
            this.Controls.Add(this.ModifyUserSaveButton);
            this.Controls.Add(this.ModifyUserPasswordLabel);
            this.Controls.Add(this.ModifyUserUserNameLabel);
            this.Controls.Add(this.ModifyUserActiveCheckBox);
            this.Controls.Add(this.ModifyUserPasswordTextBox);
            this.Controls.Add(this.ModifyUserUserNameTextBox);
            this.Controls.Add(this.ModifyUserFormLabel);
            this.Name = "ModifyUserForm";
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyUserFormLabel;
        private System.Windows.Forms.Button ModifyUserCancelButton;
        private System.Windows.Forms.Button ModifyUserSaveButton;
        private System.Windows.Forms.Label ModifyUserPasswordLabel;
        private System.Windows.Forms.Label ModifyUserUserNameLabel;
        private System.Windows.Forms.CheckBox ModifyUserActiveCheckBox;
        private System.Windows.Forms.TextBox ModifyUserPasswordTextBox;
        private System.Windows.Forms.TextBox ModifyUserUserNameTextBox;
    }
}