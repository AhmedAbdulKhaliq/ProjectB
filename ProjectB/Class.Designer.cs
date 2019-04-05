namespace ProjectB
{
    partial class Class
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
            this.dataClass = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet7 = new ProjectB.ProjectBDataSet7();
            this.calenderAttendance = new System.Windows.Forms.MonthCalendar();
            this.classAttendanceTableAdapter = new ProjectB.ProjectBDataSet7TableAdapters.ClassAttendanceTableAdapter();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClass
            // 
            this.dataClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataClass.AutoGenerateColumns = false;
            this.dataClass.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataClass.DataSource = this.classAttendanceBindingSource;
            this.dataClass.Location = new System.Drawing.Point(12, 209);
            this.dataClass.Name = "dataClass";
            this.dataClass.Size = new System.Drawing.Size(726, 169);
            this.dataClass.TabIndex = 1;
            this.dataClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClass_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet7;
            // 
            // projectBDataSet7
            // 
            this.projectBDataSet7.DataSetName = "ProjectBDataSet7";
            this.projectBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calenderAttendance
            // 
            this.calenderAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calenderAttendance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calenderAttendance.Location = new System.Drawing.Point(215, -1);
            this.calenderAttendance.Name = "calenderAttendance";
            this.calenderAttendance.TabIndex = 2;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdAdd.Location = new System.Drawing.Point(206, 173);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 31);
            this.cmdAdd.TabIndex = 3;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = false;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdShow
            // 
            this.cmdShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdShow.Location = new System.Drawing.Point(381, 173);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 31);
            this.cmdShow.TabIndex = 4;
            this.cmdShow.Text = "Show All";
            this.cmdShow.UseVisualStyleBackColor = false;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Attendance";
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.calenderAttendance);
            this.Controls.Add(this.dataClass);
            this.Name = "Class";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataClass;
        private System.Windows.Forms.MonthCalendar calenderAttendance;
        private ProjectBDataSet7 projectBDataSet7;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet7TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Label label1;
    }
}