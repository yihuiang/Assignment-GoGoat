using iTextSharp.xmp.impl;
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
        private string username;

        public Page_PI_Profile_Edit(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {


            Manager obj1 = new Manager(username);
            MessageBox.Show(obj1.updateProfile(txtEmail.Text, txtPhoneNum.Text, txtAddress.Text));

        }

        private void Page_PI_Profile_Edit_Load(object sender, EventArgs e)
        {
            Manager obj1 = new Manager(username);
            Manager.viewProfile(obj1);

            txtEmail.Text = obj1.Email;
            txtPhoneNum.Text = obj1.PhoneNum;
            txtAddress.Text = obj1.Address;
        }
    }
}
