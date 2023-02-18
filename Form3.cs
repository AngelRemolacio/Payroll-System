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
using System.Drawing.Printing;

namespace FinalProject___Salary_Budgeting_System
{
    public partial class PaySlipForm : Form
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

        PrintPreviewDialog prPreview = new PrintPreviewDialog();
        PrintDocument prPrint = new PrintDocument();

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

        PayrollSystem pSystem;

        public PaySlipForm(PayrollSystem copyPS)
        {
            InitializeComponent();
            this.pSystem = copyPS;

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        public void Print(Panel pnl)
        {
            PrinterSettings pS = new PrinterSettings();
            pnlPayslip = pnl;
            getPrintArea(pnl);
            prPreview.Document = prPrint;
            prPrint.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            prPreview.ShowDialog();

        }

        Bitmap memoryimg;
        public void getPrintArea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnClose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClose.Width, btnClose.Height, 15, 15));
            btnPrint.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPrint.Width, btnPrint.Height, 15, 15));

            lblName.Text = pSystem.txtFirstname.Text + " " + pSystem.txtLastname.Text;
            lblDept.Text = pSystem.txtDept.Text;
            lblPosition.Text = pSystem.txtPost.Text;
            lblDate.Text = pSystem.dtpPaydate.Text;
            lblCname.Text = pSystem.txtFirstname.Text + " " + pSystem.txtLastname.Text;
            lblHrate.Text = pSystem.txtHrlyrate.Text;
            lblOT.Text = pSystem.txtOT.Text;
            lblTotHrs.Text = pSystem.txtTotwh.Text;
            lblNighthrs.Text = pSystem.txtNightHrs.Text;
            lblNightOT.Text = pSystem.txtNightOT.Text;
            lblSSSP.Text = pSystem.txtSSStax.Text;
            lblHDMFP.Text = pSystem.txtPItax.Text;
            lblPHICP.Text = pSystem.txtPHtax.Text;
            lblTotDeductions.Text = pSystem.txtDeduct.Text;
            lblGpay.Text = pSystem.txtGrossp.Text;
            lblNpay.Text = pSystem.txtNetp.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaySlipForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.pnlPayslip);
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.pnlPayslip.Width / 2), this.pnlPayslip.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
