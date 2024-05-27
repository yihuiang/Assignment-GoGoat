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
    public partial class Page_PI_Profile_Edit : Form
    {
        private int ManagerID;
        public Page_PI_Profile_Edit(int ManagerID)
        {
            InitializeComponent();
            this.ManagerID = ManagerID;
            LoadManagerData();
        }
        private void LoadManagerData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Email, PhoneNum, Address FROM Manager WHERE ManagerID = @ManagerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ManagerID", ManagerID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhoneNum.Text = reader["PhoneNum"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                }
                
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string phoneNum = txtPhoneNum.Text;
            string address = txtAddress.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Manager SET Email = @Email, PhoneNum = @PhoneNum, Address = @Address WHERE ManagerID = @ManagerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNum", phoneNum);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@ManagerID", ManagerID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Profile updated successfully!");
            this.Close();
        }
    }
}
