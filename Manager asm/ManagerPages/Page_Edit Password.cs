using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.ManagerPages
{
    public partial class Page_Edit_Password : Form
    {
        private string username;
        public Page_Edit_Password(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Manager obj = new Manager(username);
            MessageBox.Show(obj.updatePass(txtPassword.Text));

            this.Close();
        }

        private void Page_Edit_Password_Load(object sender, EventArgs e)
        {
            User obj1 = new User(username);
            Manager.viewLogin(obj1);

            txtPassword.Text = obj1.password;

        }
    }
}
