namespace C969PA_CodyBurkholz_001248460
{
    partial class ManageAddressesForm
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
            this.ManageAddressesFormLabel = new System.Windows.Forms.Label();
            this.ManageAddressesDataGridView = new System.Windows.Forms.DataGridView();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u06vbiDataSet = new C969PA_CodyBurkholz_001248460.U06vbiDataSet();
            this.addressTableAdapter = new C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters.addressTableAdapter();
            this.ManageAddressesAddButton = new System.Windows.Forms.Button();
            this.ManageAddressesModifyButton = new System.Windows.Forms.Button();
            this.ManageAddressesDeleteButton = new System.Windows.Forms.Button();
            this.ManageAddressesUseSelectedButton = new System.Windows.Forms.Button();
            this.ManageAddressesCancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManageAddressesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageAddressesFormLabel
            // 
            this.ManageAddressesFormLabel.AutoSize = true;
            this.ManageAddressesFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAddressesFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ManageAddressesFormLabel.Name = "ManageAddressesFormLabel";
            this.ManageAddressesFormLabel.Size = new System.Drawing.Size(147, 20);
            this.ManageAddressesFormLabel.TabIndex = 0;
            this.ManageAddressesFormLabel.Text = "Manage Addresses";
            // 
            // ManageAddressesDataGridView
            // 
            this.ManageAddressesDataGridView.AllowUserToAddRows = false;
            this.ManageAddressesDataGridView.AllowUserToDeleteRows = false;
            this.ManageAddressesDataGridView.AutoGenerateColumns = false;
            this.ManageAddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageAddressesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIdDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.ManageAddressesDataGridView.DataSource = this.addressBindingSource;
            this.ManageAddressesDataGridView.Location = new System.Drawing.Point(17, 53);
            this.ManageAddressesDataGridView.MultiSelect = false;
            this.ManageAddressesDataGridView.Name = "ManageAddressesDataGridView";
            this.ManageAddressesDataGridView.ReadOnly = true;
            this.ManageAddressesDataGridView.RowHeadersWidth = 50;
            this.ManageAddressesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageAddressesDataGridView.Size = new System.Drawing.Size(759, 253);
            this.ManageAddressesDataGridView.TabIndex = 1;
            this.ManageAddressesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageAddressesDataGridView_CellClick);
            this.ManageAddressesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ManageAddressesDataGridView_DataBindingComplete);
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "addressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "addressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            this.addressIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            this.address2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "cityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "cityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.u06vbiDataSet;
            // 
            // u06vbiDataSet
            // 
            this.u06vbiDataSet.DataSetName = "U06vbiDataSet";
            this.u06vbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAddressesAddButton
            // 
            this.ManageAddressesAddButton.Location = new System.Drawing.Point(539, 312);
            this.ManageAddressesAddButton.Name = "ManageAddressesAddButton";
            this.ManageAddressesAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAddressesAddButton.TabIndex = 2;
            this.ManageAddressesAddButton.Text = "Add";
            this.ManageAddressesAddButton.UseVisualStyleBackColor = true;
            this.ManageAddressesAddButton.Click += new System.EventHandler(this.ManageAddressesAddButton_Click);
            // 
            // ManageAddressesModifyButton
            // 
            this.ManageAddressesModifyButton.Location = new System.Drawing.Point(620, 312);
            this.ManageAddressesModifyButton.Name = "ManageAddressesModifyButton";
            this.ManageAddressesModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAddressesModifyButton.TabIndex = 3;
            this.ManageAddressesModifyButton.Text = "Modify";
            this.ManageAddressesModifyButton.UseVisualStyleBackColor = true;
            this.ManageAddressesModifyButton.Click += new System.EventHandler(this.ManageAddressesModifyButton_Click);
            // 
            // ManageAddressesDeleteButton
            // 
            this.ManageAddressesDeleteButton.Location = new System.Drawing.Point(701, 312);
            this.ManageAddressesDeleteButton.Name = "ManageAddressesDeleteButton";
            this.ManageAddressesDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAddressesDeleteButton.TabIndex = 4;
            this.ManageAddressesDeleteButton.Text = "Delete";
            this.ManageAddressesDeleteButton.UseVisualStyleBackColor = true;
            this.ManageAddressesDeleteButton.Click += new System.EventHandler(this.ManageAddressesDeleteButton_Click);
            // 
            // ManageAddressesUseSelectedButton
            // 
            this.ManageAddressesUseSelectedButton.Location = new System.Drawing.Point(560, 387);
            this.ManageAddressesUseSelectedButton.Name = "ManageAddressesUseSelectedButton";
            this.ManageAddressesUseSelectedButton.Size = new System.Drawing.Size(135, 23);
            this.ManageAddressesUseSelectedButton.TabIndex = 5;
            this.ManageAddressesUseSelectedButton.Text = "Use Selected Address";
            this.ManageAddressesUseSelectedButton.UseVisualStyleBackColor = true;
            this.ManageAddressesUseSelectedButton.Click += new System.EventHandler(this.ManageAddressesUseSelectedButton_Click);
            // 
            // ManageAddressesCancelButton
            // 
            this.ManageAddressesCancelButton.Location = new System.Drawing.Point(701, 387);
            this.ManageAddressesCancelButton.Name = "ManageAddressesCancelButton";
            this.ManageAddressesCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAddressesCancelButton.TabIndex = 6;
            this.ManageAddressesCancelButton.Text = "Cancel";
            this.ManageAddressesCancelButton.UseVisualStyleBackColor = true;
            this.ManageAddressesCancelButton.Click += new System.EventHandler(this.ManageAddressesCancelButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ManageAddressesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ManageAddressesCancelButton);
            this.Controls.Add(this.ManageAddressesUseSelectedButton);
            this.Controls.Add(this.ManageAddressesDeleteButton);
            this.Controls.Add(this.ManageAddressesModifyButton);
            this.Controls.Add(this.ManageAddressesAddButton);
            this.Controls.Add(this.ManageAddressesDataGridView);
            this.Controls.Add(this.ManageAddressesFormLabel);
            this.Name = "ManageAddressesForm";
            this.Text = "Manage Addresses";
            this.Load += new System.EventHandler(this.ManageAddresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageAddressesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageAddressesFormLabel;
        private System.Windows.Forms.DataGridView ManageAddressesDataGridView;
        private U06vbiDataSet u06vbiDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private U06vbiDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ManageAddressesAddButton;
        private System.Windows.Forms.Button ManageAddressesModifyButton;
        private System.Windows.Forms.Button ManageAddressesDeleteButton;
        private System.Windows.Forms.Button ManageAddressesUseSelectedButton;
        private System.Windows.Forms.Button ManageAddressesCancelButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}