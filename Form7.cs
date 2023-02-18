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
    public partial class Utilityform : Form
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


        public Utilityform()
        {
            InitializeComponent();
            connection();
            //dgvUtility.ColumnCount = 13;
            //dgvUtility.Columns[0].Name = "ID Number";
            //dgvUtility.Columns[1].Name = "Name";
            //dgvUtility.Columns[2].Name = "Mobile";
            //dgvUtility.Columns[3].Name = "Address";
            //dgvUtility.Columns[4].Name = "Position";
            //dgvUtility.Columns[5].Name = "SSS ID";
            //dgvUtility.Columns[6].Name = "Pag-ibig ID";
            //dgvUtility.Columns[7].Name = "TIN ID";
            //dgvUtility.Columns[8].Name = "Total work hours";
            //dgvUtility.Columns[9].Name = "Overtime";
            //dgvUtility.Columns[10].Name = "Deductions";
            //dgvUtility.Columns[11].Name = "Net Pay";
            //dgvUtility.Columns[12].Name = "Gross Pay";
        }

        public void employee()
        {
            // TO PUT TABLE

            connection();
            string query = "SELECT ID_Number, CONCAT(FirstName, ' ', LastName) AS Name, Mobile, Address, Position, SSS_ID, PagIbig_ID, PhilHealth_ID, TIN_ID, Total_Work_Hours, Total_Over_Time, Night_Over_Time, Total_Contribution, Net_Pay, Gross_Pay FROM tblemployee WHERE Department = 'Utility'";
            DataTable Table = new DataTable();
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(query, conn1);
            mySqlAdapter.Fill(Table);
            dgvUtility.DataSource = Table;

        }



        private void Utilityform_Load(object sender, EventArgs e)
        {
            employee();
        }


    }
}
