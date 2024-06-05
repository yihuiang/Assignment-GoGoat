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
using System.IO;
using System.Drawing.Imaging;
using Manager_asm.Pages;

namespace Manager_asm
{
    public partial class Page_MenuCatalog_AddItem : Form
    {
        public Page_MenuCatalog_AddItem()
        {
            InitializeComponent();
        }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        
        
     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Page_MenuCatalog_AddItem_Load(object sender, EventArgs e)
        {

        }

        public void LoadMenuDateClick()
        {
            Page_MenuCatalog gv = new Page_MenuCatalog();
            List<string> selectedData = gv.GetSelectedMenuItemData();

            if (selectedData != null)
            {
                Bitmap img = (Bitmap)Image.FromFile(selectedData[0]); // Assuming image path is stored
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Or appropriate format

                pictureBox1.Image = Image.FromStream(ms);
                txtboxName.Text = selectedData[1];
                txtboxCat.Text = selectedData[2];
                txtboxprice.Text = selectedData[3];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMenuItem();
        }
            
        public void AddMenuItem()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            cmd = new SqlCommand("INSERT INTO Menu( Item, Category, Price, Image) VALUES (@item, @category, @price, @image)", con);
            cmd.Parameters.AddWithValue("@item", txtboxName.Text);
            cmd.Parameters.AddWithValue("@category", txtboxCat.Text);
            cmd.Parameters.AddWithValue("@price", txtboxprice.Text);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary, img.Length).Value = img;


            ExecMyQuery(cmd, "Data Inserted");
        }

        public void ExecMyQuery(SqlCommand cmd, string myMsg)
        {
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed");
            }
            con.Close();
        }
    }
}
