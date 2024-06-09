using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Manager_asm.frmLogin;

namespace Manager_asm.AdminPages
{
    public partial class frmAdminUI : Form
    {
        public frmAdminUI()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(Page);
            Page.BringToFront();
        }

        private void frmAdminUI_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmEditUsers frmEditUsers = new frmEditUsers();
            addpage(frmEditUsers);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            string currentUsername = GetCurrentUsername();
            frmUpdateProfileAdmin frmUpdateProfileAdmin = new frmUpdateProfileAdmin(currentUsername);
            addpage(frmUpdateProfileAdmin);
        }
        private string GetCurrentUsername()
        {
            return Session.CurrentUsername;
        }

    }
}
