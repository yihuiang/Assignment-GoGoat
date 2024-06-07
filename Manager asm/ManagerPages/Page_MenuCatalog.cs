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
using System.Drawing.Imaging;


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

        //ok
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Page_MenuCatalog_AddItem Pg = new Page_MenuCatalog_AddItem();
            Pg.Show();
        }

        //ok
        public void ShowMenuData()
        {
            cmd = new SqlCommand("Select * from Menu", con);
            da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridViewMenucat.RowTemplate.Height = 60;
            dataGridViewMenucat.AllowUserToAddRows = false;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewMenucat.DataSource = table;
            dataGridViewMenucat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            
        }
        //ok //Load Data for Update or delete
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Page_MenuCatalog_AddItem pg = new Page_MenuCatalog_AddItem();
            pg.txtboxName.Text = dataGridViewMenucat.CurrentRow.Cells[1].Value.ToString();
            pg.txtboxCat.Text = dataGridViewMenucat.CurrentRow.Cells[2].Value.ToString();
            pg.txtboxprice.Text = dataGridViewMenucat.CurrentRow.Cells[3].Value.ToString();
            byte[] imageBytes = (byte[])dataGridViewMenucat.CurrentRow.Cells[4].Value;
            if (imageBytes != null && imageBytes.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pg.picboxitem.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., invalid image data)
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
            pg.Show();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
