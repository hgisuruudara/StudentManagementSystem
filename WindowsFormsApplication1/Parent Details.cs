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
    public partial class frmmd : Form
    {
        public frmmd()
        {
            InitializeComponent();
        }

        private void cbotitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmmd_Load(object sender, EventArgs e)
        {
            cbotitle.Items.Add("Mr.");
            cbotitle.Items.Add("Mrs.");
            cbotitle.Items.Add("Dr.");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Students_Parents frmMDIParent = new Students_Parents();
            this.Hide();
            frmMDIParent.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
