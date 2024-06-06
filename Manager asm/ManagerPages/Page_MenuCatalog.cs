using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_asm.Pages
{
    public partial class Page_MenuCatalog : UserControl
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        
        static SqlDataAdapter da;


        public Page_MenuCatalog()
        {
            InitializeComponent();
        }

        private void Page_MenuCatalog_Load(object sender, EventArgs e)
        {

            ShowMenuData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Page_MenuCatalog_AddItem Pg = new Page_MenuCatalog_AddItem();
            Pg.Show();
        }
        public void ShowMenuData()
        {
            cmd = new SqlCommand("Select * from Menu", con);
            da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            GetSelectedMenuItemData();
        }

        public List<string> GetSelectedMenuItemData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                return new List<string>
                {
                    (string)row.Cells[4].Value, // Image path (assuming it's stored as a string)
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString()
                };
            }
            return null; // Or throw an exception if no row is selected
        }
    }
}
