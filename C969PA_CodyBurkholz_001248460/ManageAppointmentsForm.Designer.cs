namespace C969PA_CodyBurkholz_001248460
{
    partial class ManageAppointmentsForm
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
            this.ManageAppointmentsFormLabel = new System.Windows.Forms.Label();
            this.ManageAppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u06vbiDataSet = new C969PA_CodyBurkholz_001248460.U06vbiDataSet();
            this.appointmentTableAdapter = new C969PA_CodyBurkholz_001248460.U06vbiDataSetTableAdapters.appointmentTableAdapter();
            this.ManageAppointmentsDeleteButton = new System.Windows.Forms.Button();
            this.ManageAppointmentsModifyButton = new System.Windows.Forms.Button();
            this.ManageAppointmentsAddButton = new System.Windows.Forms.Button();
            this.ManageAppointmentsCancelButton = new System.Windows.Forms.Button();
            this.ManageAppointmentsViewCalendarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManageAppointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageAppointmentsFormLabel
            // 
            this.ManageAppointmentsFormLabel.AutoSize = true;
            this.ManageAppointmentsFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAppointmentsFormLabel.Location = new System.Drawing.Point(13, 13);
            this.ManageAppointmentsFormLabel.Name = "ManageAppointmentsFormLabel";
            this.ManageAppointmentsFormLabel.Size = new System.Drawing.Size(170, 20);
            this.ManageAppointmentsFormLabel.TabIndex = 0;
            this.ManageAppointmentsFormLabel.Text = "Manage Appointments";
            // 
            // ManageAppointmentsDataGridView
            // 
            this.ManageAppointmentsDataGridView.AllowUserToAddRows = false;
            this.ManageAppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.ManageAppointmentsDataGridView.AutoGenerateColumns = false;
            this.ManageAppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageAppointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn});
            this.ManageAppointmentsDataGridView.DataSource = this.appointmentBindingSource;
            this.ManageAppointmentsDataGridView.Location = new System.Drawing.Point(17, 51);
            this.ManageAppointmentsDataGridView.MultiSelect = false;
            this.ManageAppointmentsDataGridView.Name = "ManageAppointmentsDataGridView";
            this.ManageAppointmentsDataGridView.ReadOnly = true;
            this.ManageAppointmentsDataGridView.RowHeadersVisible = false;
            this.ManageAppointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageAppointmentsDataGridView.Size = new System.Drawing.Size(904, 284);
            this.ManageAppointmentsDataGridView.TabIndex = 1;
            this.ManageAppointmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageAppointmentsDataGridView_CellClick);
            this.ManageAppointmentsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ManageAppointmentsDataGridView_DataBindingComplete);
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            this.appointmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.u06vbiDataSet;
            // 
            // u06vbiDataSet
            // 
            this.u06vbiDataSet.DataSetName = "U06vbiDataSet";
            this.u06vbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // ManageAppointmentsDeleteButton
            // 
            this.ManageAppointmentsDeleteButton.Location = new System.Drawing.Point(846, 341);
            this.ManageAppointmentsDeleteButton.Name = "ManageAppointmentsDeleteButton";
            this.ManageAppointmentsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAppointmentsDeleteButton.TabIndex = 2;
            this.ManageAppointmentsDeleteButton.Text = "Delete";
            this.ManageAppointmentsDeleteButton.UseVisualStyleBackColor = true;
            this.ManageAppointmentsDeleteButton.Click += new System.EventHandler(this.ManageAppointmentsDeleteButton_Click);
            // 
            // ManageAppointmentsModifyButton
            // 
            this.ManageAppointmentsModifyButton.Location = new System.Drawing.Point(765, 341);
            this.ManageAppointmentsModifyButton.Name = "ManageAppointmentsModifyButton";
            this.ManageAppointmentsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAppointmentsModifyButton.TabIndex = 3;
            this.ManageAppointmentsModifyButton.Text = "Modify";
            this.ManageAppointmentsModifyButton.UseVisualStyleBackColor = true;
            this.ManageAppointmentsModifyButton.Click += new System.EventHandler(this.ManageAppointmentsModifyButton_Click);
            // 
            // ManageAppointmentsAddButton
            // 
            this.ManageAppointmentsAddButton.Location = new System.Drawing.Point(684, 341);
            this.ManageAppointmentsAddButton.Name = "ManageAppointmentsAddButton";
            this.ManageAppointmentsAddButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAppointmentsAddButton.TabIndex = 4;
            this.ManageAppointmentsAddButton.Text = "Add";
            this.ManageAppointmentsAddButton.UseVisualStyleBackColor = true;
            this.ManageAppointmentsAddButton.Click += new System.EventHandler(this.ManageAppointmentsAddButton_Click);
            // 
            // ManageAppointmentsCancelButton
            // 
            this.ManageAppointmentsCancelButton.Location = new System.Drawing.Point(846, 415);
            this.ManageAppointmentsCancelButton.Name = "ManageAppointmentsCancelButton";
            this.ManageAppointmentsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ManageAppointmentsCancelButton.TabIndex = 5;
            this.ManageAppointmentsCancelButton.Text = "Cancel";
            this.ManageAppointmentsCancelButton.UseVisualStyleBackColor = true;
            this.ManageAppointmentsCancelButton.Click += new System.EventHandler(this.ManageAppointmentsCancelButton_Click);
            // 
            // ManageAppointmentsViewCalendarButton
            // 
            this.ManageAppointmentsViewCalendarButton.Location = new System.Drawing.Point(684, 415);
            this.ManageAppointmentsViewCalendarButton.Name = "ManageAppointmentsViewCalendarButton";
            this.ManageAppointmentsViewCalendarButton.Size = new System.Drawing.Size(156, 23);
            this.ManageAppointmentsViewCalendarButton.TabIndex = 6;
            this.ManageAppointmentsViewCalendarButton.Text = "View Calendar";
            this.ManageAppointmentsViewCalendarButton.UseVisualStyleBackColor = true;
            this.ManageAppointmentsViewCalendarButton.Click += new System.EventHandler(this.ManageAppointmentsViewCalendarButton_Click);
            // 
            // ManageAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.ManageAppointmentsViewCalendarButton);
            this.Controls.Add(this.ManageAppointmentsCancelButton);
            this.Controls.Add(this.ManageAppointmentsAddButton);
            this.Controls.Add(this.ManageAppointmentsModifyButton);
            this.Controls.Add(this.ManageAppointmentsDeleteButton);
            this.Controls.Add(this.ManageAppointmentsDataGridView);
            this.Controls.Add(this.ManageAppointmentsFormLabel);
            this.Name = "ManageAppointmentsForm";
            this.Text = "Manage Appointments";
            this.Load += new System.EventHandler(this.ManageAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageAppointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u06vbiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageAppointmentsFormLabel;
        private System.Windows.Forms.DataGridView ManageAppointmentsDataGridView;
        private U06vbiDataSet u06vbiDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private U06vbiDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.Button ManageAppointmentsDeleteButton;
        private System.Windows.Forms.Button ManageAppointmentsModifyButton;
        private System.Windows.Forms.Button ManageAppointmentsAddButton;
        private System.Windows.Forms.Button ManageAppointmentsCancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ManageAppointmentsViewCalendarButton;
    }
}