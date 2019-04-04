using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjectB
{
    public partial class AssessmentComponent : Form
    {
        public AssessmentComponent()
        {
            InitializeComponent();
        }
        int id;
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";


        private void AssessmentComponent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet6.AssessmentComponent' table. You can move, or remove it, as needed.
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);

        }
        void UpdateValues()
        {
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            //asse
            string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT Id FROM Rubric";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricId.Items.Add(reader[0]);



            }
            cmd.Close();
        }
        void UpdateValue()
        {
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet6.AssessmentComponent);
            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            //this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            //asse
            string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT Id FROM Assessment";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbAssessmentId.Items.Add(reader[0]);



            }
            cmd.Close();

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (cmdAdd.Text == "Save")
            {
                string qeury = "insert into dbo.AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) values('" + this.txtName.Text + "','" + this.cmbRubricId.Text + "','" + this.txtMarks.Text + "','" + DateTime.Now + "','" + DateTime.Now + "','" + this.cmbAssessmentId.Text + "')";
                SqlConnection conDataBase = new SqlConnection(constring);

                SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                SqlDataReader myreader;
                conDataBase.Open();
                myreader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Assessment Component information Stored");
                while (myreader.Read())
                {

                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.AssessmentComponent", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataAssessmentComponent.DataSource = dtbl;
                }
                txtName.Text = " ";

                txtMarks.Text = "";
                cmbAssessmentId.Text = "";
                cmbRubricId.Text = "";
            }
            if (cmdAdd.Text == "Update")
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                string Qeury = "Update dbo.AssessmentComponent Set Name ='" + txtName.Text + "',TotalMarks ='" + txtMarks.Text + "',RubricId ='" + cmbRubricId.Text + "',AssessmentId ='" +cmbAssessmentId.Text + "',DateUpdated ='" + DateTime.Now + "' Where Id ='" + id + "' ";

                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment Component Information Updated");
                cmdAdd.Text = "Add";
                txtName.Text = " ";
                cmbRubricId.Text = "";
                txtMarks.Text = "";
                cmbAssessmentId.Text = "";



                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataAssessmentComponent.DataSource = dtbl;
                }

            }

        }

        private void cmbRubricId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRubricId_Click(object sender, EventArgs e)
        {
            cmbRubricId.Items.Clear();
            UpdateValues();
        }

        private void cmbAssessmentId_Click(object sender, EventArgs e)
        {
            cmbAssessmentId.Items.Clear();
            UpdateValue();
        }

        private void dataAssessmentComponent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataAssessmentComponent.Columns["Edit"].Index)
            {
                string temp = dataAssessmentComponent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                txtName.Text = dataAssessmentComponent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtMarks.Text = dataAssessmentComponent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbRubricId.Text = dataAssessmentComponent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                cmbAssessmentId.Text = dataAssessmentComponent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();



                cmdAdd.Text = "Update";



            }
            if (e.ColumnIndex == dataAssessmentComponent.Columns["Delete"].Index)
            {
                int row = e.RowIndex;
                int id = Convert.ToInt32(dataAssessmentComponent.Rows[row].Cells[0].Value);

                string Qeury = "Delete from dbo.AssessmentComponent where ID = '" + id + "'";
                SqlConnection connection1 = new SqlConnection(constring);
                connection1.Open();
                SqlCommand cmd = new SqlCommand(Qeury, connection1);
                cmd.ExecuteNonQuery();
                this.dataAssessmentComponent.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Assessment Component has been deleted");

            }
        }
    }
}
