using Manager_asm.Pages;
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

namespace Manager_asm.User_Control
{
    public partial class Page_Menu : UserControl
    {
        private MenuZ menu;
       // private Order order;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
       
        
        public Page_Menu()
        {
            InitializeComponent();
            menu  = new MenuZ();
            
        }
        private void LoadMenuItems(string category)
        {
            flowLayoutPanelMenu.Controls.Clear();
            menu.LoadMenuItems(flowLayoutPanelMenu, category);
        }

        private void Page_Menu_Load(object sender, EventArgs e)
        {
            //order = new Order(lstCart);
            //order.DisplayCart();
            LoadMenuItems("All");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Noodle");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadMenuItems("All");
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Sandwich");
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
           LoadMenuItems("Beverage");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    

    }

}




