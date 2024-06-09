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

namespace Manager_asm.AdminPages
{
    public partial class frmUpdateProfileAdmin : UserControl
    {
        private string currentUsername;

        public frmUpdateProfileAdmin(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT username, password FROM users WHERE username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", currentUsername);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCurrUser.Text = reader["username"].ToString();
                                txtCurrPass.Text = reader["password"].ToString();
                            }
                            else
                            { 
                                MessageBox.Show("User not found.");
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }

        private void UpdateProfile()
        {
            string newUsername = txtNewUser.Text;
            string newPassword = txtNewPass.Text;

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE users SET username = @newUsername, password = @newPassword WHERE username = @currentUsername", con))
                    {
                        cmd.Parameters.AddWithValue("@newUsername", newUsername);
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@currentUsername", currentUsername);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profile updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfile();
        }
    }
}
