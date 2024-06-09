using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    public partial class btnitem : UserControl
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
       // private MenuZ menu;
        private Order currentOrder;

        public string ItemName
        {
            get { return lblItemName1.Text; }
            set { lblItemName1.Text = value; }
        }
        public string ItemPrice
        {
            get { return lblItemPrice1.Text; }
            set { lblItemPrice1.Text = value; }
        }
        public Image ItemImage
        {
            get { return picboxItemimg1.Image; }
            set { picboxItemimg1.Image = value; }
        }

        public btnitem()
        {
            InitializeComponent();
        }

        private void btnitem_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuZ menuItem = new MenuZ
            {
                Item = ItemName,
                Price = double.Parse(ItemPrice.Replace("RM", ""))
            };
            currentOrder.AddToCart(menuItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MenuZ menuItem = new MenuZ
            {
                Item = ItemName,
                Price = double.Parse(ItemPrice.Replace("RM", ""))
            };
            if (currentOrder.RemoveFromCart(menuItem))
            {
                MessageBox.Show($"{menuItem.Item} removed from cart");
            }


        }

        public void SetOrder(Order order)
        {
            currentOrder = order ?? throw new ArgumentNullException(nameof(order));
        }
    }
}



