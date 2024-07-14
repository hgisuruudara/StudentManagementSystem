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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Isuru Udara\Desktop\nangis DOCS\Student Management System\WindowsFormsApplication1\StudentManagement.mdf;Integrated Security=True");
        SqlCommand com;
        SqlCommand com1;
        SqlCommand com2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhrs.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy,");
            lblday.Text = DateTime.Now.ToString("dddd");
        }

        private void frmhome_Load(object sender, EventArgs e)
        {
            timer1.Start();



            try
            {
                con.Open();
                string sql = "SELECT COUNT (AddminNo) FROM StudentDetails";
                string sql1 = "SELECT COUNT (EmployeeNo) FROM TeacherDetails";
                string sql2 = "SELECT COUNT (EmployeeNo) FROM NonAcademic";

                com = new SqlCommand(sql, con);
                com1 = new SqlCommand(sql1, con);
                com2 = new SqlCommand(sql2, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();

                Int32 rows_count1 = Convert.ToInt32(com1.ExecuteScalar());
                com1.Dispose();


                Int32 rows_count2 = Convert.ToInt32(com2.ExecuteScalar());
                com2.Dispose();

                con.Close();

                // display data on the page
                lblStudAmount.ForeColor = Color.White;
                lblStudAmount.Text = rows_count.ToString();

                lblTeacherAmount.ForeColor = Color.White;
                lblTeacherAmount.Text = rows_count1.ToString();

                lblNonAcadeAmount.ForeColor = Color.White;
                lblNonAcadeAmount.Text = rows_count2.ToString();

            }

            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }


    }
}
