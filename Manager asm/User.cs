using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manager_asm
{
    internal class User
    {
        public string username;
        public string password;
        public string role;

        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            role = "Customer";
        }

        public bool Login()
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    using (SqlCommand credentialscmd = new SqlCommand("SELECT role FROM users WHERE username=@a AND password=@b", con))
                    {
                        credentialscmd.Parameters.AddWithValue("@a", username);
                        credentialscmd.Parameters.AddWithValue("@b", password);

                        SqlCommand rolecmd = new SqlCommand("SELECT role FROM users WHERE username =@a and password =@b", con);
                        rolecmd.Parameters.AddWithValue("@a", username);
                        rolecmd.Parameters.AddWithValue("@b", password);

                        if (rolecmd != null)
                        {
                            // Set the role if login is successful
                            role = rolecmd.ToString().Trim();
                            isSuccess = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return isSuccess;
        }
    }
}
