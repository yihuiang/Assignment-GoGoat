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
    public partial class frmEditUsers : UserControl
    {
        public frmEditUsers()
        {
            InitializeComponent();
        }

        private void SetTextBoxesReadOnly(bool isReadOnly)
        {
            txtUser.ReadOnly = isReadOnly;
            txtRole.ReadOnly = isReadOnly;
            txtPass.ReadOnly = isReadOnly;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTextBoxesReadOnly(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtSearch.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT userid, username, role, password FROM users WHERE username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUserid.Text = reader["userid"].ToString();
                                txtUser.Text = reader["username"].ToString();
                                txtRole.Text = reader["role"].ToString();
                                txtPass.Text = reader["password"].ToString();
                                SetTextBoxesReadOnly(true); // Make sure textboxes are read-only initially
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
            string userid = txtUserid.Text;
            string username = txtUser.Text;
            string role = txtRole.Text;
            string password = txtPass.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE users SET username = @username, role = @role, password = @password WHERE userid = @userid", con))
                    {
                        cmd.Parameters.AddWithValue("@userid", userid);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User updated successfully.");
                        SetTextBoxesReadOnly(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



     

        private void ClearTextBoxes()
        {
            txtUserid.Clear();
            txtUser.Clear();
            txtRole.Clear();
            txtPass.Clear();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string role = txtRole.Text;
            string password = txtPass.Text;
            SetTextBoxesReadOnly(false);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO users (username, role, password) VALUES (@username, @role, @password)", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User added successfully.");
                        ClearTextBoxes();
                        SetTextBoxesReadOnly(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
        
                string userid = txtUserid.Text;

                try
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE userid = @userid", con))
                        {
                            cmd.Parameters.AddWithValue("@userid", userid);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User deleted successfully.");
                            ClearTextBoxes();
                            SetTextBoxesReadOnly(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
        
        }


    }
}
