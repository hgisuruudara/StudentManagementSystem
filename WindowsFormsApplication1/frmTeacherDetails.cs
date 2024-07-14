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
    public partial class frmTeacherDetails : Form
    {
        public frmTeacherDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpNo.Text = "";
            cmbTitle.Text= "Enter Title";
            txtFN.Text = "";
            txtLn.Text = "";
            dtDbo.Text = "";
            txtMob.Text = "";
            txtLandline.Text = "";
            cmbQualifi.Text = "";
            txtYearsofEx.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            dtReg.Text = "";

            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM TeacherDetails", con);
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

            else if (cmbQualifi.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbQualifi.Focus();
            }
            else if (txtYearsofEx.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtYearsofEx.Focus();
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
                    string sql = "Insert into TeacherDetails (EmployeeNo,Title ,FirstName,LastName,DOB,MobileNo,LandLine,Qualification,YearOfExp,Address,City,State,RegDate) values('" + txtEmpNo.Text + "','" + cmbTitle.Text + "','" + txtFN.Text + "','" + txtLn.Text + "','" + dtDbo.Text + "', '" + txtMob.Text + "', '" + txtLandline.Text + "', '" + cmbQualifi.Text + "', '" + txtYearsofEx.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtState.Text + "', '" + dtReg.Text + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Teacher Successfully Added");
                    txtEmpNo.Text = "";
                    cmbTitle.Text = string.Empty;
                    txtFN.Text = "";
                    txtLn.Text = "";
                    dtDbo.Text = "";
                    txtMob.Text = "";
                    txtLandline.Text = "";
                    cmbQualifi.Text = string.Empty;
                    txtYearsofEx.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    txtState.Text = "";
                    dtReg.Text = "";
                    SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM TeacherDetails", con);
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

            else if (cmbQualifi.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbQualifi.Focus();
            }
            else if (txtYearsofEx.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtYearsofEx.Focus();
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
                string sqlst = "UPDATE TeacherDetails SET EmployeeNo ='" + txtEmpNo.Text + "',Title='" + cmbTitle.Text + "',FirstName='" + txtFN.Text + "',LastName='" + txtLn.Text + "',DOB='" + dtDbo.Text + "',MobileNo='" + txtMob.Text + "',LandLine='" + txtLandline.Text + "',Qualification='" + cmbQualifi.Text + "',YearOfExp='" + txtYearsofEx.Text + "' ,Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',State='" + txtState.Text + "',RegDate='" + dtReg.Text + "' WHERE EmployeeNo='" + txtEmpNo.Text + "'";
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
                cmbQualifi.Text = "";
                txtYearsofEx.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                dtReg.Text = "";
                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM TeacherDetails", con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                txtEmpNo.Text = dt.Rows[0][0].ToString();
                con.Close();
                MessageBox.Show("Record Update");

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

            else if (cmbQualifi.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                cmbQualifi.Focus();
            }
            else if (txtYearsofEx.Text == "")
            {
                MessageBox.Show("Invalid Operation");
                txtYearsofEx.Focus();
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
                string sql = "DELETE FROM TeacherDetails where EmployeeNo ='" + txtEmpNo.Text + "'";
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
                cmbQualifi.Text = "";
                txtYearsofEx.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtState.Text = "";
                dtReg.Text = "";
                con.Close();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM TeacherDetails", con);
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

        private void btnSearh_Click(object sender, EventArgs e)
        {

      
                con.Open();
                string sql = "SELECT * FROM TeacherDetails where EmployeeNo ='" + txtSearch.Text + "'";
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
                    cmbQualifi.Text = dr["Qualification"].ToString();
                    txtYearsofEx.Text = dr["YearOfExp"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    txtCity.Text = dr["City"].ToString();
                    txtState.Text = dr["State"].ToString();
                    dtReg.Text = dr["RegDate"].ToString();

                    con.Close();


                }
                else
                {
                    MessageBox.Show("Teacher Record Not Found");
                con.Close();
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
            cmbQualifi.Text = "";
            txtYearsofEx.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            dtReg.Text = "";

            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(EmployeeNo as int)), 0)+1 FROM TeacherDetails", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtEmpNo.Text = dt.Rows[0][0].ToString();
        }

        private void frmTeacherDetails_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("SELECT isnull (max(cast(AddminNo as int)), 0)+1 FROM StudentDetails", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            txtEmpNo.Text = dt.Rows[0][0].ToString();
        }
    }
}
