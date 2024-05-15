using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Manager_asm.Pages
{
    public partial class Page_Reservation : UserControl
    {
        private void LoadReservationData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Reservation", conn);
                DataTable dt = new DataTable();
                
                dataGridView1.DataSource = dt;
            }
        }
        public Page_Reservation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Page_Reservation_Load(object sender, EventArgs e)
        {
           LoadReservationData();
        }

        private void lblreservation_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
