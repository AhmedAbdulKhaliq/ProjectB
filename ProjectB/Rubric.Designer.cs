namespace ProjectB
{
    partial class Rubric
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
            this.ShowRubric = new System.Windows.Forms.TabControl();
            this.AddRubric = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCloNo = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtRubricId = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.dataRubric = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet3 = new ProjectB.ProjectBDataSet3();
            this.RubricLevel = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet4 = new ProjectB.ProjectBDataSet4();
            this.cmdAddLevel = new System.Windows.Forms.Button();
            this.cmbRubricID = new System.Windows.Forms.ComboBox();
            this.txtRubricLevel = new System.Windows.Forms.TextBox();
            this.txtDetRubric = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rubricTableAdapter = new ProjectB.ProjectBDataSet3TableAdapters.RubricTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.rubricLevelTableAdapter = new ProjectB.ProjectBDataSet4TableAdapters.RubricLevelTableAdapter();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdShowRubricLevel = new System.Windows.Forms.Button();
            this.ShowRubric.SuspendLayout();
            this.AddRubric.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRubric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            this.RubricLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowRubric
            // 
            this.ShowRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowRubric.Controls.Add(this.AddRubric);
            this.ShowRubric.Controls.Add(this.tab2);
            this.ShowRubric.Controls.Add(this.RubricLevel);
            this.ShowRubric.Location = new System.Drawing.Point(2, 35);
            this.ShowRubric.Name = "ShowRubric";
            this.ShowRubric.SelectedIndex = 0;
            this.ShowRubric.Size = new System.Drawing.Size(807, 304);
            this.ShowRubric.TabIndex = 0;
            this.ShowRubric.Tag = "";
            // 
            // AddRubric
            // 
            this.AddRubric.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddRubric.Controls.Add(this.button1);
            this.AddRubric.Controls.Add(this.label3);
            this.AddRubric.Controls.Add(this.label2);
            this.AddRubric.Controls.Add(this.label1);
            this.AddRubric.Controls.Add(this.comboCloNo);
            this.AddRubric.Controls.Add(this.txtDetails);
            this.AddRubric.Controls.Add(this.txtRubricId);
            this.AddRubric.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddRubric.Location = new System.Drawing.Point(4, 22);
            this.AddRubric.Name = "AddRubric";
            this.AddRubric.Padding = new System.Windows.Forms.Padding(3);
            this.AddRubric.Size = new System.Drawing.Size(799, 278);
            this.AddRubric.TabIndex = 0;
            this.AddRubric.Text = "Add Rubric";
            this.AddRubric.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(224, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Rubric";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clo no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rubric";
            // 
            // comboCloNo
            // 
            this.comboCloNo.FormattingEnabled = true;
            this.comboCloNo.Location = new System.Drawing.Point(103, 53);
            this.comboCloNo.Name = "comboCloNo";
            this.comboCloNo.Size = new System.Drawing.Size(196, 21);
            this.comboCloNo.TabIndex = 3;
            this.comboCloNo.SelectedIndexChanged += new System.EventHandler(this.comboCloNo_SelectedIndexChanged);
            this.comboCloNo.Click += new System.EventHandler(this.comboCloNo_Click);
            this.comboCloNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboCloNo_MouseClick);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(103, 80);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(196, 20);
            this.txtDetails.TabIndex = 2;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // txtRubricId
            // 
            this.txtRubricId.Location = new System.Drawing.Point(103, 27);
            this.txtRubricId.Name = "txtRubricId";
            this.txtRubricId.Size = new System.Drawing.Size(196, 20);
            this.txtRubricId.TabIndex = 0;
            this.txtRubricId.TextChanged += new System.EventHandler(this.txtRubricId_TextChanged);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.DarkGray;
            this.tab2.Controls.Add(this.cmdShow);
            this.tab2.Controls.Add(this.dataRubric);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(799, 278);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Show Rubric";
            // 
            // dataRubric
            // 
            this.dataRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRubric.AutoGenerateColumns = false;
            this.dataRubric.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Delete,
            this.Edit});
            this.dataRubric.DataSource = this.rubricBindingSource;
            this.dataRubric.Location = new System.Drawing.Point(6, 35);
            this.dataRubric.Name = "dataRubric";
            this.dataRubric.Size = new System.Drawing.Size(787, 237);
            this.dataRubric.TabIndex = 0;
            this.dataRubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRubric_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.DataPropertyName = "(none)";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.DataPropertyName = "(none)";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet3;
            // 
            // projectBDataSet3
            // 
            this.projectBDataSet3.DataSetName = "ProjectBDataSet3";
            this.projectBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RubricLevel
            // 
            this.RubricLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RubricLevel.Controls.Add(this.cmdShowRubricLevel);
            this.RubricLevel.Controls.Add(this.dataGridView1);
            this.RubricLevel.Controls.Add(this.cmdAddLevel);
            this.RubricLevel.Controls.Add(this.cmbRubricID);
            this.RubricLevel.Controls.Add(this.txtRubricLevel);
            this.RubricLevel.Controls.Add(this.txtDetRubric);
            this.RubricLevel.Controls.Add(this.label8);
            this.RubricLevel.Controls.Add(this.label7);
            this.RubricLevel.Controls.Add(this.label6);
            this.RubricLevel.Location = new System.Drawing.Point(4, 22);
            this.RubricLevel.Name = "RubricLevel";
            this.RubricLevel.Padding = new System.Windows.Forms.Padding(3);
            this.RubricLevel.Size = new System.Drawing.Size(799, 278);
            this.RubricLevel.TabIndex = 2;
            this.RubricLevel.Text = "Add Level";
            this.RubricLevel.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn1,
            this.measurementLevelDataGridViewTextBoxColumn,
            this.Remove,
            this.Editt});
            this.dataGridView1.DataSource = this.rubricLevelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(339, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn1
            // 
            this.detailsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsDataGridViewTextBoxColumn1.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn1.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn1.Name = "detailsDataGridViewTextBoxColumn1";
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.ToolTipText = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // Editt
            // 
            this.Editt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Editt.HeaderText = "Edit";
            this.Editt.Name = "Editt";
            this.Editt.ReadOnly = true;
            this.Editt.Text = "Edit";
            this.Editt.ToolTipText = "Edit";
            this.Editt.UseColumnTextForButtonValue = true;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet4;
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdAddLevel
            // 
            this.cmdAddLevel.Location = new System.Drawing.Point(245, 105);
            this.cmdAddLevel.Name = "cmdAddLevel";
            this.cmdAddLevel.Size = new System.Drawing.Size(75, 31);
            this.cmdAddLevel.TabIndex = 19;
            this.cmdAddLevel.Text = "Add";
            this.cmdAddLevel.UseVisualStyleBackColor = true;
            this.cmdAddLevel.Click += new System.EventHandler(this.cmdAddLevel_Click);
            // 
            // cmbRubricID
            // 
            this.cmbRubricID.FormattingEnabled = true;
            this.cmbRubricID.Location = new System.Drawing.Point(140, 16);
            this.cmbRubricID.Name = "cmbRubricID";
            this.cmbRubricID.Size = new System.Drawing.Size(180, 21);
            this.cmbRubricID.TabIndex = 8;
            this.cmbRubricID.Click += new System.EventHandler(this.cmbRubricID_Click);
            // 
            // txtRubricLevel
            // 
            this.txtRubricLevel.Location = new System.Drawing.Point(140, 69);
            this.txtRubricLevel.Name = "txtRubricLevel";
            this.txtRubricLevel.Size = new System.Drawing.Size(180, 20);
            this.txtRubricLevel.TabIndex = 6;
            this.txtRubricLevel.TextChanged += new System.EventHandler(this.txtRubricLevel_TextChanged);
            // 
            // txtDetRubric
            // 
            this.txtDetRubric.Location = new System.Drawing.Point(140, 43);
            this.txtDetRubric.Name = "txtDetRubric";
            this.txtDetRubric.Size = new System.Drawing.Size(180, 20);
            this.txtDetRubric.TabIndex = 5;
            this.txtDetRubric.TextChanged += new System.EventHandler(this.txtDetRubric_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rubric Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rubric Id";
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(285, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rubric Form";
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(283, 6);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(92, 23);
            this.cmdShow.TabIndex = 1;
            this.cmdShow.Text = "Show All";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdShowRubricLevel
            // 
            this.cmdShowRubricLevel.Location = new System.Drawing.Point(103, 105);
            this.cmdShowRubricLevel.Name = "cmdShowRubricLevel";
            this.cmdShowRubricLevel.Size = new System.Drawing.Size(75, 31);
            this.cmdShowRubricLevel.TabIndex = 21;
            this.cmdShowRubricLevel.Text = "Show All";
            this.cmdShowRubricLevel.UseVisualStyleBackColor = true;
            this.cmdShowRubricLevel.Click += new System.EventHandler(this.cmdShowRubricLevel_Click);
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowRubric);
            this.Name = "Rubric";
            this.Text = "Rubric";
            this.Load += new System.EventHandler(this.Rubric_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Rubric_MouseClick);
            this.ShowRubric.ResumeLayout(false);
            this.AddRubric.ResumeLayout(false);
            this.AddRubric.PerformLayout();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRubric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            this.RubricLevel.ResumeLayout(false);
            this.RubricLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ShowRubric;
        private System.Windows.Forms.TabPage AddRubric;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtRubricId;
        private System.Windows.Forms.DataGridView dataRubric;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet3TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.TabPage RubricLevel;
        private System.Windows.Forms.ComboBox cmbRubricID;
        private System.Windows.Forms.TextBox txtRubricLevel;
        private System.Windows.Forms.TextBox txtDetRubric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdAddLevel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSet4TableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewButtonColumn Editt;
        public System.Windows.Forms.ComboBox comboCloNo;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdShowRubricLevel;
    }
}