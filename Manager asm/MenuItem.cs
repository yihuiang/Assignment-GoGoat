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

        
        public btnitem()
        {
            InitializeComponent();
            picboxItemimg = new PictureBox();
            lblItemName = new Label();
            lblItemPrice = new Label();

            // Set control sizes
            picboxItemimg.Size = new Size(100, 100); // Adjust size as needed
            lblItemName.Size = new Size(100, 20);
            lblItemPrice.Size = new Size(100, 20);

            // Position controls
            picboxItemimg.Location = new Point(0, 0);
            lblItemName.Location = new Point(0, 110);
            lblItemPrice.Location = new Point(0, 130);

            // Add controls to the user control
            this.Controls.Add(picboxItemimg);
            this.Controls.Add(lblItemName);
            this.Controls.Add(lblItemPrice);

            // Set size of btnItem
            this.Size = new Size(120, 160);
        }
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

        private void btnitem_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
