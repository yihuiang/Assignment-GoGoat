using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.Pages
{
    public partial class Page_Profile : UserControl
    {

        private string username;
        public Page_Profile(string username)
        {
            InitializeComponent();
            Page_PI pg = new Page_PI(username);
            addusercontrol2(pg);
            this.username = username;
        }

        private void addusercontrol2(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Page_PI pg = new Page_PI(username);
            addusercontrol2(pg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Page_ProfileLoginPs pglg = new Page_ProfileLoginPs(username);
            addusercontrol2(pglg);
        }
    }
}

