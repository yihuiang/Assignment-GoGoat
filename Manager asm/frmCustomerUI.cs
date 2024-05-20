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
    public partial class frmCustomerUI : Form
    {
        public frmCustomerUI()
        {
            InitializeComponent();
            Page_Menu page_Menu = new Page_Menu();
            addpage(page_Menu);
        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelCustomer.Controls.Clear();
            panelCustomer.Controls.Add(Page);
            Page.BringToFront();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Page_Menu page_Menu = new Page_Menu();
            addpage(page_Menu);
        }
    }
}
