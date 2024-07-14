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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            panelSubmenuStudent.Visible = false;
            panelSubmenuTeacher.Visible = false;
            panelSubmenuNonAcade.Visible = false;


        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmhome());
            //hideSubMenu();
        }

        private void btnStud_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuStudent);

            sidepanelmark1.Height = btnStud.Height;//Side panel
            sidepanelmark1.Top = btnStud.Top;
        }

        private void btnAcade_Click_1(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnAcade.Height;//Side panel
            sidepanelmark1.Top = btnAcade.Top;
            showSubMenu(panelSubmenuTeacher);
        }

        private void btnNonacade_Click_1(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnNonacade.Height;//Side panel
            sidepanelmark1.Top = btnNonacade.Top;
            showSubMenu(panelSubmenuNonAcade);
        }


        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmhome());
            //hideSubMenu();
            sidepanelmark1.Height = btnDashboard.Height;//Side panel
            sidepanelmark1.Top = btnDashboard.Top;
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmStudentDetails());
            // hideSubMenu();
        }

        private void btnViewStud_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ViewSudent_Details());
        }

        private void btnAddacade_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmTeacherDetails());
        }

        private void btnViewAcade_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmViewTeacherDetails());
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmNonAcademic());
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new viewNonAcademicDetails());
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to exit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                //Environment.Exit(1);
                Application.Exit();
            }
            else if (dialogresult == DialogResult.No)
            {

            }
        }


    }
}
     
