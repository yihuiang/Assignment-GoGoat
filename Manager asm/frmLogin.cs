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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            FrmManagerUI frmManagerUI = new FrmManagerUI();
            frmManagerUI.ShowDialog();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerUI frmCustomerUI = new frmCustomerUI();
            frmCustomerUI.ShowDialog();
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            frmChefUI frmChefUI = new frmChefUI();
            frmChefUI.ShowDialog();
            this.Close();
        }
    }
}
