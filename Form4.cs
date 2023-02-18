using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace FinalProject___Salary_Budgeting_System
{
    public partial class HomeForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );

        public const int WM_NCLButtonDown = 0xA1;
        public const int HT_Caption = 0x2;
        private const int dshadow = 0x00020000;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParams = base.CreateParams;
                cParams.ClassStyle |= dshadow;
                return cParams;
            }

        }
        public HomeForm()
        {
            InitializeComponent();
            customDesign();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void customDesign()
        {
            panelEmployee.Visible = false;
        }

        private void subMenuHide()
        { 
            if (panelEmployee.Visible == true)
            {
                panelEmployee.Visible = false;
            }
        } 

        private void subMenuShow(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                
                subMenu.Visible = true;
            }
            else
            {
                subMenuHide();
                subMenu.Visible = false;
            }
        }

        private Form formActive = null;
        private void openForm( Form childForm )
        {
            if (formActive != null)
                formActive.Close();
            formActive = childForm;
            childForm.TopLevel = false;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Close();
            loginForm.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPayrollsystem_Click_1(object sender, EventArgs e)
        {
            openForm(new PayrollSystem());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            subMenuShow(panelEmployee);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            openForm(new subHomeform());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
           openForm(new Securityform());
        }

        private void btnMIS_Click(object sender, EventArgs e)
        {
            openForm(new MISform());
        }

        private void btnUtility_Click(object sender, EventArgs e)
        {
            openForm(new Utilityform());
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            openForm(new Facilityform());
        }

        private void btnHr_Click(object sender, EventArgs e)
        {
            openForm(new HRform());
        }

        private void btnGuidance_Click(object sender, EventArgs e)
        {
            openForm(new Guidanceform());
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            openForm(new Healthform());
        }

        private void btnLib_Click(object sender, EventArgs e)
        {
            openForm(new Libraryform());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            openForm(new Registrarform());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openForm(new subHomeform());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openForm(new Helpform());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                Visible = false;
            }
        }
    }
}
