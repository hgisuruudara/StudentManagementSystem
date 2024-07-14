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
    public partial class frmViewTeacherDetails : Form
    {
        public frmViewTeacherDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;
        private void frmViewTeacherDetails_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM TeacherDetails";
            com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewTeacherDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchStud_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM TeacherDetails WHERE  EmployeeNo  like '%" + txtTeacherStud.Text + "%' OR FirstName like '%" + txtTeacherStud.Text + "%'OR DOB like '%" + txtTeacherStud.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewTeacherDetails.DataSource = dt;
            con.Close();
        }
    }
}
