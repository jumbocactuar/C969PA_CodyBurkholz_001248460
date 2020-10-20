namespace C969PA_CodyBurkholz_001248460
{
    partial class ManageCustomerForm
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
            this.u06vbiDataSet = new C969PA_CodyBurkholz_001248460.U06vbiDataSet();
            this.ManageCustomerFormLabel = new System.Windows.Forms.Label();
            this.ManageCustomerAddButton = new System.Windows.Forms.Button();
            this.ManageCustomerModifyButton = new System.Windows.Forms.Button();
            this.ManageCustomerDeleteButton = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManageCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerTableAdapter = new C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters.customerTableAdapter();
            this.ManageCustomerCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageCustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // u06vbiDataSet
            // 
            this.u06vbiDataSet.DataSetName = "U06vbiDataSet";
            this.u06vbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManageCustomerFormLabel
            // 
            this.ManageCustomerFormLabel.AutoSize = true;
            this.ManageCustomerFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCustomerFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ManageCustomerFormLabel.Name = "ManageCustomerFormLabel";
            this.ManageCustomerFormLabel.Size = new System.Drawing.Size(148, 20);
            this.ManageCustomerFormLabel.TabIndex = 1;
            this.ManageCustomerFormLabel.Text = "Manage Customers";
            // 
            // ManageCustomerAddButton
            // 
            this.ManageCustomerAddButton.Location = new System.Drawing.Point(83, 454);
            this.ManageCustomerAddButton.Name = "ManageCustomerAddButton";
            this.ManageCustomerAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCustomerAddButton.TabIndex = 2;
            this.ManageCustomerAddButton.Text = "Add";
            this.ManageCustomerAddButton.UseVisualStyleBackColor = true;
            this.ManageCustomerAddButton.Click += new System.EventHandler(this.ManageCustomerAddButton_Click);
            // 
            // ManageCustomerModifyButton
            // 
            this.ManageCustomerModifyButton.Location = new System.Drawing.Point(164, 454);
            this.ManageCustomerModifyButton.Name = "ManageCustomerModifyButton";
            this.ManageCustomerModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCustomerModifyButton.TabIndex = 3;
            this.ManageCustomerModifyButton.Text = "Modify";
            this.ManageCustomerModifyButton.UseVisualStyleBackColor = true;
            this.ManageCustomerModifyButton.Click += new System.EventHandler(this.ManageCustomerModifyButton_Click);
            // 
            // ManageCustomerDeleteButton
            // 
            this.ManageCustomerDeleteButton.Location = new System.Drawing.Point(245, 454);
            this.ManageCustomerDeleteButton.Name = "ManageCustomerDeleteButton";
            this.ManageCustomerDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCustomerDeleteButton.TabIndex = 4;
            this.ManageCustomerDeleteButton.Text = "Delete";
            this.ManageCustomerDeleteButton.UseVisualStyleBackColor = true;
            this.ManageCustomerDeleteButton.Click += new System.EventHandler(this.ManageCustomerDeleteButton_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u06vbiDataSet;
            // 
            // ManageCustomerDataGridView
            // 
            this.ManageCustomerDataGridView.AllowUserToAddRows = false;
            this.ManageCustomerDataGridView.AllowUserToDeleteRows = false;
            this.ManageCustomerDataGridView.AutoGenerateColumns = false;
            this.ManageCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageCustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.ManageCustomerDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ManageCustomerDataGridView.DataSource = this.customerBindingSource;
            this.ManageCustomerDataGridView.Location = new System.Drawing.Point(17, 61);
            this.ManageCustomerDataGridView.Name = "ManageCustomerDataGridView";
            this.ManageCustomerDataGridView.ReadOnly = true;
            this.ManageCustomerDataGridView.RowHeadersVisible = false;
            this.ManageCustomerDataGridView.RowHeadersWidth = 50;
            this.ManageCustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageCustomerDataGridView.ShowEditingIcon = false;
            this.ManageCustomerDataGridView.Size = new System.Drawing.Size(303, 387);
            this.ManageCustomerDataGridView.TabIndex = 5;
            this.ManageCustomerDataGridView.TabStop = false;
            this.ManageCustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageCustomerDataGridView_CellClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCustomerCancelButton
            // 
            this.ManageCustomerCancelButton.Location = new System.Drawing.Point(245, 505);
            this.ManageCustomerCancelButton.Name = "ManageCustomerCancelButton";
            this.ManageCustomerCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ManageCustomerCancelButton.TabIndex = 6;
            this.ManageCustomerCancelButton.Text = "Cancel";
            this.ManageCustomerCancelButton.UseVisualStyleBackColor = true;
            this.ManageCustomerCancelButton.Click += new System.EventHandler(this.ManageCustomerCancelButton_Click);
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 549);
            this.Controls.Add(this.ManageCustomerCancelButton);
            this.Controls.Add(this.ManageCustomerDataGridView);
            this.Controls.Add(this.ManageCustomerDeleteButton);
            this.Controls.Add(this.ManageCustomerModifyButton);
            this.Controls.Add(this.ManageCustomerAddButton);
            this.Controls.Add(this.ManageCustomerFormLabel);
            this.Name = "ManageCustomerForm";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.ManageCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageCustomerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ManageCustomerFormLabel;
        private System.Windows.Forms.Button ManageCustomerAddButton;
        private System.Windows.Forms.Button ManageCustomerModifyButton;
        private System.Windows.Forms.Button ManageCustomerDeleteButton;
        private U06vbiDataSet u06vbiDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView ManageCustomerDataGridView;
        private U06vbiDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button ManageCustomerCancelButton;
    }
}

