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
        /// <summary>
        ///   
        /// This fuction if the button text is Add take the values from text boxe txtcloname and save it in Clo table in
        /// DB.It also stores the date created by datetime.mow method and same for date upated.
        /// but if the button text is Updte it updates the values in txt box txtcloname and Name
        /// column of Clo table. It donot update the date created but it updates the date updated in
        /// Clo table.
        /// </summary>
        /// 

        private void cmdAddClo_Click(object sender, EventArgs e)
        {
            if (cmdAddClo.Text == "Add")
            {
                bool flag = false;
                if (txtCloName.Text == "")
                {
                    MessageBox.Show("Clo name canot be null");

                    flag = true;
                }
                if(flag== false)
                {
                    string qeury = "insert into dbo.Clo( Name,DateCreated,DateUpdated) values('" + this.txtCloName.Text + "','" + DateTime.Now + "','" + DateTime.Now + "')";
                    SqlConnection conDataBase = new SqlConnection(constring);
                    SqlCommand cmdDataBase = new SqlCommand(qeury, conDataBase);
                    SqlDataReader myreader;
                    conDataBase.Open();
                    myreader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("CLO has been Saved");
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
                        txtCloName.Text = "";
                    }

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
                MessageBox.Show("CLo has been Updated");
                cmdAddClo.Text = "Add";
                txtCloName.Text = "";
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
        /// <summary>
        /// This function also works int two parts. This is cell content click based 
        /// function.If the cell on which we click has a button with text delete than this
        /// function deletes the Clo information from Clo table where the id is equal
        /// to the id of row we clicked on. The other part of the function works if the button text
        /// is edit. The function than loads the values of columns of row selected or clicke to respective 
        /// text boxes i.e Name to txtCloname textbox so tht they can update the value.
        /// 
        /// </summary>
        /// 

        private void dataClo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            if (e.ColumnIndex == dataClo.Columns["delete"].Index)
            {
                
                int row = e.RowIndex;
                int id = Convert.ToInt32(dataClo.Rows[row].Cells[0].Value);
                //string id1 = dataClo.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                //id = Convert.ToInt32(id1); 
                string Qeury1 = "Delete from dbo.Rubric where CloId = '" + id + "'";
                SqlCommand cmd1 = new SqlCommand(Qeury1, connection);
                cmd1.ExecuteNonQuery();
                
                //MessageBox.Show("Rubric has been deleted");


                string Qeury = "Delete from dbo.Clo where ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(Qeury, connection);
                cmd.ExecuteNonQuery();
                this.dataClo.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("CLO has been deleted");
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
        /// <summary>
        ///This function is used to check the validations that the name should not
        /// contain number,symbols or any puntucation moreover it canot be null 
        ///
        /// </summary>
        /// 

        private void txtCloName_TextChanged(object sender, EventArgs e)
        {
            foreach (char a in txtCloName.Text)
            {
                if (char.IsDigit(a) || char.IsNumber(a) || char.IsPunctuation(a) || char.IsSymbol(a))
                {
                    MessageBox.Show("The CLO name you entered is Invalid");
                }
            }
            //if (txtCloName.Text == "")
            //{
              //  MessageBox.Show("Clo Name cannt be null");
            //}
        }
    }
}
    