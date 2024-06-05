using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manager_asm
{
    internal class Customer
    {
        private int CustomerID;
        private string name;
        private string email;
        private string phonenum;
        private string address;
        private string con = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public Customer(int CustomerID, string name, string email, string phonenum, string address)
        {
            this.CustomerID = CustomerID;
            this.name = name;
            this.email = email;
            this.phonenum = phonenum;
            this.address = address;
        }

        public Customer(int CustomerID)
        { this.CustomerID = CustomerID; }

        public string RequestReservation(DateTime datetime, int pax, string type)
        {
            string status = "";
            if (datetime == null || pax == 0 || string.IsNullOrEmpty(type))
                status = "Please select all rating options before submitting.";
            else
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    // First, check if there is an existing reservation for the same date and time
                    string checkQuery = "SELECT COUNT(*) FROM TableReservation WHERE Datetime = @Datetime";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Datetime", datetime);
                        connection.Open();
                        int existingCount = (int)checkCommand.ExecuteScalar();
                        connection.Close();

                        if (existingCount > 0)
                        {
                            status = "There is already a reservation at the selected date and time. Please choose a different time.";
                        }
                        else
                        {
                            // If no existing reservation, proceed with inserting a new reservation
                            string query = "INSERT INTO TableReservation (CustomerID, CustomerName, Datetime, Pax, Type) " +
                                "VALUES (@CustomerID, @CustomerName, @Datetime, @Pax, @Type, @Status)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Add parameters to the SQL command
                                command.Parameters.AddWithValue("@CustomerID", (this.CustomerID));
                                command.Parameters.AddWithValue("@CustomerName", this.name);
                                command.Parameters.AddWithValue("@Datetime", datetime);
                                command.Parameters.AddWithValue("@Pax", pax);
                                command.Parameters.AddWithValue("@Type", type);
                                command.Parameters.AddWithValue("@Status", "Pending");

                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    status = "Reservation submitted successfully.";
                                }
                                else
                                {
                                    status = "Failed to submit reservation.";
                                }
                            }
                        }
                    }
                }
            }
            return status;
        }

        public string SubmitFeedbackMenu(string food, string staff, string price, string portion, string menu, string comments)
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
                    command.Parameters.AddWithValue("@CustomerID", (this.CustomerID));
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
        public string SubmitFeedbackReservation(string atmosphere, string cleanliness, string music, string ease, string flexibility, string comments)
        {
            //validation check
            string status = "";
            if (atmosphere == "" || cleanliness == "" || ease == "" || flexibility == "" || music == "")
                status = "Please select all rating options before submiting.";

            using (SqlConnection connection = new SqlConnection(con))
            {
                string query = "INSERT INTO FeedbackMenu (CustomerID, Atmosphere, Cleanliness, Music, Ease, Flexibility, Comments) " +
               "VALUES (@CustomerID, @Atmosphere, @Cleanliness, @Music, @Ease, @Flexibility, @Comments)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@CustomerID", (this.CustomerID));
                    command.Parameters.AddWithValue("@Atmosphere", atmosphere);
                    command.Parameters.AddWithValue("@Cleanliness", cleanliness);
                    command.Parameters.AddWithValue("@Music", music);
                    command.Parameters.AddWithValue("@Ease", ease);
                    command.Parameters.AddWithValue("@Flexibility", flexibility);
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