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
                if(flag == false)
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
                SqlConnection connection = new SqlConnection(constring);
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
            if (e.ColumnIndex == dataRubric.Columns["delete"].Index)
            {
                
                int row = e.RowIndex;
                id = Convert.ToInt32(dataRubric.Rows[e.RowIndex].Cells[0].Value);
                string Qeury1 = "Delete from dbo.RubricLevel where RubricId = '" + id + "'";
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
                }

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
            bool flag = false;
            if(txtDetRubric.Text== "" || txtRubricLevel.Text == "" || cmbRubricID.Text == "")
            {
                flag = true;
                MessageBox.Show("Input cannot be Null");
            }
            if(flag==false)
            {
                if (cmdAddLevel.Text == "Add")
                {

                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        string qeury = "insert into dbo.RubricLevel(RubricId,Details,MeasurementLevel) values('" + this.cmbRubricID.Text + "','" + this.txtDetRubric.Text + "','" + this.txtRubricLevel.Text + "')";
                        SqlConnection conDataBase = new SqlConnection(constring);

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
    }
}
