namespace ProjectB
{
    partial class Reports
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
            this.dataReport = new System.Windows.Forms.DataGridView();
            this.cmdgenerate = new System.Windows.Forms.Button();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReport
            // 
            this.dataReport.AllowUserToAddRows = false;
            this.dataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObtainedMarks});
            this.dataReport.Location = new System.Drawing.Point(12, 104);
            this.dataReport.Name = "dataReport";
            this.dataReport.Size = new System.Drawing.Size(413, 223);
            this.dataReport.TabIndex = 0;
            // 
            // cmdgenerate
            // 
            this.cmdgenerate.Location = new System.Drawing.Point(130, 41);
            this.cmdgenerate.Name = "cmdgenerate";
            this.cmdgenerate.Size = new System.Drawing.Size(151, 36);
            this.cmdgenerate.TabIndex = 1;
            this.cmdgenerate.Text = "Generate Report";
            this.cmdgenerate.UseVisualStyleBackColor = true;
            this.cmdgenerate.Click += new System.EventHandler(this.cmdgenerate_Click);
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ToolTipText = "ObtainedMarks";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 339);
            this.Controls.Add(this.cmdgenerate);
            this.Controls.Add(this.dataReport);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReport;
        private System.Windows.Forms.Button cmdgenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
    }
}