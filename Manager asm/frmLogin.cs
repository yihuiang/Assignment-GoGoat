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

        

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

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
                        //Adminfrm adminForm = new AdminHome();
                        //adminForm.ShowDialog();
                        //break;
                    case "manager":
                        FrmManagerUI managerForm = new FrmManagerUI();
                        managerForm.ShowDialog();
                        break;
                    case "chef":
                        //Chefrm chefForm = new ChefHome();
                        //chefForm.ShowDialog();
                        //break;
                    case "customer":
                        frmCustomerUI customerForm = new frmCustomerUI();
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
    }
}
