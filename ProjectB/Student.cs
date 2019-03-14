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
    public partial class Student : Form
    {
        int id;
        public Student()
        {
            InitializeComponent();
        }
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtLastName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("Invalid name");
                }
            }

        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.projectBDataSet2.Student);
            // TODO: This line of code loads data into the 'projectBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectBDataSet.Student);

        }

        int fun(string text)
        {
            if(text == "Active")
            {
                return 5;
            }
            return 6;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                char[] aa = new char[txtRegistrationNumber.Text.Length];
                int i = 0;
                bool flag = false;
                foreach (char a in txtRegistrationNumber.Text)
                {
                    aa[i] = a;
                    i++;
                }

                for (int j = 0; j < 4; j++)
                {
                    if (char.IsDigit(aa[j]) == false)
                    {
                        MessageBox.Show("Invalid!3");
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    if (aa[4] != '-' || aa[7] != '-')
                    {
                        MessageBox.Show("Invalid2!");
                        flag = true;
                    }
                    else if (char.IsDigit(aa[5]) || char.IsDigit(aa[6]))
                    {
                        MessageBox.Show("Invalid1!");
                        flag = true;
                    }
                    else if (!char.IsDigit(aa[8]) || !char.IsDigit(aa[9]) || !char.IsDigit(aa[10]))
                    {
                        MessageBox.Show("Invalid 0!");
                        flag = true;
                    }
                }

                int countdot = 0;
                int countAt = 0;
                foreach (char a in txtEmail.Text)
                {
                    if (a == '@')
                    {
                        countdot++;
                    }
                    if (a == '.')
                    {
                        countAt++;
                    }
                }

                if (countdot != 1 || countAt != 1)
                {
                    MessageBox.Show("Invalidaha!");
                    flag = true;
                }


                if (flag == false)
                {
                    if(cmdAdd.Text == "Add")
                    {
                        string qeury = "insert into dbo.Student( FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtContact.Text + "','" + this.txtEmail.Text + "','" + this.txtRegistrationNumber.Text + "','" + fun(this.cbstatus.Text) + "')";
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
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Student", sqlcon);
                            DataTable dtbl = new DataTable();
                            sqlDA.Fill(dtbl);

                            dataStudent.DataSource = dtbl;
                        }

                    }
                    if(cmdAdd.Text == "Update")
                    {
                        SqlConnection connection = new SqlConnection(constring);
                        connection.Open();
                        string Qeury = "Update dbo.student Set FirstName ='" + txtFirstName.Text + "',LastName ='" + txtLastName.Text + "',Contact ='" + txtContact.Text + "',Email ='" + txtEmail.Text + "',RegistrationNumber ='" + txtRegistrationNumber.Text + "',Status ='" + fun(cbstatus.Text) + "' Where Id ='" + id + "' ";
                        //
                        SqlCommand cmd = new SqlCommand(Qeury, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updated");
                        cmdAdd.Text = "Add";
                        using (SqlConnection sqlcon = new SqlConnection(constring))
                        {
                            sqlcon.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Student", sqlcon);
                            DataTable dtbl = new DataTable();
                            sqlDA.Fill(dtbl);

                            dataStudent.DataSource = dtbl;
                        }



                    }

                }

                


            } catch (Exception ex)
            {
                throw (ex);
            }
            /*char[] s = new char[10];
            char check;
            int i = 0;
            foreach (char c in txtRegistrationNumber.Text)
            {
                s[i] = c;
                i++;
                //2016-CS-106


            }
            for (int j = 0; j < 4; j++)
            {
                check = s[j];
                if (!char.IsDigit(check))
                {
                    MessageBox.Show("Invalid Registration number");
                }







            }
            */

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtFirstName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("Invalid name");
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtContact.Text)
            {
                if (char.IsLetter(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("Invalid contact");
                }
            }
            if (txtContact.Text.Length > 11)
            {
                MessageBox.Show("Number cannot be larger than 11");

            }
            if(txtContact.Text.Length < 11)
            {
                MessageBox.Show("Number should contain 11 digits");
            }
        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            


        }


                


   

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtStatus_TextChanged(object sender, EventArgs e)
    {
        //
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection sqlcon = new SqlConnection(constring))
        {
            sqlcon.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Student", sqlcon);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);

            dataStudent.DataSource = dtbl;
        }
    }

    private void dataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataStudent.Columns["delete"].Index)
            {
                this.dataStudent.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                int id = Convert.ToInt32(dataStudent.Rows[row].Cells[0].Value);
                string Qeury = "Delete from dbo.student where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted");
            }
            if (e.ColumnIndex == dataStudent.Columns["edit"].Index)
            {
                string temp = dataStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);



                
                txtFirstName.Text = dataStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtLastName.Text = dataStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtContact.Text = dataStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtEmail.Text = dataStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtRegistrationNumber.Text = dataStudent.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

                int val = 0;

                val = Convert.ToInt32(dataStudent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());

                if (val == 5)
                {
                    cbstatus.Text = "Active";
                }
                else
                {
                    cbstatus.Text = "InActive";
                }
                
                cmdAdd.Text = "Update";
                

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CLO C = new CLO();
            this.Hide();
            C.Show();
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            string Qeury = "Update dbo.student Set FirstName ='" + txtFirstName.Text + "',LastName ='" + txtLastName.Text + "',Contact ='" + txtContact.Text + "',Email ='" + txtEmail.Text + "',RegistrationNumber ='" + txtRegistrationNumber.Text + "',Status ='" + fun(cbstatus.Text) + "' Where Id ='"+id+"' ";
            //
            SqlCommand cmd = new SqlCommand(Qeury, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");




        }
    }
}
