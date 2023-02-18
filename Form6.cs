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
    public partial class MISform : Form
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


        public MISform()
        {
            InitializeComponent();
            connection();

        }

        public void employee()
        {
            // TO PUT TABLE

            connection();
            string query = "SELECT ID_Number, CONCAT(FirstName, ' ', LastName) AS Name, Mobile, Address, Position, SSS_ID, PagIbig_ID, PhilHealth_ID, TIN_ID, Total_Work_Hours, Total_Over_Time, Night_Over_Time, Total_Contribution, Net_Pay, Gross_Pay FROM tblemployee WHERE Department = 'MIS'";
            DataTable Table = new DataTable();
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(query, conn1);
            mySqlAdapter.Fill(Table);
            dgvMIS.DataSource = Table;

        }


        private void MISform_Load(object sender, EventArgs e)
        {
            employee();

        }

    }
}
