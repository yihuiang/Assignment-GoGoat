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
using System.Xml.Linq;

namespace Manager_asm.Pages
{
    public partial class Page_PI_Profile_Edit : Form
    {
        private string managerName;
        private Manager manager;

        public Page_PI_Profile_Edit(string managerName)
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
                txtEmail.Text = manager.Email;
                txtPhoneNum.Text = manager.PhoneNum;
                txtAddress.Text = manager.Address;
            }
            else
            {
                MessageBox.Show("Manager not found.");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                manager.Email = txtEmail.Text;
                manager.PhoneNum = txtPhoneNum.Text;
                manager.Address = txtAddress.Text;
                manager.Update();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Manager data could not be loaded.");
            }
        }

        private void Page_PI_Profile_Edit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
