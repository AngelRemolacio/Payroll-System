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


namespace FinalProject___Salary_Budgeting_System
{
    public partial class AdminForm : Form
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

        static MySqlConnection conn1 = null;

        static void connection()
        {
            string conn1string = "server=127.0.0.1; user = root; database = dbpayrollsystem; password = ";

            try
            {
                conn1 = new MySqlConnection(conn1string);
                conn1.Open();
                // MessageBox.Show("Connection Open.");

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

        public AdminForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            connection();
        }

        public void employee()
        {
            // TO PUT TABLE

            connection();
            string query = "SELECT ID_NUMBER, UserName, Password, FirstName, LastName, Address, Birthdate, Age, Sex FROM tblusers WHERE UserType = 'User'";
            DataTable Table = new DataTable();
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(query, conn1);
            mySqlAdapter.Fill(Table);
            dgvUsers.DataSource = Table;

        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            employee();

            panelHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelHeader.Width, panelHeader.Height, 15, 15));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 15, 15));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            btnDel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDel.Width, btnDel.Height, 15, 15));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 15, 15));
            btnCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCreate.Width, btnCreate.Height, 15, 15));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 15, 15));

            txtDOB.Text = "YYYY-MM-DD";
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
            }
        }

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLButtonDown, HT_Caption, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE tblusers SET UserName = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "', FirstName = '" + txtFname.Text + "', LastName = '" + txtLname.Text + "', Address = '" + txtAddress.Text + "', Age = " + txtAge.Text + ", Sex = '" + txtGender.Text + "' WHERE ID_NUMBER = " + txtIDnum.Text;

            try
            {
                conn1.Open();
                MySqlCommand cmdInsert = new MySqlCommand(queryUpdate, conn1);
                if (cmdInsert.ExecuteNonQuery() == 1)
                {
                    
                    MessageBox.Show("Record updated successfully..");
                    employee();
                }
                else
                {
                    MessageBox.Show("There's an error in updating the record.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string queryDel = "DELETE FROM tblusers WHERE ID_NUMBER = " + txtIDnum.Text;
            try
            {
                conn1.Open();
                MySqlCommand cmdInsert = new MySqlCommand(queryDel, conn1);
                if (MessageBox.Show("Are you sure you want to delete this record? Once deleted, the record is forever lost.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (cmdInsert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        employee();
                    }
                    else
                    {
                        MessageBox.Show("Record not deleted.");
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

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO tblusers (ID_NUMBER, UserType, UserName, Password, LastName, FirstName, Address, Birthdate, Age, Sex) VALUES ('" + txtIDnum.Text + "','User','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtLname.Text + "','" + txtFname.Text + "','" + txtAddress.Text + "','" + txtDOB.Text + "','" + txtAge.Text + "','" + txtGender.Text + "')";

            try
            {
                conn1.Open();
                MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn1);
                if (cmdInsert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account created successfully.");
                    employee();
                }
                else
                {
                    MessageBox.Show("There's an error in creating the account.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void txtIDnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDnum.Text = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
            txtLname.Text = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
            txtFname.Text = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = dgvUsers.SelectedRows[0].Cells[5].Value.ToString();
            txtDOB.Text = dgvUsers.SelectedRows[0].Cells[6].Value.ToString();
            txtAge.Text = dgvUsers.SelectedRows[0].Cells[7].Value.ToString();
            txtGender.Text= dgvUsers.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void txtDOB_Enter(object sender, EventArgs e)
        {
            if (txtDOB.Text == "YYYY-MM-DD")
            {
                txtDOB.Text = "";
            }
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            if (txtDOB.Text == "")
            {
                txtDOB.Text = "YYYY-MM-DD";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDnum.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "YYYY-MM-DD";
            txtAge.Text = "";
            txtGender.Text = "";
        }

        private void txtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
