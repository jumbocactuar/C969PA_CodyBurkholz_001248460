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
            this.BypassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BypassButton
            // 
            this.BypassButton.Location = new System.Drawing.Point(541, 294);
            this.BypassButton.Name = "BypassButton";
            this.BypassButton.Size = new System.Drawing.Size(194, 106);
            this.BypassButton.TabIndex = 0;
            this.BypassButton.Text = "Bypass";
            this.BypassButton.UseVisualStyleBackColor = true;
            this.BypassButton.Click += new System.EventHandler(this.BypassButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BypassButton);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BypassButton;
    }
}