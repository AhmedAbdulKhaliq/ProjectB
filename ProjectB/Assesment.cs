using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }
        int id;
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";

        private void Assesment_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataAssesment.DataSource = dtbl;
            }
            
        }

        private void cmdAddAssesment_Click(object sender, EventArgs e)
        {
            if(cmdAddAssesment.Text == "Save")
            {
                string qeury = "insert into dbo.Assessment(Title,DateCreated,TotalMarks,TotalWeightage) values('" + this.txtTitle.Text + "','" + DateTime.Now + "','" + this.txtMarks.Text + "','" + this.txtWieght.Text + "')";
                SqlConnection conDataBase = new SqlConnection(constring);

                SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                SqlDataReader myreader;
                conDataBase.Open();
                myreader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Assessment information Stored");
                while (myreader.Read())
                {

                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataAssesment.DataSource = dtbl;
                }
                txtTitle.Text = " ";

                txtMarks.Text = "";
                txtWieght.Text = "";
            }
            if(cmdAddAssesment.Text == "Update")
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                string Qeury = "Update dbo.Assessment Set Title ='" + txtTitle.Text + "',TotalMarks ='" + txtMarks.Text + "',TotalWeightage ='" + txtWieght.Text +  "' Where Id ='" + id + "' ";
                
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assessment Information Updated");
                cmdAddAssesment.Text = "Add";
                txtTitle.Text = " ";
                txtWieght.Text = "";
                txtMarks.Text = "";
                


                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataAssesment.DataSource = dtbl;
                }

            }
            

            
        }

        private void dataAssesment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataAssesment.Columns["delete"].Index)
            {
                int row = e.RowIndex;
                id = Convert.ToInt32(dataAssesment.Rows[row].Cells[0].Value);

                int[] assessmentcomponent_array = new int[50];
                int i = 0;
                string qeury = "Select Id from AssessmentComponent where AssessmentId = '" + id + "'";
                SqlCommand com = new SqlCommand(qeury, connection);
                com.Parameters.Add(new SqlParameter("0", 1));
                SqlDataReader reader1 = com.ExecuteReader();
                while (reader1.Read())
                {
                    assessmentcomponent_array[i] = Convert.ToInt32(reader1[0]);
                    i++;

                }
                int c = assessmentcomponent_array[0];
                int d = assessmentcomponent_array[1]; 
                reader1.Close();
                foreach(int componentid in assessmentcomponent_array)
                {
                    string qeury1 = "Delete from StudentResult where AssessmentComponentId = '" + componentid + "'";
                    SqlCommand com1 = new SqlCommand(qeury1, connection);
                    com1.ExecuteNonQuery();

                    string qeury2 = "Delete from AssessmentComponent where Id = '" + componentid + "'";
                    SqlCommand com2 = new SqlCommand(qeury2, connection);
                    com2.ExecuteNonQuery();
                }
                string Qeury3 = "Delete from dbo.Assessment where Id = '" + id + "'";
                SqlCommand cmd3 = new SqlCommand(Qeury3, connection);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Assessment Deleted");
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataAssesment.DataSource = dtbl;
                }










                }
            if (e.ColumnIndex == dataAssesment.Columns["edit"].Index)
            {
                string temp = dataAssesment.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                txtTitle.Text = dataAssesment.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtMarks.Text = dataAssesment.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtWieght.Text = dataAssesment.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                
                

                cmdAddAssesment.Text = "Update";


            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtTitle.Text)
            {
                if (a == '_' || a == '-' || a == '@')
                {
                    MessageBox.Show("Invalid  Details ");
                }
            }
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {
            foreach(char a in txtMarks.Text)
            {
                if (!char.IsNumber(a))
                {
                    MessageBox.Show("Enter Valid Marks");
                }
            }
        }

        private void txtWieght_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtWieght.Text)
            {
                if (!char.IsNumber(a))
                {
                    MessageBox.Show("Enter Valid Wieghtage");
                }
            }



        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Assessment", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataAssesment.DataSource = dtbl;
            }
        }
    }
}
