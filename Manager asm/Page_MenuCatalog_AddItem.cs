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
using Manager_asm;

namespace Manager_asm
{
    public partial class Page_MenuCatalog_AddItem : Form
    {
        
        public Page_MenuCatalog_AddItem()
        {
            InitializeComponent();
            
        }

        //ok
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picboxitem.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Page_MenuCatalog_AddItem_Load(object sender, EventArgs e)
        {
            /*
            MenuZ obj = new MenuZ();
            MenuZ.LoadMenuData(obj);

            txtboxName.Text = obj.Item;
            txtboxCat.Text = obj.Category;
            txtboxprice.Text = obj.Price.ToString();// Convert double to string
            picboxitem.Image = obj.Image; 
            */
        }

        //ok //add
        private void button2_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(txtboxprice.Text, out price))
            {
                MenuZ obj1 = new MenuZ(txtboxName.Text, txtboxCat.Text, price, picboxitem.Image);
                MessageBox.Show(obj1.AddMenuItem());
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }

        }
        //ok //update
        private void btnupdate_Click(object sender, EventArgs e)
        {
            double price;
            if (double.TryParse(txtboxprice.Text, out price))
            {
                MenuZ obj2 = new MenuZ(txtboxName.Text, txtboxCat.Text, price, picboxitem.Image);
                MessageBox.Show(obj2.UpdateMenuItem());
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid price value. Please enter a valid number.");
            }
        }
        //ok //delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            MenuZ obj3 = new MenuZ(txtboxName.Text);
            MessageBox.Show(obj3.DeleteMenuItem());
            this.Close();
        }
    }
}
