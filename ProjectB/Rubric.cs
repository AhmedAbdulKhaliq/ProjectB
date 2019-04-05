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

        /// <summary>
        /// This fn do what is this that it loads the clo id into the combobox
        /// cmbcloid when ever this form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void UpdateValues()
        {
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet4.RubricLevel);
            // TODO: This line of code loads data into the 'projectBDataSet3.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection cmd = new SqlConnection(constring);
            cmd.Open();
            String s = "SELECT Id FROM Clo";
            SqlCommand command = new SqlCommand(s, cmd);
            command.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboCloNo.Items.Add(reader[0]);



            }
            cmd.Close();
        }
        void UpdateValue()
        {
            this.rubricTableAdapter.Fill(this.projectBDataSet3.Rubric);
            string con = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection cmd2 = new SqlConnection(con);
            cmd2.Open();
            String c = "SELECT Id FROM Rubric";
            SqlCommand com = new SqlCommand(c, cmd2);
            com.Parameters.Add(new SqlParameter("0", 1));
            SqlDataReader reader1 = com.ExecuteReader();
            while (reader1.Read())
            {
                //comboCloNo.Items.Add(reader[0]);
                //cmbCloID.Items.Add(reader[0]);
                cmbRubricID.Items.Add(reader1[0]);
            }
            cmd2.Close();
        }
        private void Rubric_Load(object sender, EventArgs e)
        {
            UpdateValues();
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.RubricLevel", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }




        }

        /// <summary>
        /// This fn. is also in two parts. It also do two things one is that ifthe
        /// btn text is add than it adds the dta to the rubric table and if it 
        /// is ipdate it updates the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            
            bool flag = false;
            if(button1.Text =="Add Rubric")
            {
                if(txtDetails.Text == "")
                {
                    MessageBox.Show("Rubric details cannot be null");
                    flag = true;

                }
                if (comboCloNo.Text == "")
                {
                    MessageBox.Show("CLOID cannot be null");
                    flag = true;

                }
                if (txtRubricId.Text == "")
                {
                    MessageBox.Show("Rubric ID cannot be null");
                    flag = true;

                }
                bool isExist = false;
                string query2 = "SELECT CloId, COUNT(CloId) FROM Rubric GROUP BY CloId HAVING COUNT(CloId) >= 4";
                SqlCommand cmd1 = new SqlCommand(query2, connection);
                connection.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(comboCloNo.Text);
                    if (id == Convert.ToInt32(comboCloNo.Text))
                    {
                        isExist = true;
                        MessageBox.Show("More than 4 rubrics can't be added against 1 Clo");
                        break;
                    }
                }
                connection.Close();
                bool isExist1 = false;
                string query3 = "SELECT Id FROM Rubric";
                SqlCommand cmd2 = new SqlCommand(query3, connection);
                connection.Open();
                SqlDataReader reader1 = cmd2.ExecuteReader();
                while(reader.Read())
                {
                    int id = Convert.ToInt32(txtRubricId.Text);
                    if(id == Convert.ToInt32(txtRubricId.Text))
                    {
                        isExist1 = true;
                        MessageBox.Show("Rubric Id should be Unique;");
                        break;
                    }
                }
                connection.Close();
                if (isExist == false && isExist1 == false && flag == false )
                {
                    string qeury = "insert into dbo.Rubric(Id, Details,CloId) values('" + this.txtRubricId.Text + "','" + txtDetails.Text + "','" + this.comboCloNo.Text + "')";
                    SqlConnection conDataBase = new SqlConnection(constring);
                    SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                    SqlDataReader myreader;
                    conDataBase.Open();
                    myreader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Rubric has been Saved");
                    txtRubricId.Text = "";
                    txtDetails.Text = "";
                    comboCloNo.Text = "";
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


            }
            if(button1.Text == "Update")
            {
                
                connection.Open();
                string Qeury = "Update dbo.Rubric Set Id ='" + txtRubricId.Text + "',Details='" + txtDetails.Text + "',CLoId='" + comboCloNo.Text + "' Where Id ='" + id + "' ";

                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Rubric is  Updated");
                button1.Text = "Add Rubric";
                txtRubricId.Text = "";
                txtDetails.Text = "";
                comboCloNo.Text = "";
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
            if (e.ColumnIndex == dataRubric.Columns["Delete"].Index)
            {
                try
                {
                    int[] rubric_level = new int[4];
                    int j = 0;
                    int[] assessment_componenT = new int[100];


                    int row = e.RowIndex;
                    id = Convert.ToInt32(dataRubric.Rows[e.RowIndex].Cells[0].Value);
                    String d = "SELECT Id FROM dbo.RubricLevel where RubricId ='" + id + "'";
                    SqlCommand com1 = new SqlCommand(d, connection);
                    com1.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r2 = com1.ExecuteReader();
                    while (r2.Read())
                    {
                        //comboCloNo.Items.Add(reader[0]);
                        //cmbCloID.Items.Add(reader[0]);
                        //cmbRubricID.Items.Add(reader1[0]);
                        rubric_level[j] = Convert.ToInt32(r2[0]);
                        j++;

                    }
                    r2.Close();
                    int s = rubric_level[0];
                    int v = rubric_level[1];
                    String del = "SELECT Id FROM dbo.AssessmentComponent where RubricId ='" + id + "'";
                    SqlCommand com11 = new SqlCommand(del, connection);
                    com11.Parameters.Add(new SqlParameter("0", 1));
                    SqlDataReader r3 = com11.ExecuteReader();
                    while (r3.Read())
                    {
                        //comboCloNo.Items.Add(reader[0]);
                        //cmbCloID.Items.Add(reader[0]);
                        //cmbRubricID.Items.Add(reader1[0]);
                        assessment_componenT[j] = Convert.ToInt32(r3[0]);
                        j++;

                    }
                    r3.Close();

                    int s1 = assessment_componenT[1];
                    int s2 = assessment_componenT[0];
                    int s3 = assessment_componenT[2];
                    //MessageBox.Show("...");
                    foreach (int a in rubric_level)

                    {
                        int delete = a;
                        string Qeury0 = "Delete from dbo.StudentResult where RubricMeasurementId = '" + a + "'";
                        SqlCommand cmd0 = new SqlCommand(Qeury0, connection);
                        cmd0.ExecuteNonQuery();




                    }
                    foreach (int a in assessment_componenT)

                    {
                        int delete = a;
                        string Qeury1 = "Delete from dbo.StudentResult where AssessmentComponentId = '" + a + "'";
                        SqlCommand cmd1 = new SqlCommand(Qeury1, connection);
                        cmd1.ExecuteNonQuery();




                    }
                    string Qeury2 = "Delete from dbo.RubricLevel where RubricId = '" + id + "'";
                    SqlCommand cmd3 = new SqlCommand(Qeury2, connection);
                    cmd3.ExecuteNonQuery();


                    string Qeury4 = "Delete from dbo.AssessmentComponent where RubricId = '" + id + "'";
                    SqlCommand cmd4 = new SqlCommand(Qeury4, connection);
                    cmd4.ExecuteNonQuery();

                    string qeury5 = "Delete from dbo.Rubric where Id = '" + id + "'";
                    SqlCommand cmd5 = new SqlCommand(qeury5, connection);
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Rubric Deleted");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                











                /*string Qeury1 = "Delete from dbo.RubricLevel where RubricId = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(Qeury1, connection);
                cmd1.ExecuteNonQuery();

                string Qeury2 = "Delete from dbo.AssessmentComponent where RubricId = '" + id + "'";
                SqlCommand cmd2 = new SqlCommand(Qeury2, connection);
                cmd2.ExecuteNonQuery();


                string Qeury = "Delete from dbo.Rubric where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                this.dataRubric.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Rubric has been deleted");

                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.AssessmentComponent", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    AssessmentComponent a = new AssessmentComponent();
                    a.dataAssessmentComponent.DataSource = dtbl;

                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.RubricLevel", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                }*/

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
        /// <summary>
        /// It checks that the Rubric ID should be int not any charcter,symbol
        /// letter or punctuation. Moreover it should not be null.
        /// </summary>
        /// 

        private void txtRubricId_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtRubricId.Text)
            {
                if (!char.IsDigit(a))
                {
                    MessageBox.Show("The Id you entered is Invalid");
                }
            }
            
        }
        /// <summary>
        /// This fn. checks that the details should not contain @ and -
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtDetails.Text)
            {
                if (a =='_' || a == '-' || a== '@')
                {
                    MessageBox.Show("Invalid Rubric Details ");
                }
            }
           /* if(txtDetails.Text== "")
            {
                MessageBox.Show("Details cannot be null");
            }*/

        }
        /// <summary>
        /// This fn. checks that the clo combo box should not be empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboCloNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboCloNo.Text == "")
            //{
              //  MessageBox.Show("Clo cannot be null");

            //}

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdAddLevel_Click(object sender, EventArgs e)
        {
            SqlConnection conDataBase = new SqlConnection(constring);
            bool isExist = false;
            string query2 = "SELECT RubricId, COUNT(RubricId) FROM RubricLevel GROUP BY RubricId HAVING COUNT(RubricId) >= 4";
            SqlCommand cmd1 = new SqlCommand(query2, conDataBase);
            conDataBase.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(cmbRubricID.Text);
                if (id == Convert.ToInt32(cmbRubricID.Text))
                {
                    isExist = true;
                    MessageBox.Show("More than 4 level can't be added against 1 rubric");
                    break;
                }
            }
            conDataBase.Close();
            bool flag = false;
            if(txtDetRubric.Text== "" || txtRubricLevel.Text == "" || cmbRubricID.Text == "")
            {
                flag = true;
                MessageBox.Show("Input cannot be Null");
            }
            if(flag==false)
            {
                if (cmdAddLevel.Text == "Add" && isExist == false)
                {

                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        string qeury = "insert into dbo.RubricLevel(RubricId,Details,MeasurementLevel) values('" + this.cmbRubricID.Text + "','" + this.txtDetRubric.Text + "','" + this.txtRubricLevel.Text + "')";
                        

                        SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                        SqlDataReader myreader;
                        conDataBase.Open();
                        myreader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Rubric Level Added");
                        while (myreader.Read())
                        {

                        }
                        sqlcon.Open();
                        SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.RubricLevel", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlDA.Fill(dtbl);

                        dataGridView1.DataSource = dtbl;
                        cmbRubricID.Text = "";
                        txtDetRubric.Text = "";
                        txtRubricLevel.Text = "";




                    }


                }
                if (cmdAddLevel.Text == "Update")
                {
                    SqlConnection connection = new SqlConnection(constring);
                    connection.Open();
                    string Qeury = "Update dbo.RubricLevel Set RubricId      ='" + cmbRubricID.Text + "',Details ='" + txtDetRubric.Text + "',MeasurementLevel ='" + txtRubricLevel.Text + "' Where Id ='" + id + "' ";
                    //
                    SqlCommand cmd = new SqlCommand(Qeury, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rubric Level Information Updated");




                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        sqlcon.Open();
                        SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.RubricLevel", sqlcon);
                        DataTable dtbl = new DataTable();
                        sqlDA.Fill(dtbl);

                        dataGridView1.DataSource = dtbl;
                    }
                    cmbRubricID.Text = "";
                    txtDetRubric.Text = "";
                    txtRubricLevel.Text = "";
                    cmdAddLevel.Text = "Add";




                }

            }
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataGridView1.Columns["Remove"].Index)
            {
                

                int row = e.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);



                string Qeury = "Delete from dbo.RubricLevel where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Rubric Level has been deleted");
            }
            if (e.ColumnIndex == dataGridView1.Columns["Editt"].Index)
            {
                string temp = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                cmbRubricID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtDetRubric.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtRubricLevel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                //txtRegistrationNumber.Text = dataStudent.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

                
                cmdAddLevel.Text = "Update";


            }
        }

        private void txtDetRubric_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtDetRubric.Text)
            {
                if (a == '_' || a == '-' || a == '@')
                {
                    MessageBox.Show("Invalid Rubric Details ");
                }
            }
        }

        private void txtRubricLevel_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtRubricLevel.Text)
            {
                if (!char.IsDigit(a))
                {
                    MessageBox.Show("The Id you entered is Invalid");
                }
            }
        }

        private void Rubric_MouseClick(object sender, MouseEventArgs e)
        {
            //
        }

        private void comboCloNo_MouseClick(object sender, MouseEventArgs e)
        {
            // UpdateValues();
        }

        private void comboCloNo_Click(object sender, EventArgs e)
        {
            comboCloNo.Items.Clear();
            UpdateValues();
        }

        private void cmbRubricID_Click(object sender, EventArgs e)
        {
            cmbRubricID.Items.Clear();
            UpdateValue();
        }

        private void cmdShowRubric_Click(object sender, EventArgs e)
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

        private void cmdShow_Click(object sender, EventArgs e)
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

        private void cmdShowRubricLevel_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.RubricLevel", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }

        }
    }
}
