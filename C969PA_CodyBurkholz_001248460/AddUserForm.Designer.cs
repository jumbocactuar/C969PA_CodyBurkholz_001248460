namespace C969PA_CodyBurkholz_001248460
{
    partial class AddUserForm
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
            this.AddUserUserNameTextBox = new System.Windows.Forms.TextBox();
            this.AddUserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddUserActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.AddUserUserNameLabel = new System.Windows.Forms.Label();
            this.AddUserPasswordLabel = new System.Windows.Forms.Label();
            this.AddUserSaveButton = new System.Windows.Forms.Button();
            this.AddUserCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            // 
            // AddUserUserNameTextBox
            // 
            this.AddUserUserNameTextBox.Location = new System.Drawing.Point(107, 67);
            this.AddUserUserNameTextBox.Name = "AddUserUserNameTextBox";
            this.AddUserUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUserUserNameTextBox.TabIndex = 1;
            this.AddUserUserNameTextBox.TextChanged += new System.EventHandler(this.AddUserUserNameTextBox_TextChanged);
            // 
            // AddUserPasswordTextBox
            // 
            this.AddUserPasswordTextBox.Location = new System.Drawing.Point(107, 126);
            this.AddUserPasswordTextBox.Name = "AddUserPasswordTextBox";
            this.AddUserPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddUserPasswordTextBox.TabIndex = 2;
            this.AddUserPasswordTextBox.TextChanged += new System.EventHandler(this.AddUserPasswordTextBox_TextChanged);
            // 
            // AddUserActiveCheckBox
            // 
            this.AddUserActiveCheckBox.AutoSize = true;
            this.AddUserActiveCheckBox.Location = new System.Drawing.Point(107, 187);
            this.AddUserActiveCheckBox.Name = "AddUserActiveCheckBox";
            this.AddUserActiveCheckBox.Size = new System.Drawing.Size(56, 17);
            this.AddUserActiveCheckBox.TabIndex = 3;
            this.AddUserActiveCheckBox.Text = "Active";
            this.AddUserActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddUserUserNameLabel
            // 
            this.AddUserUserNameLabel.AutoSize = true;
            this.AddUserUserNameLabel.Location = new System.Drawing.Point(41, 70);
            this.AddUserUserNameLabel.Name = "AddUserUserNameLabel";
            this.AddUserUserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.AddUserUserNameLabel.TabIndex = 4;
            this.AddUserUserNameLabel.Text = "User Name";
            // 
            // AddUserPasswordLabel
            // 
            this.AddUserPasswordLabel.AutoSize = true;
            this.AddUserPasswordLabel.Location = new System.Drawing.Point(48, 129);
            this.AddUserPasswordLabel.Name = "AddUserPasswordLabel";
            this.AddUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.AddUserPasswordLabel.TabIndex = 5;
            this.AddUserPasswordLabel.Text = "Password";
            // 
            // AddUserSaveButton
            // 
            this.AddUserSaveButton.Location = new System.Drawing.Point(51, 260);
            this.AddUserSaveButton.Name = "AddUserSaveButton";
            this.AddUserSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserSaveButton.TabIndex = 6;
            this.AddUserSaveButton.Text = "Save";
            this.AddUserSaveButton.UseVisualStyleBackColor = true;
            this.AddUserSaveButton.Click += new System.EventHandler(this.AddUserSaveButton_Click);
            // 
            // AddUserCancelButton
            // 
            this.AddUserCancelButton.Location = new System.Drawing.Point(132, 260);
            this.AddUserCancelButton.Name = "AddUserCancelButton";
            this.AddUserCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserCancelButton.TabIndex = 7;
            this.AddUserCancelButton.Text = "Cancel";
            this.AddUserCancelButton.UseVisualStyleBackColor = true;
            this.AddUserCancelButton.Click += new System.EventHandler(this.AddUserCancelButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 319);
            this.Controls.Add(this.AddUserCancelButton);
            this.Controls.Add(this.AddUserSaveButton);
            this.Controls.Add(this.AddUserPasswordLabel);
            this.Controls.Add(this.AddUserUserNameLabel);
            this.Controls.Add(this.AddUserActiveCheckBox);
            this.Controls.Add(this.AddUserPasswordTextBox);
            this.Controls.Add(this.AddUserUserNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddUserUserNameTextBox;
        private System.Windows.Forms.TextBox AddUserPasswordTextBox;
        private System.Windows.Forms.CheckBox AddUserActiveCheckBox;
        private System.Windows.Forms.Label AddUserUserNameLabel;
        private System.Windows.Forms.Label AddUserPasswordLabel;
        private System.Windows.Forms.Button AddUserSaveButton;
        private System.Windows.Forms.Button AddUserCancelButton;
    }
}