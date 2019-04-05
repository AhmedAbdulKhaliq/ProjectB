using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
        

        private void Result_Load(object sender, EventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            string query = "SELECT Id FROM Student";
            SqlCommand cmd = new SqlCommand(query, conDataBase);
            SqlDataReader reader;
            try
            {
                conDataBase.Open();
                reader = cmd.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader.Read())
                {
                    cmbStudentId.Items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();

            string query1 = "SELECT Title FROM Assessment";
            SqlCommand cmd1 = new SqlCommand(query1, conDataBase);
            SqlDataReader reader1;
            try
            {
                conDataBase.Open();
                reader1 = cmd1.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader1.Read())
                {
                    cmbTitle.Items.Add(reader1[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();

            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conDataBase);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;

            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double marks = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double level = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double totalmarks = Convert.ToDouble((level / 4) * marks);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = totalmarks;
            }
            //cmbStudentId.Items.Clear();
            //cmbTitle.Items.Clear();
            //cmbComponentId.Items.Clear();
            //cmbDetails.Items.Clear();
            //cmbLevel.Items.Clear();
            //comboBox6.Items.Clear();
        }

        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            string q = "SELECT * FROM Assessment WHERE Title = '" + cmbTitle.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conDataBase);
            
            conDataBase.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            
            conDataBase.Close();
            string query2 = "SELECT Id FROM AssessmentComponent WHERE AssessmentId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conDataBase);
            SqlDataReader reader2;
            try
            {
                conDataBase.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cmbComponentId.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }

        private void cmbComponentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            string q = "SELECT RubricId FROM AssessmentComponent WHERE Id = '" + cmbComponentId.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conDataBase);
           
            conDataBase.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            
            conDataBase.Close();
            string query2 = "SELECT Details FROM Rubric WHERE Id = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conDataBase);
            cmbDetails.Items.Clear();
            SqlDataReader reader2;
            try
            {
                conDataBase.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    cmbDetails.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }

        private void cmbDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            string q = "SELECT Id FROM Rubric WHERE Details = '" + cmbDetails.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conDataBase);
           
            conDataBase.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            conDataBase.Close();
            string query2 = "SELECT MeasurementLevel FROM RubricLevel WHERE RubricId = '" + r + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conDataBase);
            
            SqlDataReader reader2;
            try
            {
                conDataBase.Open();
                reader2 = cmd2.ExecuteReader();
                
                while (reader2.Read())
                {
                    cmbLevel.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection conDataBase = new SqlConnection(constring);
            string query2 = "SELECT Id FROM RubricLevel WHERE MeasurementLevel = '" + cmbLevel.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, conDataBase);
            //cbx_rubricId.Items.Clear();
            SqlDataReader reader2;
            try
            {
                conDataBase.Open();
                reader2 = cmd2.ExecuteReader();
                //MessageBox.Show("Saved");
                while (reader2.Read())
                {
                    comboBox6.Items.Add(reader2[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conDataBase = new SqlConnection(constring);
            string q = "SELECT TotalMarks FROM AssessmentComponent WHERE Id = '" + cmbComponentId.Text + "'";
            SqlCommand cmda = new SqlCommand(q, conDataBase);
            //SqlDataReader myreader;
            conDataBase.Open();
            int r = Convert.ToInt32(cmda.ExecuteScalar());
            conDataBase.Close();

            string query = "INSERT into StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" + cmbStudentId.Text + "', '" + cmbComponentId.Text + "', '" + comboBox6.Text + "', '" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, conDataBase);
            SqlDataReader reader;

            conDataBase.Open();
            reader = cmd.ExecuteReader();
            MessageBox.Show("Data is Saved");
            conDataBase.Close();

            string q1 = "SELECT StudentResult.AssessmentComponentId, StudentResult.StudentId, Student.FirstName As Student, Rubric.Details, Assessment.Title AS AssessmentTitle, AssessmentComponent.TotalMarks AS ComponentMarks, RubricLevel.MeasurementLevel FROM StudentResult JOIN Student On StudentResult.StudentId = Student.Id JOIN AssessmentComponent ON Assessmentcomponent.Id = StudentResult.AssessmentComponentId JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id JOIN Rubric ON RubricLevel.RubricId = Rubric.Id Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId ";
            SqlDataAdapter d = new SqlDataAdapter(q1, conDataBase);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AssessmentComponentId"].Visible = false;
            dataGridView1.Columns["StudentId"].Visible = false;

            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                double marks = Convert.ToDouble(dataGridView1.Rows[i].Cells["ComponentMarks"].Value);
                double level = Convert.ToDouble(dataGridView1.Rows[i].Cells["MeasurementLevel"].Value);
                double totalmarks = Convert.ToDouble((level / 4) * marks);
                dataGridView1.Rows[i].Cells["ObtainedMarks"].Value = totalmarks;
            }
            //cmbStudentId.Items.Clear();
            //cmbTitle.Items.Clear();
            //cmbComponentId.Items.Clear();
            //cmbDetails.Items.Clear();
            //cmbLevel.Items.Clear();
            //comboBox6.Items.Clear();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            int id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conDataBase.Open();
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                    string query = "DELETE FROM StudentResult WHERE StudentId = @id1 and AssessmentComponentId = @id2";
                    SqlCommand cmd = new SqlCommand(query, conDataBase);
                    cmd.Parameters.Add(new SqlParameter("@id1", id1));
                    cmd.Parameters.Add(new SqlParameter("@id2", id2));
                    cmd.ExecuteReader();
                    conDataBase.Close();

                }
            }
        }
    }
}
