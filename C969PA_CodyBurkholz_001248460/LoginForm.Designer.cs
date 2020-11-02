namespace C969PA_CodyBurkholz_001248460
{
    partial class LoginForm
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
            this.LoginFormLabel = new System.Windows.Forms.Label();
            this.LoginUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginUserNameLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginLogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginFormLabel
            // 
            this.LoginFormLabel.AutoSize = true;
            this.LoginFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormLabel.Location = new System.Drawing.Point(13, 13);
            this.LoginFormLabel.Name = "LoginFormLabel";
            this.LoginFormLabel.Size = new System.Drawing.Size(54, 20);
            this.LoginFormLabel.TabIndex = 1;
            this.LoginFormLabel.Text = "Log In";
            // 
            // LoginUserNameTextBox
            // 
            this.LoginUserNameTextBox.Location = new System.Drawing.Point(99, 82);
            this.LoginUserNameTextBox.Name = "LoginUserNameTextBox";
            this.LoginUserNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.LoginUserNameTextBox.TabIndex = 2;
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(99, 137);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(130, 20);
            this.LoginPasswordTextBox.TabIndex = 3;
            this.LoginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginUserNameLabel
            // 
            this.LoginUserNameLabel.AutoSize = true;
            this.LoginUserNameLabel.Location = new System.Drawing.Point(96, 66);
            this.LoginUserNameLabel.Name = "LoginUserNameLabel";
            this.LoginUserNameLabel.Size = new System.Drawing.Size(60, 13);
            this.LoginUserNameLabel.TabIndex = 4;
            this.LoginUserNameLabel.Text = "User Name";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Location = new System.Drawing.Point(96, 121);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.LoginPasswordLabel.TabIndex = 5;
            this.LoginPasswordLabel.Text = "Password";
            // 
            // LoginLogInButton
            // 
            this.LoginLogInButton.Location = new System.Drawing.Point(99, 199);
            this.LoginLogInButton.Name = "LoginLogInButton";
            this.LoginLogInButton.Size = new System.Drawing.Size(130, 23);
            this.LoginLogInButton.TabIndex = 4;
            this.LoginLogInButton.Text = "Log In";
            this.LoginLogInButton.UseVisualStyleBackColor = true;
            this.LoginLogInButton.Click += new System.EventHandler(this.LoginLogInButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginLogInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 286);
            this.Controls.Add(this.LoginLogInButton);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginUserNameLabel);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.LoginUserNameTextBox);
            this.Controls.Add(this.LoginFormLabel);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LoginFormLabel;
        private System.Windows.Forms.TextBox LoginUserNameTextBox;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Label LoginUserNameLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.Button LoginLogInButton;
    }
}