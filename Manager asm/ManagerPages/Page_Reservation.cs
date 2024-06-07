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
   
        public Page_Reservation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Page_Reservation_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Date Time", 120);
            listView1.Columns.Add("Pax", 50);
            listView1.Columns.Add("Type", 120);
            listView1.Columns.Add("Status", 120);

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB; Integrated Security = True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Reservation where Status != 'Pending'", conn);
            SqlDataReader da;
            da = cmd.ExecuteReader();
            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());
                item1.SubItems.Add(da[4].ToString());
                
                
            }
            conn.Close();

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Date Time", 120);
            listView1.Columns.Add("Pax", 50);
            listView1.Columns.Add("Type", 120);
            listView1.Columns.Add("Status", 120);

            SqlConnection conn2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB; Integrated Security = True;");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Reservation where Status = 'Pending'", conn2);
            SqlDataReader da2;
            da2 = cmd2.ExecuteReader();
            while(da2.Read())
            {
                var item2 = listView2.Items.Add(da2[0].ToString());
                item2.SubItems.Add(da2[1].ToString());
                item2.SubItems.Add(da2[2].ToString());
                item2.SubItems.Add(da2[3].ToString());
                item2.SubItems.Add(da2[4].ToString());
                
            }
            conn2.Close();
        }

   
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
