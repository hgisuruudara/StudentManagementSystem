using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String un = "School123";
            String pw = "School123";

            if (txtUn.Text == un && txtPass.Text == pw)
            {
                MessageBox.Show("Sucessfully Logged In");

               frmMenu_Form objFrmsign = new frmMenu_Form();
                this.Hide();
                objFrmsign.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

            txtUn.Focus();
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void txtUn_Enter(object sender, EventArgs e)
        {
            txtUn.Text = "";
        }

        private void txtUn_Leave(object sender, EventArgs e)
        {
            if(txtUn.Text=="")
            {
                txtUn.Text = "USER NAME";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void txtUn_TextChanged(object sender, EventArgs e)
        {

        }

 

    }
}
