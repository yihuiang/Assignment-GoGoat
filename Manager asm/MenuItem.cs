using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    public partial class btnitem : UserControl
    {
        private MenuZ menu;
 
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
            InitializeControls();
            
        }

        private void InitializeControls()
        {

            //picboxItemimg1 = new PictureBox();
            //lblItemName1 = new Label();
            //lblItemPrice1 = new Label();

            // Set control sizes
            picboxItemimg1.Size = new Size(150, 150);
            lblItemName1.Size = new Size(100, 40);
            lblItemPrice1.Size = new Size(100, 20);

            // Position controls
            picboxItemimg1.Location = new Point(20, 30);
            lblItemName1.Location = new Point(20, 200);
            lblItemPrice1.Location = new Point(20, 250);

            // Add controls to the user control
            Controls.Add(picboxItemimg1);
            Controls.Add(lblItemName1);
            Controls.Add(lblItemPrice1);

            // Set size of btnItem
            Size = new Size(200, 300);
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void picboxItemimg_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void btnitem_Load(object sender, EventArgs e)
        {

        }
    }
}
