namespace ProjectB
{
    partial class StudentAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAttendanceId = new System.Windows.Forms.ComboBox();
            this.cmbStudentId = new System.Windows.Forms.ComboBox();
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.dataStudentAttendance = new System.Windows.Forms.DataGridView();
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new ProjectB.ProjectBDataSet8();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentAttendanceTableAdapter = new ProjectB.ProjectBDataSet8TableAdapters.StudentAttendanceTableAdapter();
            this.cmdShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attendance Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID";
            // 
            // cmbAttendanceId
            // 
            this.cmbAttendanceId.FormattingEnabled = true;
            this.cmbAttendanceId.Location = new System.Drawing.Point(113, 68);
            this.cmbAttendanceId.Name = "cmbAttendanceId";
            this.cmbAttendanceId.Size = new System.Drawing.Size(121, 21);
            this.cmbAttendanceId.TabIndex = 3;
            this.cmbAttendanceId.SelectedIndexChanged += new System.EventHandler(this.cmbAttendanceId_SelectedIndexChanged);
            this.cmbAttendanceId.Click += new System.EventHandler(this.cmbAttendanceId_Click);
            // 
            // cmbStudentId
            // 
            this.cmbStudentId.FormattingEnabled = true;
            this.cmbStudentId.Location = new System.Drawing.Point(113, 95);
            this.cmbStudentId.Name = "cmbStudentId";
            this.cmbStudentId.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentId.TabIndex = 4;
            this.cmbStudentId.Click += new System.EventHandler(this.cmbStudentId_Click);
            // 
            // cmbAttendanceStatus
            // 
            this.cmbAttendanceStatus.FormattingEnabled = true;
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(113, 122);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbAttendanceStatus.TabIndex = 5;
            this.cmbAttendanceStatus.Click += new System.EventHandler(this.cmbAttendanceStatus_Click);
            // 
            // dataStudentAttendance
            // 
            this.dataStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStudentAttendance.AutoGenerateColumns = false;
            this.dataStudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudentAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataStudentAttendance.DataSource = this.studentAttendanceBindingSource;
            this.dataStudentAttendance.Location = new System.Drawing.Point(248, 65);
            this.dataStudentAttendance.Name = "dataStudentAttendance";
            this.dataStudentAttendance.Size = new System.Drawing.Size(444, 202);
            this.dataStudentAttendance.TabIndex = 6;
            this.dataStudentAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudentAttendance_CellContentClick);
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet8;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(145, 164);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 7;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Attendance";
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(48, 164);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 9;
            this.cmdShow.Text = "Show All";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 330);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.dataStudentAttendance);
            this.Controls.Add(this.cmbAttendanceStatus);
            this.Controls.Add(this.cmbStudentId);
            this.Controls.Add(this.cmbAttendanceId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentAttendance";
            this.Text = "StudentAttendance";
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAttendanceId;
        private System.Windows.Forms.ComboBox cmbStudentId;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.DataGridView dataStudentAttendance;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label4;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet8TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button cmdShow;
    }
}