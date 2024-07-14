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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

  

   

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String us, pass;

            us =( "Sauru");
            pass =("Ravindu123");

            if ((txtun.Text == us && txtpw.Text == pass))
            {
                MessageBox.Show("Sucessfully Logged In");
                Loading s = new Loading();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtun.Focus();
                txtpw.Clear();
                txtun.Clear();

            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpw.UseSystemPasswordChar = true;
            txtpw.ForeColor = Color.Black;
            txtpw.Focus();
        }

        private void checkboxpw_CheckedChanged(object sender, EventArgs e)
        {
            txtpw.UseSystemPasswordChar = true;
            txtpw.ForeColor = Color.Black;
            txtpw.Focus();
        }


    }
}
