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
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdgenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReport
            // 
            this.dataReport.AllowUserToAddRows = false;
            this.dataReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObtainedMarks});
            this.dataReport.Location = new System.Drawing.Point(12, 104);
            this.dataReport.Name = "dataReport";
            this.dataReport.Size = new System.Drawing.Size(629, 223);
            this.dataReport.TabIndex = 0;
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ToolTipText = "ObtainedMarks";
            // 
            // cmdgenerate
            // 
            this.cmdgenerate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdgenerate.Location = new System.Drawing.Point(236, 62);
            this.cmdgenerate.Name = "cmdgenerate";
            this.cmdgenerate.Size = new System.Drawing.Size(151, 36);
            this.cmdgenerate.TabIndex = 1;
            this.cmdgenerate.Text = "Generate Report";
            this.cmdgenerate.UseVisualStyleBackColor = false;
            this.cmdgenerate.Click += new System.EventHandler(this.cmdgenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLO Report";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdgenerate);
            this.Controls.Add(this.dataReport);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReport;
        private System.Windows.Forms.Button cmdgenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.Label label1;
    }
}