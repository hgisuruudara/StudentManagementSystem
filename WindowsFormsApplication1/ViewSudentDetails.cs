using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql Enabling

namespace WindowsFormsApplication1
{
    public partial class ViewSudent_Details : Form
    {
        public ViewSudent_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;



        private void ViewSudent_Details_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT AddminNo,FirstName,MiddleName,LastName,DOB,Address1,Address2,FathersName,FatheContact,RegDate FROM StudentDetails";
            com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewStudDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchStud_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT AddminNo,FirstName,MiddleName,LastName,DOB,Address1,Address2,FathersName,FatheContact,RegDate FROM StudentDetails WHERE  AddminNo  like '%" + txtSearchStud.Text + "%' OR FirstName like '%" + txtSearchStud.Text + "%'OR LastName like '%" + txtSearchStud.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewStudDetails.DataSource = dt;              
            con.Close();
        }

    }
}
