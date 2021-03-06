﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjectB
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
        private void Reports_Load(object sender, EventArgs e)
        {
            
        }
        private void bindgrid()
        {
            SqlConnection con = new SqlConnection(constring);
            string query1 = "SELECT Student.RegistrationNumber, Clo.Name AS CLONAME, Rubric.Details AS RubricDetails, RubricLevel.MeasurementLevel, AssessmentComponent.Name, AssessmentComponent.TotalMarks AS ComponentMarks FROM StudentResult JOIN Student ON StudentResult.StudentId = Student.Id JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN AssessmentComponent ON StudentResult.AssessmentComponentId = AssessmentComponent.Id JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id JOIN Clo ON Rubric.CloId = Clo.Id";
            SqlCommand cmd1 = new SqlCommand(query1, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd1;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                dataReport.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void exportgridtopdf(DataGridView d, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable1 = new PdfPTable(d.Columns.Count);

            pdftable1.DefaultCell.Padding = 3;
            pdftable1.WidthPercentage = 100;
            pdftable1.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable1.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);


            //Header
            foreach (DataGridViewColumn column in d.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable1.AddCell(cell);

            }

            // Data Row
            foreach (DataGridViewRow row in d.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable1.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialogue = new SaveFileDialog();
            savefiledialogue.FileName = filename;
            savefiledialogue.DefaultExt = ".pdf";
            if (savefiledialogue.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialogue.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable1);
                    pdfdoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF generated and saved to your PC.");
                }
            }
        }

        private void cmdgenerate_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Student.RegistrationNumber, Clo.Name AS CLONAME, Rubric.Details AS RubricDetails, RubricLevel.MeasurementLevel, AssessmentComponent.Name, AssessmentComponent.TotalMarks AS ComponentMarks FROM StudentResult JOIN Student ON StudentResult.StudentId = Student.Id JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN AssessmentComponent ON StudentResult.AssessmentComponentId = AssessmentComponent.Id JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id JOIN Clo ON Rubric.CloId = Clo.Id";
            SqlDataAdapter d = new SqlDataAdapter(query1, constring);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataReport.DataSource = dt;
            int count = dataReport.RowCount;
            for (int i = 0; i < count; i++)
            {
                Double k = Convert.ToDouble(dataReport.Rows[i].Cells["ComponentMarks"].Value);
                Double l = Convert.ToDouble(dataReport.Rows[i].Cells["MeasurementLevel"].Value);
                Double marks = Convert.ToDouble((l / 4) * k);
                //MessageBox.Show(marks.ToString());
                dataReport.Rows[i].Cells[0].Value = marks;


            }
            //bindgrid();
            exportgridtopdf(dataReport, "Report Evaluations");
        }
    }
}
