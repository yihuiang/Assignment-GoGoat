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
        private int ManagerID;
        public Page_Profile()
        {
            InitializeComponent();
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
            Page_Profile_Personal_Info pg = new Page_Profile_Personal_Info(ManagerID);
            addusercontrol2(pg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Page_ProfileLoginPs pglg = new Page_ProfileLoginPs();
            addusercontrol2(pglg);
        }
    }
}

