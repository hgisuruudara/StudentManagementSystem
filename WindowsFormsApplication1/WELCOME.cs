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
    public partial class frmwelcome : Form
    {
        public frmwelcome()
        {
            InitializeComponent();
        }

        private void btnctl_Click(object sender, EventArgs e)
        {
            
        }
   
        private void btnctl_Click_1(object sender, EventArgs e)
        {
            frmlogin frmMDIParent = new frmlogin();
            this.Hide();
            frmMDIParent.Show();
        }
    }
}
