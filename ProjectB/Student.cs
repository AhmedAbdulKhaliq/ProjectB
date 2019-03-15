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
        /// <summary>
        /// This function is used to check the validations that the name should not
        /// contain number,symbols or any puntucation moreover it canot be null.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtLastName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("The Last name you entered is Invalid");
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
        /// <summary>
        /// /// <summary>
        /// This function is used to check the validations that the reg number should not
        /// be format free.Its format should be like 2016-cs-106. It cannot be null.
        /// it also checks that the email is formatted and it should not be null. 
        /// If all validations are not violated than The data is added into The Student 
        /// table. and Message is showed. and after this if we edit it the add button text 
        /// is changed into Update and data is updated in that table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                        MessageBox.Show("Invalid Reg No. The correct Syntax is YYYY-XX-NNN");
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    if (aa[4] != '-' || aa[7] != '-')
                    {
                        MessageBox.Show("Invalid Reg No. The correct Syntax is YYYY-XX-NNN");
                        flag = true;
                    }
                    else if (char.IsDigit(aa[5]) || char.IsDigit(aa[6]))
                    {
                        MessageBox.Show("Invalid Reg No. The correct Syntax is YYYY-XX-NNN");
                        flag = true;
                    }
                    else if (!char.IsDigit(aa[8]) || !char.IsDigit(aa[9]) || !char.IsDigit(aa[10]))
                    {
                        MessageBox.Show("Invalid Reg No. The correct Syntax is YYYY-XX-NNN!");
                        flag = true;
                    }
                }
                if (txtContact.Text.Length < 11)
                {
                    MessageBox.Show("Number should contain 11 digits");
                    flag = true;
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
                    MessageBox.Show("Invalid Email.Email should cotain @ and .");
                    flag = true;
                }
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Name cannot be null");
                    flag = true;
                }
                if(txtLastName.Text == "")
                {
                    MessageBox.Show("Name cannot be null");
                    flag = true;

                }
                if (txtRegistrationNumber.Text == "")
                {
                    MessageBox.Show("Reg No. cannot be null");
                    flag = true;

                }
                if (txtContact.Text == "")
                {
                    MessageBox.Show("Contact cannot be null");
                    flag = true;

                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email cannot be null");
                    flag = true;

                }
                if (cbstatus.Text == "")
                {
                    MessageBox.Show("Status cannot be null");
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
                        MessageBox.Show("Student information Stored");
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
                        txtFirstName.Text = " ";
                        txtLastName.Text = "";
                        txtEmail.Text = "";
                        txtContact.Text = "";
                        txtRegistrationNumber.Text = "";
                        cbstatus.Text = "";


                    }
                    if (cmdAdd.Text == "Update")
                    {
                        SqlConnection connection = new SqlConnection(constring);
                        connection.Open();
                        string Qeury = "Update dbo.student Set FirstName ='" + txtFirstName.Text + "',LastName ='" + txtLastName.Text + "',Contact ='" + txtContact.Text + "',Email ='" + txtEmail.Text + "',RegistrationNumber ='" + txtRegistrationNumber.Text + "',Status ='" + fun(cbstatus.Text) + "' Where Id ='" + id + "' ";
                        //
                        SqlCommand cmd = new SqlCommand(Qeury, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student Information Updated");
                        cmdAdd.Text = "Add";
                        txtFirstName.Text = " ";
                        txtLastName.Text = "";
                        txtEmail.Text = "";
                        txtContact.Text = "";
                        txtRegistrationNumber.Text = "";
                        cbstatus.Text = "";



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
        /// <summary>
        /// This function is used to check the validations that the name should not
        /// contain number,symbols or any puntucation moreover it canot be null.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtFirstName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show( "The First name you entered is Invalid");
                }
            }
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        /// <summary>
        /// This function is used to check the validations that the contact should not
        /// contain letters,symbols or any puntucation moreover it canot be null. Its lenghth s
        /// should be 11.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtContact.Text)
            {
                if (char.IsLetter(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("The contact you entered is Invalid");
                }
            }
            if (txtContact.Text.Length > 11)
            {
                MessageBox.Show("Number cannot be larger than 11");

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

        /// <summary>
        /// This function has two parts.One if cell content column is delete than the
        /// data from Student table where given id is id of that row which is selected is Data grid 
        /// view is deleted from student table. The other if is that if the cell text you clicked is edit it
        /// places the columns text of this row to thier respective text boxes so that they
        ///  can be updated and edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void dataStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataStudent.Columns["delete"].Index)
            {
                
                int row = e.RowIndex;
                int id = Convert.ToInt32(dataStudent.Rows[row].Cells[0].Value);
                
                string Qeury = "Delete from dbo.student where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                this.dataStudent.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Sudent Information has been deleted");
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

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
