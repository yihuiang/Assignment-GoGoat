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
                // Login successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                // Redirect to the appropriate form based on the role
                switch (user.role)
                {
                    case "Admin":
                        //frmAdminUI adminForm = new frmAdminUI();
                        //adminForm.ShowDialog();
                        //break;
                    case "Manager":
                        FrmManagerUI managerForm = new FrmManagerUI();
                        managerForm.ShowDialog();
                        break;
                    case "Chef":
                        //frmChefUI chefForm = new frmChefUI();
                        //chefForm.ShowDialog();
                        //break;
                    case "Customer":
                        frmCustomerUI customerForm = new frmCustomerUI();
                        customerForm.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Unknown role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Show();
            }
            else
            {
                // Login failed
                MessageBox.Show("Incorrect username/password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            frmChefUI frmChefUI = new frmChefUI();
            frmChefUI.ShowDialog();
            this.Close();
        }
    }
}
