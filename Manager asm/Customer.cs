using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class Customer
    {
        private string CustomerID;
        private string name;
        private string email;
        private string phonenum;
        private string address;
        private string con = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public Customer(string CustomerID, string name, string email, string phonenum, string address)
        {
            this.CustomerID = CustomerID;
            this.name = name;
            this.email = email;
            this.phonenum = phonenum;
            this.address = address;
        }



        public string SubmitFeedback(string food, string staff, string price, string portion, string menu, string comments)
        {
            //validation check
            string status = "";
            if (food == "" || staff == "" || price == "" || portion == "" || menu == "")
                status = "Please select all rating options before submiting.";

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "INSERT INTO FeedbackMenu (CustomerID, FoodQuality, Staff, Price, PortionSize, MenuVariety, Comments) " +
               "VALUES (@CustomerID, @FoodQuality, @Staff, @Price, @PortionSize, @MenuVariety, @Comments)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@CustomerID", int.Parse(this.CustomerID));
                    command.Parameters.AddWithValue("@FoodQuality", food);
                    command.Parameters.AddWithValue("@Staff", staff);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@PortionSize", portion);
                    command.Parameters.AddWithValue("@MenuVariety", menu);
                    command.Parameters.AddWithValue("@Comments", comments);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        status = ("Feedback submitted successfully.");
                    }
                    else
                    {
                        status = ("Failed to submit feedback.");
                    }
                    return status;
                }
            }
        }
    }
}