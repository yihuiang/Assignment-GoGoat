using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manager_asm.Pages
{
    public partial class Page_Profile_Personal_Info : UserControl
    {
       
        private string username;
        public Page_Profile_Personal_Info(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_PI_Profile_Edit editForm = new Page_PI_Profile_Edit(username);
            editForm.Show();
            
        }

        private void Page_Profile_Personal_Info_Load(object sender, EventArgs e)
        {
            Manager obj1 = new Manager(username);
            Manager.viewProfile(obj1);

            lblName.Text = obj1.ManName;
            lblEmail.Text = obj1.Email;
            lblPhoneNum.Text = obj1.PhoneNum;
            lblAddress.Text = obj1.Address;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
