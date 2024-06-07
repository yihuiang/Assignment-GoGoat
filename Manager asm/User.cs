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

                    using (SqlCommand cmd = new SqlCommand("SELECT role FROM users WHERE username=@a AND password=@b", con))
                    {
                        cmd.Parameters.AddWithValue("@a", username);
                        cmd.Parameters.AddWithValue("@b", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Set the role if login is successful
                            role = result.ToString().Trim();
                            isSuccess = true;
                            Console.WriteLine("Role retrieved: " + role); // Debugging output
                        }
                        else
                        {
                            Console.WriteLine("Login failed: No matching user found.");
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
