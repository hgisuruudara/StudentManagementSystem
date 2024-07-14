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

namespace WindowsFormsApplication1
{
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFn.Focus();
            }

            else if (txtMn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMn.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtAdd1.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd1.Focus();
            }
            else if (txtAdd2.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd2.Focus();
            }

            else if (txtFathNa.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFathNa.Focus();
            }
            else if (txtFaOcc.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFaOcc.Focus();
            }

            else if (txtConFa.Text== "")
            {
                MessageBox.Show("Invalid Operation");
                txtConFa.Focus();
            }

        
            //Check wether empty

            else
            try
            {
                con.Open();
                string sql = "Insert into StudentDetails (AddminNo,FirstName ,MiddleName,LastName,DOB,Address1,Address2,FathersName,FatherOccu,FatheContact,MotherName,MotherOccu,MotherContact,GurdianAddress,RegDate) values('" + txtAddNo.Text + "','" + txtFn.Text + "','" + txtMn.Text + "','" + txtLn.Text + "','" + dtDbo.Text + "', '" + txtAdd1.Text + "', '" + txtAdd2.Text + "', '" + txtFathNa.Text + "', '" + txtFaOcc.Text + "', '" + txtConFa.Text + "', '" + txtMothNa.Text + "', '" + txtMaOcc.Text + "', '" + txtConMa.Text + "', '" + txtAddGuard.Text + "', '" + dtReg.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added");
                txtAddNo.Text = "";
                txtFn.Text = "";
                txtMn.Text = "";
                txtLn.Text = "";
                dtDbo.Text = "";
                txtAdd1.Text = "";
                txtAdd2.Text = "";
                txtFathNa.Text = "";
                txtFaOcc.Text = "";
                txtConFa.Text = "";
                txtMothNa.Text = "";
                txtMaOcc.Text = "";
                txtConMa.Text = "";
                txtAddGuard.Text = "";
                dtReg.Text = "";
                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(AddminNo as int)), 0)+1 FROM StudentDetails", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                txtAddNo.Text = dt.Rows[0][0].ToString();

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }  
        }

        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(AddminNo as int)), 0)+1 FROM StudentDetails", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtAddNo.Text = dt.Rows[0][0].ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFn.Focus();
            }

            else if (txtMn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMn.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtAdd1.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd1.Focus();
            }
            else if (txtAdd2.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd2.Focus();
            }

            else if (txtFathNa.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFathNa.Focus();
            }
            else if (txtFaOcc.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFaOcc.Focus();
            }

            else if (txtConFa.Text== "")
            {
                MessageBox.Show("Invalid Operation");
                txtConFa.Focus();
            }

        
            //Check wether empty

            else
                try
            {
                con.Open();
                string sql = "DELETE FROM StudentDetails where AddminNo ='" + txtAddNo.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Sucessfully");
                txtAddNo.Text = "";
                txtFn.Text = "";
                txtMn.Text = "";
                txtLn.Text = "";
                dtDbo.Text = "";
                txtAdd1.Text = "";
                txtAdd2.Text = "";
                txtFathNa.Text = "";
                txtFaOcc.Text = "";
                txtConFa.Text = "";
                txtMothNa.Text = "";
                txtMaOcc.Text = "";
                txtConMa.Text = "";
                txtAddGuard.Text = "";
                dtReg.Text = "";

                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(AddminNo as int)), 0)+1 FROM StudentDetails", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                txtAddNo.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM StudentDetails WHERE AddminNo ='" + txtAddNo.Text + "'";
                com = new SqlCommand(sql, con);
   

                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {


                    txtAddNo.Text = dr["AddminNo"].ToString();
                    txtFn.Text = dr["FirstName "].ToString();
                    txtMn.Text = dr["MiddleName"].ToString();
                    txtLn.Text = dr["LastName"].ToString();
                    dtDbo.Text = dr["DOB"].ToString();
                    txtAdd1.Text = dr["Address1"].ToString();
                    txtAdd2.Text = dr["Address2"].ToString();
                    txtFathNa.Text = dr["FathersName"].ToString();
                    txtFaOcc.Text = dr["FatherOccu"].ToString();
                    txtConFa.Text = dr["FatheContact"].ToString();
                    txtMothNa.Text = dr["MotherName"].ToString();
                    txtMaOcc.Text = dr["MotherOccu"].ToString();
                    txtConMa.Text = dr["MotherContact"].ToString();
                    txtAddGuard.Text = dr["GurdianAddress"].ToString();
                    dtReg.Text = dr["RegDate"].ToString();
                    

                }
                else
                    MessageBox.Show("Student Not Found");

                con.Close();
            }// end try
            catch (Exception error)
            {
                MessageBox.Show(error + "Invalid Database Operation");
            }
        }

        private void btnSearh_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                string sql = "SELECT * FROM StudentDetails WHERE AddminNo ='" + txtSearch.Text + "'";
                com = new SqlCommand(sql, con);


                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {


                    txtAddNo.Text = dr["AddminNo"].ToString();
                    txtFn.Text = dr["FirstName "].ToString();
                    txtMn.Text = dr["MiddleName"].ToString();
                    txtLn.Text = dr["LastName"].ToString();
                    dtDbo.Text = dr["DOB"].ToString();
                    txtAdd1.Text = dr["Address1"].ToString();
                    txtAdd2.Text = dr["Address2"].ToString();
                    txtFathNa.Text = dr["FathersName"].ToString();
                    txtFaOcc.Text = dr["FatherOccu"].ToString();
                    txtConFa.Text = dr["FatheContact"].ToString();
                    txtMothNa.Text = dr["MotherName"].ToString();
                    txtMaOcc.Text = dr["MotherOccu"].ToString();
                    txtConMa.Text = dr["MotherContact"].ToString();
                    txtAddGuard.Text = dr["GurdianAddress"].ToString();
                    dtReg.Text = dr["RegDate"].ToString();

                    txtSearch.Text = "Search";




                }
                else
                    MessageBox.Show("Student Not Found");
                    con.Close();


                
            }// end try

            catch (Exception )
            {
                MessageBox.Show("Enter Student Addmission No");
                con.Close();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddNo.Text = "";
            txtFn.Text = "";
            txtMn.Text = "";
            txtLn.Text = "";
            dtDbo.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtFathNa.Text = "";
            txtFaOcc.Text = "";
            txtConFa.Text = "";
            txtMothNa.Text = "";
            txtMaOcc.Text = "";
            txtConMa.Text = "";
            txtAddGuard.Text = "";
            dtReg.Text = "";
            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(AddminNo as int)), 0)+1 FROM StudentDetails", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtAddNo.Text = dt.Rows[0][0].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFn.Focus();
            }

            else if (txtMn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMn.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtAdd1.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd1.Focus();
            }
            else if (txtAdd2.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAdd2.Focus();
            }

            else if (txtFathNa.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFathNa.Focus();
            }
            else if (txtFaOcc.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFaOcc.Focus();
            }

            else if (txtConFa.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtConFa.Focus();
            }


            //Check wether empty

            else
            try
            {
               
                con.Open();
                //  UPDATE NAME
                string sqlst = "UPDATE StudentDetails SET FirstName ='" + txtFn.Text + "',MiddleName='" + txtMn.Text + "',LastName='" + txtLn.Text + "',DOB='" + dtDbo.Text + "',Address1='" + txtAdd1.Text + "',Address2='" + txtAdd2.Text + "',FathersName='" + txtFathNa.Text + "',FatherOccu='" + txtFaOcc.Text + "' ,FatheContact='" + txtConFa.Text + "',MotherName='" + txtMothNa.Text + "',MotherOccu='" + txtMaOcc.Text + "',MotherContact='" + txtConMa.Text + "',GurdianAddress='" + txtAddGuard.Text + "' WHERE AddminNo='" + txtAddNo.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sqlst, con);
                cmd1.ExecuteNonQuery();
                //UPDATE Details
                txtAddNo.Text = "";
                txtFn.Text = "";
                txtMn.Text = "";
                txtLn.Text = "";
                dtDbo.Text = "";
                txtAdd1.Text = "";
                txtAdd2.Text = "";
                txtFathNa.Text = "";
                txtFaOcc.Text = "";
                txtConFa.Text = "";
                txtMothNa.Text = "";
                txtMaOcc.Text = "";
                txtConMa.Text = "";
                txtAddGuard.Text = "";
                dtReg.Text = "";
                MessageBox.Show("Record Update");
                
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("INVALID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }
        }

    }
}
