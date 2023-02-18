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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

namespace FinalProject___Salary_Budgeting_System
{
    public partial class LoginForm : Form
    {
        static MySqlConnection conn1 = null;

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
        public LoginForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            connection();
        }

        static void connection()
        {
            string conn1string = "server=127.0.0.1; user = root; database = dbpayrollsystem; password = ";

            try
            {
                conn1 = new MySqlConnection(conn1string);
                conn1.Open();
                //MessageBox.Show("Connection Open.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        void login()
        {
            string Username = txtUsername.Text;
            string Password = txtPassw.Text;
            try
            {
                conn1.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT UserType, UserName, Password FROM tblUsers", conn1);
                MySqlDataReader sqlReader = mySqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (Username == sqlReader.GetString("UserName") && Password == sqlReader.GetString("Password"))
                    {
                        if ("Admin" == sqlReader.GetString("UserType"))
                        {
                            //MessageBox.Show("Authorized User", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            AdminForm Admin = new AdminForm();
                            Admin.Show();
                            return;;
                        }

                        else if ("User" == sqlReader.GetString("UserType"))// && Username == sqlReader.GetString("UserName") && Password == sqlReader.GetString("Password"))
                        {
                            //MessageBox.Show("Authorized User", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            HomeForm Home = new HomeForm();
                            Home.Show();
                            return;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
            MessageBox.Show("There's no account associated with the username.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnClear.PerformClick();
        }

         private void LoginForm_Load(object sender, EventArgs e)
            {
                btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 5, 5));
                btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 5, 5));
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                login();   
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtPassw.Clear();
                txtUsername.Clear();
            }

            private void LoginForm_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
                }
            }

            private void panel1_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
                }
            }

            private void btnShowpassw_Click(object sender, EventArgs e)
            {
                if (txtPassw.PasswordChar == '●')
                {
                    btnHidepassw.BringToFront();
                    txtPassw.PasswordChar = '\0';
                }
            }

            private void btnHidepassw_Click(object sender, EventArgs e)
            {
                if (txtPassw.PasswordChar == '\0')
                {
                    btnShowpassw.BringToFront();
                    txtPassw.PasswordChar = '●';
                }
            }

            private void txtPassw_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click((Object)sender, (EventArgs)e);
                }
            }
        }
    }


