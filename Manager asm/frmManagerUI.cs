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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_asm
{
    public partial class FrmManagerUI : Form
    {
        public FrmManagerUI()
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
        private void btneditproduct_Click(object sender, EventArgs e)
        {
            Page_MenuCatalog p_menucatalog = new Page_MenuCatalog();
            addpage(p_menucatalog);
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

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Chocolate;
            btnMenu.ForeColor = Color.White;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.White;
            btnMenu.ForeColor = Color.Chocolate;
        }

        private void btnreservation_MouseEnter(object sender, EventArgs e)
        {
            btnreservation.BackColor = Color.Chocolate;
            btnreservation.ForeColor = Color.White;
        }

        private void btnreservation_MouseLeave(object sender, EventArgs e)
        {
            btnreservation.BackColor = Color.White;
            btnreservation.ForeColor = Color.Chocolate;
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
