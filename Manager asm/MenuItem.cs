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
        

        public Image ItemImage
        {
            get { return picboxItemimg.Image; }
            set { picboxItemimg.Image = value; }
        }
        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }
        public string ItemPrice
        {
            get { return lblItemPrice.Text; }
            set { lblItemPrice.Text = value; }
        }

        public btnitem()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            picboxItemimg = new PictureBox();
            lblItemName = new Label();
            lblItemPrice = new Label();

            // Set control sizes
            picboxItemimg.Size = new Size(100, 100);
            lblItemName.Size = new Size(100, 20);
            lblItemPrice.Size = new Size(100, 20);

            // Position controls
            picboxItemimg.Location = new Point(0, 0);
            lblItemName.Location = new Point(0, 110);
            lblItemPrice.Location = new Point(0, 130);

            // Add controls to the user control
            Controls.Add(picboxItemimg);
            Controls.Add(lblItemName);
            Controls.Add(lblItemPrice);

            // Set size of btnItem
            Size = new Size(180, 300);
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
