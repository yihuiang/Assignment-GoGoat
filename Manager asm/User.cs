using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public User(string username) { this.username = username; }  

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
        public int GetCustomerID()
        {
            int customerID = 0;
            string query = "SELECT CustomerID FROM Customer WHERE Name = @Username";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        customerID = Convert.ToInt32(result);
                      //  MessageBox.Show("CustomerID retrieved: " + customerID); // Debugging output
                    }
                    else
                    {
                        MessageBox.Show("No CustomerID found for username: " + username); // Debugging output
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    MessageBox.Show("An error occurred while getting CustomerID: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return customerID;
        }
    }
}
