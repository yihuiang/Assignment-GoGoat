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

    }
}


