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
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModifyUserFormLabel);
            this.Name = "ModifyUserForm";
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.ModifyUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyUserFormLabel;
    }
}