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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }
        int id;
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";


        private void Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet7.ClassAttendance' table. You can move, or remove it, as needed.
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet7.ClassAttendance);

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (cmdAdd.Text == "Add")
            {
                string qeury = "insert into dbo.ClassAttendance(AttendanceDate) values('" + this.calenderAttendance.SelectionEnd.Date + "')";
                SqlConnection conDataBase = new SqlConnection(constring);

                SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                SqlDataReader myreader;
                conDataBase.Open();
                myreader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Class Attendance Date Stored");
                while (myreader.Read())
                {

                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.ClassAttendance", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataClass.DataSource = dtbl;
                }
                            }
            if (cmdAdd.Text == "Update")
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                string Qeury = "Update dbo.ClassAttendance Set  AttendanceDate ='" + calenderAttendance.SelectionEnd +  "' Where Id ='" + id + "' ";

                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Date Updated");
                



                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.ClassAttendance", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataClass.DataSource = dtbl;
                }

            }

        }

        private void dataClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataClass.Columns["edit"].Index)
            {
                string temp = dataClass.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                //txtTitle.Text = dataAssesment.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                //txtMarks.Text = dataAssesment.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //txtWieght.Text = dataAssesment.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                string date = dataClass.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                DateTime d = Convert.ToDateTime(date);
                calenderAttendance.SetDate(d);


                cmdAdd.Text = "Update";


            }
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataClass.Columns["delete"].Index)
            {

                int row = e.RowIndex;
                int id = Convert.ToInt32(dataClass.Rows[row].Cells[0].Value);
                string c = "Delete  from dbo.StudentAttendance where AttendanceId = '" + id + "'";
                SqlCommand cmd2 = new SqlCommand(c, connection);
                cmd2.ExecuteNonQuery();
                //string Qeury = "Delete from dbo.Assessment where ID = '" + id + "'";
                //SqlCommand cmd = new SqlCommand(Qeury, connection);
                //cmd.ExecuteNonQuery();



                string run = "Delete from dbo.ClassAttendance where ID = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(run, connection);
                cmd1.ExecuteNonQuery();
                //string Qeury = "Delete from dbo.Assessment where ID = '" + id + "'";
                //SqlCommand cmd = new SqlCommand(Qeury, connection);
                //cmd.ExecuteNonQuery();
                this.dataClass.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Class Date has been deleted");
            }
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.ClassAttendance", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataClass.DataSource = dtbl;
            }
        }
    }
}
