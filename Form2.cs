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
    public partial class PayrollSystem : Form
    {
        static MySqlConnection conn1 = null;
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlCommand cmd;

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

        public PayrollSystem()
        {
            InitializeComponent();

            connection();

        }

        public void employee()
        {
            connection();
            string query = "SELECT * FROM tblemployee";
            DataTable Table = new DataTable();
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(query,conn1);
            mySqlAdapter.Fill(Table);
            dgvPayroll.DataSource = Table;

        }

        public void Search(string searchData)
        {
            connection();

            string querySearch = "SELECT * FROM tblemployee WHERE CONCAT(`ID_Number`, `LastName`, `FirstName`, `Mobile`, `Address`, `Department`, `Position`, `SSS_ID`, `PagIbig_ID`, `PhilHealth_ID`, `TIN_ID`, `Total_Work_Hours`, `Total_Over_Time`, `Night_Over_Time`, `Total_Contribution`, `Net_Pay`, `Gross_Pay`) LIKE '%" + searchData + "%'";
            cmd = new MySqlCommand(querySearch, conn1);
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            dgvPayroll.DataSource = table;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //employee();
            Search("");

            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 15, 15));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 15, 15));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 15, 15));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 15, 15));
            panelPayroll.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelPayroll.Width, panelPayroll.Height, 15, 15));

            btnCalculate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCalculate.Width, btnCalculate.Height, 5, 5));
            btnCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCreate.Width, btnCreate.Height, 5, 5));
            btnDel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDel.Width, btnDel.Height, 5, 5));
            btnUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUpdate.Width, btnUpdate.Height, 5, 5));
            btnPayslip.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPayslip.Width, btnPayslip.Height, 5, 5));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 5, 5));
            txtSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtSearch.Width, txtSearch.Height, 7, 7));

            txtSearch.Text = "Search...";
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            PaySlipForm paySlipForm = new PaySlipForm(this);
            paySlipForm.ShowDialog();
            
        }

        private void txtIdnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void txtSSSid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtPIid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtPhid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtTINid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtHrlyrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtOT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double SSSPercent = .0225;
            double PIPercent = .01;
            double PHPercent = .0225;
            double nightDPercent = .1;
            double TaxDeduct;
            double nightDP = nightDPercent * Convert.ToDouble(txtHrlyrate.Text);
            double ndpOT = nightDP * Convert.ToDouble(txtNightOT.Text);
            double ndpHrs = nightDP * Convert.ToDouble(txtNightHrs.Text);
            double totalWHrs = Convert.ToDouble(txtTotwh.Text) - Convert.ToDouble(txtNightHrs.Text) + Convert.ToDouble(txtOT.Text);
            double Grosspay = (Convert.ToDouble(txtHrlyrate.Text) * totalWHrs) + ndpHrs +ndpOT;

            double SSStaxd =  Grosspay * SSSPercent;
            double PItaxd = Grosspay * PIPercent;
            double PHtaxd = Grosspay * PHPercent;
            TaxDeduct = SSStaxd + PItaxd + PHtaxd;


            txtSSStax.Text = SSStaxd.ToString();
            txtPItax.Text = PItaxd.ToString();
            txtPHtax.Text = PHtaxd.ToString();

            txtDeduct.Text = TaxDeduct.ToString();
            txtGrossp.Text = Grosspay.ToString();
            txtNetp.Text = (Grosspay - TaxDeduct).ToString();

            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdnum.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMobile.Text = "";
            txtAddr.Text = "";
            txtPost.Text = "";
            txtDept.Text = "";
            txtSSSid.Text = "";
            txtPhid.Text = "";
            txtPIid.Text = "";
            txtTINid.Text = "";
            dtpPaydate.ResetText();
            txtHrlyrate.Text = "0";
            txtTotwh.Text = "0";
            txtOT.Text = "0";
            txtNightOT.Text = "0";
            txtNightHrs.Text = "0";
            txtSSStax.Text = "";
            txtPItax.Text = "";
            txtPHtax.Text = "";
            txtNetp.Text = "0";
            txtGrossp.Text = "0";
            txtDeduct.Text = "0";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click((Object)sender, (EventArgs)e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchData = txtSearch.Text.ToString();
            Search(searchData);
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string queryDel = "DELETE FROM tblemployee WHERE ID_NUMBER = " + txtIdnum.Text;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO tblemployee (ID_NUMBER, LastName, FirstName, Mobile, Address, Department, Position, SSS_ID, PagIbig_ID, PhilHealth_ID, TIN_ID, Total_Work_Hours, Total_Over_Time, Night_Over_Time, Total_Contribution, Net_Pay, Gross_Pay) " +
                "VALUES ('" + txtIdnum.Text + "','" + txtLastname.Text + "','" + txtFirstname.Text + "','" + txtMobile.Text + "','" + txtAddr.Text + "','" + txtDept.Text + "','" + txtPost.Text + "','" + txtSSSid.Text + "','" + txtPIid.Text + "','" + txtPhid.Text + "','" + txtTINid.Text + "','" + txtTotwh.Text + "','" + txtOT.Text + "','" + txtNightOT.Text + "','" + txtDeduct.Text + "','" + txtNetp.Text + "','" + txtGrossp.Text + "')";

            try
            {
                conn1.Open();
                MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn1);
                if (cmdInsert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Record created successfully.");
                    employee();
                    
                }
                else
                {
                    MessageBox.Show("There's an error in creating the record.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE tblemployee SET LastName = '" + txtLastname.Text + "', FirstName = '" + txtFirstname.Text + "', Mobile = '" + txtMobile.Text + "', Address = '" + txtAddr.Text + "', Department = '" + txtDept.Text + "', Position = '" + txtPost.Text + "', SSS_ID = '" + txtSSSid.Text + "', PagIbig_ID = '" + txtPIid.Text + "', PhilHealth_ID = '" + txtPhid.Text + "', TIN_ID = '" + txtTINid.Text + "', Total_Work_Hours = Total_Work_Hours + '" + txtTotwh.Text + "', Total_Over_Time = Total_Over_Time +'" + txtOT.Text +"', Night_Over_Time = Night_Over_Time + '" + txtNightOT.Text + "', Total_Contribution = Total_Contribution + '" + txtDeduct.Text + "', Net_Pay = Net_Pay + '" + txtNetp.Text + "', Gross_Pay = Gross_Pay + '" + txtGrossp.Text +"' WHERE ID_NUMBER = " + txtIdnum.Text;

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

        private void txtNightHrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNightOT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
            }
        }

        private void dgvPayroll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdnum.Text = dgvPayroll.SelectedRows[0].Cells[0].Value.ToString();
            txtLastname.Text = dgvPayroll.SelectedRows[0].Cells[1].Value.ToString();
            txtFirstname.Text = dgvPayroll.SelectedRows[0].Cells[2].Value.ToString();
            txtMobile.Text = dgvPayroll.SelectedRows[0].Cells[3].Value.ToString();
            txtAddr.Text = dgvPayroll.SelectedRows[0].Cells[4].Value.ToString();
            txtDept.Text = dgvPayroll.SelectedRows[0].Cells[5].Value.ToString();
            txtPost.Text = dgvPayroll.SelectedRows[0].Cells[6].Value.ToString();
            txtSSSid.Text = dgvPayroll.SelectedRows[0].Cells[7].Value.ToString();
            txtPIid.Text = dgvPayroll.SelectedRows[0].Cells[8].Value.ToString();
            txtPhid.Text = dgvPayroll.SelectedRows[0].Cells[9].Value.ToString();
            txtTINid.Text = dgvPayroll.SelectedRows[0].Cells[10].Value.ToString();
            //txtTotwh.Text = dgvPayroll.SelectedRows[0].Cells[11].Value.ToString();
            //txtOT.Text = dgvPayroll.SelectedRows[0].Cells[12].Value.ToString();
            //txtNightOT.Text = dgvPayroll.SelectedRows[0].Cells[13].Value.ToString();
            //txtDeduct.Text = dgvPayroll.SelectedRows[0].Cells[14].Value.ToString();
            //txtNetp.Text = dgvPayroll.SelectedRows[0].Cells[15].Value.ToString();
            //txtGrossp.Text = dgvPayroll.SelectedRows[0].Cells[16].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            employee();
        }
    }
}
