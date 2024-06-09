using Manager_asm.CustomerPages;
using Manager_asm.Pages;
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

namespace Manager_asm.User_Control
{
    public partial class Page_Menu : UserControl
    {
        private MenuZ menu;
        private Order order;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private int customerid;


        public Page_Menu(int customerid)
        {
            InitializeComponent();
            menu = new MenuZ();
            this.customerid = customerid;
        }

        public Page_Menu()
        {
            InitializeComponent();
            menu  = new MenuZ();
            
        }
        private void LoadMenuItems(string category)
        {
            flowLayoutPanelMenu.Controls.Clear();
            menu.LoadMenuItems(flowLayoutPanelMenu, category);
            foreach (Control control in flowLayoutPanelMenu.Controls)
            {
                if (control is btnitem menuItemControl)
                {
                    menuItemControl.SetOrder(order);
                }
            }
        }

        private void Page_Menu_Load(object sender, EventArgs e)
        {
            order = new Order(lstCart);
            order.DisplayCart();
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

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmPayment paymentForm = new frmPayment(order, customerid);
            paymentForm.ShowDialog();
        }
    }

}




