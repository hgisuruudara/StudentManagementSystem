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
    public partial class frmNonAcademic : Form
    {
        public frmNonAcademic()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpNo.Text = "";
            cmbTitle.Text = "";
            txtFN.Text = "";
            txtLn.Text = "";
            dtDbo.Text = "";
            txtMob.Text = "";
            txtLandline.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            dtReg.Text = "";

            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtEmpNo.Text = dt.Rows[0][0].ToString();
        }

        private void frmNonAcademic_Load(object sender, EventArgs e)
        {
            cmbTitle.SelectedIndex = 3;
            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtEmpNo.Text = dt.Rows[0][0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTitle.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbTitle.Focus();
            }

            else if (txtFN.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFN.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtMob.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMob.Focus();
            }
            else if (txtLandline.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLandline.Focus();
            }

            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtCity.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtState.Focus();
            }

            //Check wether empty

            else

                try
                {
                    con.Open();
                    string sql = "Insert into NonAcademic (EmployeeNo,Title,FirstName,LastName,DOB,MobileNo,LandLine,Address,City,State,RegDate) values('" + txtEmpNo.Text + "','" + cmbTitle.Text + "','" + txtFN.Text + "','" + txtLn.Text + "','" + dtDbo.Text + "', '" + txtMob.Text + "', '" + txtLandline.Text + "','" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', '" + dtReg.Text + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully Added");
                    txtEmpNo.Text = "";
                    cmbTitle.Text = string.Empty;
                    txtFN.Text = "";
                    txtLn.Text = "";
                    dtDbo.Text = "";
                    txtMob.Text = "";
                    txtLandline.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    txtState.Text = "";
                    dtReg.Text = "";

                    SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    txtEmpNo.Text = dt.Rows[0][0].ToString();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("INVALID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                        if (cmbTitle.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbTitle.Focus();
            }

            else if (txtFN.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFN.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtMob.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMob.Focus();
            }
            else if (txtLandline.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLandline.Focus();
            }

            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtCity.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtState.Focus();
            }

            //Check wether empty

            else
                         
                 try
            {

                con.Open();
                //  UPDATE NAME
                string sqlst = "UPDATE NonAcademic SET EmployeeNo ='" + txtEmpNo.Text + "',Title='" + cmbTitle.Text + "',FirstName='" + txtFN.Text + "',LastName='" + txtLn.Text + "',DOB='" + dtDbo.Text + "',MobileNo='" + txtMob.Text + "',LandLine='" + txtLandline.Text + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',State='" + txtState.Text + "',RegDate='" + dtReg.Text + "' WHERE EmployeeNo='" + txtEmpNo.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sqlst, con);
                cmd1.ExecuteNonQuery();
                //UPDATE Details
                txtEmpNo.Text = "";
                cmbTitle.Text = "Enter Title";
                txtFN.Text = "";
                txtLn.Text = "";
                dtDbo.Text = "";
                txtMob.Text = "";
                txtLandline.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                dtReg.Text = "";
                con.Close();
                MessageBox.Show("Record Updated");

                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                txtEmpNo.Text = dt.Rows[0][0].ToString();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("INVALID", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                        if (cmbTitle.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbTitle.Focus();
            }

            else if (txtFN.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtFN.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLn.Focus();
            }

            else if (txtMob.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtMob.Focus();
            }
            else if (txtLandline.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtLandline.Focus();
            }

            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtAddress.Focus();
            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtCity.Focus();
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtState.Focus();
            }

            //Check wether empty

            else
                   try
            {
                con.Open();
                string sql = "DELETE FROM NonAcademic where EmployeeNo ='" + txtEmpNo.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Sucessfully");
                txtEmpNo.Text = "";
                cmbTitle.Text = "";
                txtFN.Text = "";
                txtLn.Text = "";
                dtDbo.Text = "";
                txtMob.Text = "";
                txtLandline.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                dtReg.Text = "";
                con.Close();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                txtEmpNo.Text = dt.Rows[0][0].ToString();
                con.Close();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtEmpNo.Text = "";
            cmbTitle.Text = "Enter Title";
            txtFN.Text = "";
            txtLn.Text = "";
            dtDbo.Text = "";
            txtMob.Text = "";
            txtLandline.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            dtReg.Text = "";

            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM NonAcademic", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtEmpNo.Text = dt.Rows[0][0].ToString();
        }

        private void btnSearh_Click(object sender, EventArgs e)
        {


            con.Open();
            string sql = "SELECT * FROM NonAcademic where EmployeeNo ='" + txtSearch.Text + "'";
            com = new SqlCommand(sql, con);


            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {

                txtEmpNo.Text = dr["EmployeeNo"].ToString();
                cmbTitle.Text = dr["Title"].ToString();
                txtFN.Text = dr["FirstName"].ToString();
                txtLn.Text = dr["LastName"].ToString();
                dtDbo.Text = dr["DOB"].ToString();
                txtMob.Text = dr["MobileNo"].ToString();
                txtLandline.Text = dr["LandLine"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                dtReg.Text = dr["RegDate"].ToString();

                con.Close();


            }
            else
            {
                MessageBox.Show("Record Not Found");
                con.Close();
            }
        }
    }
}
