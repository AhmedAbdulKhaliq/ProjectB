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
    public partial class CLO : Form
    {
        public CLO()
        {
            InitializeComponent();
        }
        string constring = "Data Source = DESKTOP-P4KMVN9; Initial Catalog = ProjectB; Integrated Security = True";
        int id;
        private void CLO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectBDataSet1.Clo' table. You can move, or remove it, as needed.
            this.cloTableAdapter.Fill(this.projectBDataSet1.Clo);

        }

        private void cmdAddClo_Click(object sender, EventArgs e)
        {
            if (cmdAddClo.Text == "Add")
            {
                string qeury = "insert into dbo.Clo( Name,DateCreated,DateUpdated) values('" + this.txtCloName.Text + "','" + DateTime.Now + "','" + DateTime.Now + "')";
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
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Clo", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataClo.DataSource = dtbl;
                }


            }
            if (cmdAddClo.Text == "Update")
            {
                SqlConnection connection = new SqlConnection(constring);
                connection.Open();
                string Qeury = "Update dbo.Clo Set Name ='" + txtCloName.Text + "',DateUpdated ='" + DateTime.Now + "' Where Id ='" + id + "' ";
                //
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
                cmdAddClo.Text = "Add";
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Clo", sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);

                    dataClo.DataSource = dtbl;

                }




            }
        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from dbo.Clo", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);

                dataClo.DataSource = dtbl;
            }
        }

        private void dataClo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataClo.Columns["delete"].Index)
            {
                this.dataClo.Rows.RemoveAt(e.RowIndex);
                int row = e.RowIndex;
                int id = Convert.ToInt32(dataClo.Rows[row].Cells[0].Value);
                string Qeury1 = "Delete from dbo.Rubric where CloId = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(Qeury1, connection);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("data has been deleted");


                string Qeury = "Delete from dbo.Clo where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data has been deleted");
            }
            if (e.ColumnIndex == dataClo.Columns["edit"].Index)
            {
                string temp = dataClo.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id = Convert.ToInt32(temp);




                txtCloName.Text = dataClo.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmdAddClo.Text = "Update";
               


            }

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCloName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtCloName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("Invalid CLO name");
                }
            }
        }
    }
}
    