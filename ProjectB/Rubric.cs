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
    public partial class Rubric : Form
    {
        public Rubric()
        {
            InitializeComponent();
        }
        int id;
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT Id FROM Clo";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                comboCloNo.Items.Add(reader[0]);
            }
            cmd.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text =="Add Rubric")
            {
                string qeury = "insert into dbo.Rubric(Id, Details,CloId) values('" + this.txtRubricId.Text + "','" + txtDetails.Text + "','" + this.comboCloNo.Text + "')";
                SqlConnection conDataBase = new SqlConnection(constring);
                SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                SqlDataReader myreader;
                conDataBase.Open();
                myreader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myreader.Read())
                {

                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Rubric", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataRubric.DataSource = dtbl;
                }
                AddRubric.Hide();
                tab2.Show();

            }
            if(button1.Text == "Update")
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                string Qeury = "Update dbo.Rubric Set Id ='" + txtRubricId.Text + "',Details='" + txtDetails.Text + "',CLoId='" + comboCloNo.Text + "' Where Id ='" + id + "' ";

                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Data Updated");
                button1.Text = "Add Rubric";
                AddRubric.Hide();
                tab2.Show();
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Rubric", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataRubric.DataSource = dtbl;
                }

            }
            
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Rubric", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

               dataRubric.DataSource = dtbl;
            }

        }

        private void dataRubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataRubric.Columns["delete"].Index)
            {
                this.dataRubric.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                id = Convert.ToInt32(dataRubric.Rows[row].Cells[0].Value);
                string Qeury = "Delete from dbo.Rubric where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted");
            }
            if (e.ColumnIndex == dataRubric.Columns["edit"].Index)
            {
                string temp = dataRubric.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                txtRubricId.Text = dataRubric.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                comboCloNo.Text = dataRubric.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDetails.Text = dataRubric.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                button1.Text = "Update";
                tab2.Hide();
                
                AddRubric.Show();



            }

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
