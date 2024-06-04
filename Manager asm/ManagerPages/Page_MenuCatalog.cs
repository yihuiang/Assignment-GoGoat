using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.Pages
{
    public partial class Page_MenuCatalog : UserControl
    {
     
        public Page_MenuCatalog()
        {
            InitializeComponent();
        }

        private void Page_MenuCatalog_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB; Integrated Security = True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Menu", conn);
            SqlDataReader da;
            da = cmd.ExecuteReader();
            while (da.Read())
            {
                
            }
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Page_MenuCatalog_AddItem Pg = new Page_MenuCatalog_AddItem();
            Pg.Show();
        }
    }
}
