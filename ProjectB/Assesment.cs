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
            // TODO: This line of code loads data into the 'projectBDataSet5.Assessment' table. You can move, or remove it, as needed.
            //this.assessmentTableAdapter.Fill(this.projectBDataSet5.Assessment);

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
                int id = Convert.ToInt32(dataAssesment.Rows[row].Cells[0].Value);

                string run = "Delete from dbo.AssessmentComponent where ID = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(run, connection);
                cmd1.ExecuteNonQuery();
                string Qeury = "Delete from dbo.Assessment where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                this.dataAssesment.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Assesment Information has been deleted");
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
    }
}
