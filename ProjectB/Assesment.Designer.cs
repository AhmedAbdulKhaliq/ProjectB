namespace ProjectB
{
    partial class Assesment
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtWieght = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataAssesment = new System.Windows.Forms.DataGridView();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet5 = new ProjectB.ProjectBDataSet5();
            this.assessmentTableAdapter = new ProjectB.ProjectBDataSet5TableAdapters.AssessmentTableAdapter();
            this.cmdAddAssesment = new System.Windows.Forms.Button();
            this.cmdShow = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAssesment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Wieghtage";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(111, 88);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(226, 20);
            this.txtMarks.TabIndex = 6;
            this.txtMarks.TextChanged += new System.EventHandler(this.txtMarks_TextChanged);
            // 
            // txtWieght
            // 
            this.txtWieght.Location = new System.Drawing.Point(111, 114);
            this.txtWieght.Name = "txtWieght";
            this.txtWieght.Size = new System.Drawing.Size(226, 20);
            this.txtWieght.TabIndex = 7;
            this.txtWieght.TextChanged += new System.EventHandler(this.txtWieght_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(226, 20);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Assesment";
            // 
            // dataAssesment
            // 
            this.dataAssesment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAssesment.AutoGenerateColumns = false;
            this.dataAssesment.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataAssesment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAssesment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataAssesment.DataSource = this.assessmentBindingSource;
            this.dataAssesment.Location = new System.Drawing.Point(362, 62);
            this.dataAssesment.Name = "dataAssesment";
            this.dataAssesment.Size = new System.Drawing.Size(441, 291);
            this.dataAssesment.TabIndex = 10;
            this.dataAssesment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAssesment_CellContentClick);
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // cmdAddAssesment
            // 
            this.cmdAddAssesment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdAddAssesment.Location = new System.Drawing.Point(262, 160);
            this.cmdAddAssesment.Name = "cmdAddAssesment";
            this.cmdAddAssesment.Size = new System.Drawing.Size(75, 29);
            this.cmdAddAssesment.TabIndex = 11;
            this.cmdAddAssesment.Text = "Save";
            this.cmdAddAssesment.UseVisualStyleBackColor = false;
            this.cmdAddAssesment.Click += new System.EventHandler(this.cmdAddAssesment_Click);
            // 
            // cmdShow
            // 
            this.cmdShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdShow.Location = new System.Drawing.Point(140, 160);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 29);
            this.cmdShow.TabIndex = 12;
            this.cmdShow.Text = "Show All";
            this.cmdShow.UseVisualStyleBackColor = false;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.FillWeight = 150F;
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "Marks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.FillWeight = 150F;
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "Wieghtage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
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
            // Assesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.cmdAddAssesment);
            this.Controls.Add(this.dataAssesment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtWieght);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Assesment";
            this.Text = "Assesment";
            this.Load += new System.EventHandler(this.Assesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAssesment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtWieght;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataAssesment;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet5TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Button cmdAddAssesment;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}