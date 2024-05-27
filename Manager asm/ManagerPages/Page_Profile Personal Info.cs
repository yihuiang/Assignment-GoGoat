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
        private int ManagerID;
        public Page_Profile_Personal_Info(int ManagerID)
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
                string query = "SELECT Name, Email, PhoneNum, Address FROM Manager WHERE ManagerID = @ManagerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ManagerID", ManagerID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = reader["Name"].ToString();
                    lblEmail.Text = reader["Email"].ToString();
                    lblPhoneNum.Text = reader["PhoneNum"].ToString();
                    lblAddress.Text = reader["Address"].ToString();
                }
            }
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_PI_Profile_Edit p1 = new Page_PI_Profile_Edit(ManagerID);
            p1.Show();
        }

        private void Page_Profile_Personal_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
