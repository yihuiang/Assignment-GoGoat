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
    public partial class Page_Profile_Personal_Info : UserControl
    {
        public Page_Profile_Personal_Info()
        {
            InitializeComponent();
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_PI_Profile_Edit p1 = new Page_PI_Profile_Edit();
            p1.Show();
        }

        private void Page_Profile_Personal_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
