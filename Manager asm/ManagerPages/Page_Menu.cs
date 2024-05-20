using Manager_asm.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.User_Control
{
    public partial class Page_Menu : UserControl
    {
        public Page_Menu()
        {
            InitializeComponent();
            Page_Menu_All page_Menu_All = new Page_Menu_All();
            addpage(page_Menu_All);
        }



        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelMenus.Controls.Clear();
            panelMenus.Controls.Add(Page);
            Page.BringToFront();
        }



        private void Page_Menu_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Page_Menu_Noodles page_Menu_Noodles = new Page_Menu_Noodles();
            addpage(page_Menu_Noodles );
        }



        private void panelmenu01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It works");

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Page_Menu_All page_Menu_All = new Page_Menu_All();
            addpage(page_Menu_All);
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            Page_Menu_Sandwich page_Menu_Sandwich = new Page_Menu_Sandwich();
            addpage(page_Menu_Sandwich);
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            Page_Menu_Beverages page_Menu_Beverages = new Page_Menu_Beverages();
            addpage(page_Menu_Beverages);
        }
    }
}


