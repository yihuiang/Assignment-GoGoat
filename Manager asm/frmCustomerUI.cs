using Manager_asm.CustomerPages;
using Manager_asm.Pages;
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
        public static string name;

        public frmCustomerUI()
        {
            InitializeComponent();
            Page_Menu page_Menu = new Page_Menu();
            addpage(page_Menu);
            //name = un;
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

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Page_Feedback page_Feedback = new Page_Feedback();  
            addpage(page_Feedback);
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            Page_Reservation_Customer page_Reservation_Customer = new Page_Reservation_Customer();
            addpage(page_Reservation_Customer);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Page_Profile page_Profile = new Page_Profile();
            addpage(page_Profile);
        }

        private void frmCustomerUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();
        }
    }
}
