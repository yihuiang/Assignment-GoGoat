using Manager_asm.AdminPages;
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
        public static class Session
        {
            public static string CurrentUsername { get; set; }
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Session.CurrentUsername = txtUsername.Text;
            User user = new User(username, password);

            bool isSuccess = user.Login();

            if (isSuccess)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                Console.WriteLine("User role after login: " + user.role); // Debugging output
                switch (user.role.ToLower())
                {
                    case "admin":
                        frmAdminUI frmAdminUI = new frmAdminUI();
                        frmAdminUI.ShowDialog();
                        break;
                    case "manager":
                        FrmManagerUI managerForm = new FrmManagerUI(username);
                        managerForm.ShowDialog();
                        break;
                    case "chef":
                        //Chefrm chefForm = new ChefHome();
                        //chefForm.ShowDialog();
                        //break;
                    case "customer":
                        frmCustomerUI customerForm = new frmCustomerUI(username);
                        customerForm.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Unknown role: " + user.role, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username/password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            FrmManagerUI obj = new FrmManagerUI(username);
            obj.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChefUI obj = new frmChefUI();
            obj.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            frmCustomerUI obj = new frmCustomerUI(username);    
            obj.Show();
        }
    }
}
