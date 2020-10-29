namespace C969PA_CodyBurkholz_001248460
{
    partial class ManageUsersForm
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
            this.components = new System.ComponentModel.Container();
            this.ManageUsersFormLabel = new System.Windows.Forms.Label();
            this.ManageUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.u06vbiDataSet = new C969PA_CodyBurkholz_001248460.U06vbiDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters.userTableAdapter();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageUsersAddButton = new System.Windows.Forms.Button();
            this.ManageUsersModifyButton = new System.Windows.Forms.Button();
            this.ManageUsersDeleteButton = new System.Windows.Forms.Button();
            this.ManageUsersUseSelectedButton = new System.Windows.Forms.Button();
            this.ManageUsersCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUsersFormLabel
            // 
            this.ManageUsersFormLabel.AutoSize = true;
            this.ManageUsersFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ManageUsersFormLabel.Name = "ManageUsersFormLabel";
            this.ManageUsersFormLabel.Size = new System.Drawing.Size(113, 20);
            this.ManageUsersFormLabel.TabIndex = 0;
            this.ManageUsersFormLabel.Text = "Manage Users";
            // 
            // ManageUsersDataGridView
            // 
            this.ManageUsersDataGridView.AllowUserToAddRows = false;
            this.ManageUsersDataGridView.AllowUserToDeleteRows = false;
            this.ManageUsersDataGridView.AutoGenerateColumns = false;
            this.ManageUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.ManageUsersDataGridView.DataSource = this.userBindingSource;
            this.ManageUsersDataGridView.Location = new System.Drawing.Point(17, 55);
            this.ManageUsersDataGridView.MultiSelect = false;
            this.ManageUsersDataGridView.Name = "ManageUsersDataGridView";
            this.ManageUsersDataGridView.ReadOnly = true;
            this.ManageUsersDataGridView.RowHeadersVisible = false;
            this.ManageUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageUsersDataGridView.Size = new System.Drawing.Size(404, 287);
            this.ManageUsersDataGridView.TabIndex = 1;
            this.ManageUsersDataGridView.TabStop = false;
            this.ManageUsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageUsersDataGridView_CellClick);
            this.ManageUsersDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ManageUsersDataGridView_DataBindingComplete);
            // 
            // u06vbiDataSet
            // 
            this.u06vbiDataSet.DataSetName = "U06vbiDataSet";
            this.u06vbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.u06vbiDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageUsersAddButton
            // 
            this.ManageUsersAddButton.Location = new System.Drawing.Point(184, 348);
            this.ManageUsersAddButton.Name = "ManageUsersAddButton";
            this.ManageUsersAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageUsersAddButton.TabIndex = 2;
            this.ManageUsersAddButton.Text = "Add";
            this.ManageUsersAddButton.UseVisualStyleBackColor = true;
            this.ManageUsersAddButton.Click += new System.EventHandler(this.ManageUsersAddButton_Click);
            // 
            // ManageUsersModifyButton
            // 
            this.ManageUsersModifyButton.Location = new System.Drawing.Point(265, 348);
            this.ManageUsersModifyButton.Name = "ManageUsersModifyButton";
            this.ManageUsersModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ManageUsersModifyButton.TabIndex = 3;
            this.ManageUsersModifyButton.Text = "Modify";
            this.ManageUsersModifyButton.UseVisualStyleBackColor = true;
            this.ManageUsersModifyButton.Click += new System.EventHandler(this.ManageUsersModifyButton_Click);
            // 
            // ManageUsersDeleteButton
            // 
            this.ManageUsersDeleteButton.Location = new System.Drawing.Point(346, 348);
            this.ManageUsersDeleteButton.Name = "ManageUsersDeleteButton";
            this.ManageUsersDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ManageUsersDeleteButton.TabIndex = 4;
            this.ManageUsersDeleteButton.Text = "Delete";
            this.ManageUsersDeleteButton.UseVisualStyleBackColor = true;
            this.ManageUsersDeleteButton.Click += new System.EventHandler(this.ManageUsersDeleteButton_Click);
            // 
            // ManageUsersUseSelectedButton
            // 
            this.ManageUsersUseSelectedButton.Location = new System.Drawing.Point(184, 412);
            this.ManageUsersUseSelectedButton.Name = "ManageUsersUseSelectedButton";
            this.ManageUsersUseSelectedButton.Size = new System.Drawing.Size(156, 23);
            this.ManageUsersUseSelectedButton.TabIndex = 5;
            this.ManageUsersUseSelectedButton.Text = "Use Selected User";
            this.ManageUsersUseSelectedButton.UseVisualStyleBackColor = true;
            this.ManageUsersUseSelectedButton.Click += new System.EventHandler(this.ManageUsersUseSelectedButton_Click);
            // 
            // ManageUsersCancelButton
            // 
            this.ManageUsersCancelButton.Location = new System.Drawing.Point(346, 412);
            this.ManageUsersCancelButton.Name = "ManageUsersCancelButton";
            this.ManageUsersCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ManageUsersCancelButton.TabIndex = 6;
            this.ManageUsersCancelButton.Text = "Cancel";
            this.ManageUsersCancelButton.UseVisualStyleBackColor = true;
            this.ManageUsersCancelButton.Click += new System.EventHandler(this.ManageUsersCancelButton_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.ManageUsersCancelButton);
            this.Controls.Add(this.ManageUsersUseSelectedButton);
            this.Controls.Add(this.ManageUsersDeleteButton);
            this.Controls.Add(this.ManageUsersModifyButton);
            this.Controls.Add(this.ManageUsersAddButton);
            this.Controls.Add(this.ManageUsersDataGridView);
            this.Controls.Add(this.ManageUsersFormLabel);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageUsersFormLabel;
        private System.Windows.Forms.DataGridView ManageUsersDataGridView;
        private U06vbiDataSet u06vbiDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private U06vbiDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ManageUsersAddButton;
        private System.Windows.Forms.Button ManageUsersModifyButton;
        private System.Windows.Forms.Button ManageUsersDeleteButton;
        private System.Windows.Forms.Button ManageUsersUseSelectedButton;
        private System.Windows.Forms.Button ManageUsersCancelButton;
    }
}