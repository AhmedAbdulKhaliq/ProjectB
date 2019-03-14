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
            this.rubricTableAdapter = new ProjectB.ProjectBDataSet3TableAdapters.RubricTableAdapter();
            this.ShowRubric.SuspendLayout();
            this.AddRubric.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRubric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowRubric
            // 
            this.ShowRubric.Controls.Add(this.AddRubric);
            this.ShowRubric.Controls.Add(this.tab2);
            this.ShowRubric.Location = new System.Drawing.Point(2, 35);
            this.ShowRubric.Name = "ShowRubric";
            this.ShowRubric.SelectedIndex = 0;
            this.ShowRubric.Size = new System.Drawing.Size(656, 304);
            this.ShowRubric.TabIndex = 0;
            this.ShowRubric.Tag = "";
            // 
            // AddRubric
            // 
            this.AddRubric.BackColor = System.Drawing.Color.LightGray;
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
            this.AddRubric.Size = new System.Drawing.Size(648, 278);
            this.AddRubric.TabIndex = 0;
            this.AddRubric.Text = "Add Rubric";
            this.AddRubric.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(283, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.label3.Location = new System.Drawing.Point(34, 127);
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
            this.label2.Location = new System.Drawing.Point(31, 86);
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
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rubric";
            // 
            // comboCloNo
            // 
            this.comboCloNo.FormattingEnabled = true;
            this.comboCloNo.Location = new System.Drawing.Point(144, 79);
            this.comboCloNo.Name = "comboCloNo";
            this.comboCloNo.Size = new System.Drawing.Size(100, 21);
            this.comboCloNo.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(144, 121);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(100, 20);
            this.txtDetails.TabIndex = 2;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // txtRubricId
            // 
            this.txtRubricId.Location = new System.Drawing.Point(144, 27);
            this.txtRubricId.Name = "txtRubricId";
            this.txtRubricId.Size = new System.Drawing.Size(100, 20);
            this.txtRubricId.TabIndex = 0;
            this.txtRubricId.TextChanged += new System.EventHandler(this.txtRubricId_TextChanged);
            // 
            // tab2
            // 
            this.tab2.BackColor = System.Drawing.Color.DarkGray;
            this.tab2.Controls.Add(this.dataRubric);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(648, 278);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Show Rubric";
            // 
            // dataRubric
            // 
            this.dataRubric.AutoGenerateColumns = false;
            this.dataRubric.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Delete,
            this.Edit});
            this.dataRubric.DataSource = this.rubricBindingSource;
            this.dataRubric.Location = new System.Drawing.Point(21, 76);
            this.dataRubric.Name = "dataRubric";
            this.dataRubric.Size = new System.Drawing.Size(587, 202);
            this.dataRubric.TabIndex = 0;
            this.dataRubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRubric_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "(none)";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
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
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 421);
            this.Controls.Add(this.ShowRubric);
            this.Name = "Rubric";
            this.Text = "Rubric";
            this.Load += new System.EventHandler(this.Rubric_Load);
            this.ShowRubric.ResumeLayout(false);
            this.AddRubric.ResumeLayout(false);
            this.AddRubric.PerformLayout();
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRubric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ShowRubric;
        private System.Windows.Forms.TabPage AddRubric;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCloNo;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtRubricId;
        private System.Windows.Forms.DataGridView dataRubric;
        private ProjectBDataSet3 projectBDataSet3;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet3TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}