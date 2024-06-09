using Manager_asm.ManagerPages;
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
    public partial class Page_ProfileLoginPs : UserControl
    {
        private string username;
        public Page_ProfileLoginPs(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_Edit_Password pg = new Page_Edit_Password(username);
            pg.Show();
        }

        private void Page_ProfileLoginPs_Load(object sender, EventArgs e)
        {
            User obj1 = new User(username);
            Manager.viewLogin(obj1);

            lblUsername.Text = obj1.username;
            lblPassword.Text = obj1.password;

            
        }
    }
}
