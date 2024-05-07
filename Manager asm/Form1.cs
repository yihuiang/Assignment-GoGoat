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
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(Page);
            Page.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Page_Menu p_menu = new Page_Menu();
            addpage(p_menu);
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            Page_Reservation p_rese = new Page_Reservation();
            addpage(p_rese);
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Page_Report p_report = new Page_Report();
            addpage(p_report);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Page_Profile p_profile = new Page_Profile();
            addpage(p_profile);
        }
    }
}
