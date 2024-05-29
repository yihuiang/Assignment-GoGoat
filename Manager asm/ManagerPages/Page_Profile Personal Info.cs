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

namespace Manager_asm.Pages
{
    public partial class Page_Profile_Personal_Info : UserControl
    {
        private string managerName;
        private Manager manager;

        public Page_Profile_Personal_Info(string managerName)
        {
            InitializeComponent();
            this.managerName = managerName;
            LoadManagerData();
        }

        private void LoadManagerData()
        {
            manager = Manager.GetManagerByName(managerName);
            if (manager != null)
            {
                lblName.Text = manager.ManName1;
                lblEmail.Text = manager.Email;
                lblPhoneNum.Text = manager.PhoneNum;
                lblAddress.Text = manager.Address;
            }
            else
            {
                MessageBox.Show("Manager not found.");
            }
        }
        
        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_PI_Profile_Edit editForm = new Page_PI_Profile_Edit(managerName);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadManagerData();
            }
        }
   
        private void Page_Profile_Personal_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
