using Manager_asm.ChefPagess;
using Manager_asm.CustomerPages;
using Manager_asm.User_Control;
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
    public partial class frmChefUI : Form
    {
        public frmChefUI()
        {
            InitializeComponent();
        }

        private void frmChefUI_Load(object sender, EventArgs e)
        {

        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelChef.Controls.Clear();
            panelChef.Controls.Add(Page);
            Page.BringToFront();
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            Page_Ingredients_Chef page_Ingredients_Chef = new Page_Ingredients_Chef();
            addpage(page_Ingredients_Chef);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Page_Orders_Chef page_Orders_Chef = new Page_Orders_Chef();
            addpage(page_Orders_Chef);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile_Chef page_Profile_Chef = new Profile_Chef();
            addpage(page_Profile_Chef);
        }
    }
}
