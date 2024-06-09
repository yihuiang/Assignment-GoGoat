using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

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
            {

                status = "Please select all rating options before submitting.";
            }
            else
            {
                {
                    // First, check if there is an existing reservation for the same date and time
                    string checkQuery = "SELECT COUNT(*) FROM Reservation WHERE Datetime = @Datetime";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                    {
                        checkCommand.Parameters.AddWithValue("@Datetime", datetime);
                        con.Open();
                        int existingCount = (int)checkCommand.ExecuteScalar();
                        con.Close();

                        if (existingCount > 0)
                        {
                            status = "There is already a reservation at the selected date and time. Please choose a different time.";
                        }
                        else
                        {
                            // If no existing reservation, proceed with inserting a new reservation
                            string query = "INSERT INTO Reservation (CustomerID, Datetime, Pax, Type, Status) " +
                                "VALUES (@CustomerID, @Datetime, @Pax, @Type, @Status)";
                            using (SqlCommand command = new SqlCommand(query, con))
                            {
                                // Add parameters to the SQL command
                                command.Parameters.AddWithValue("@CustomerID", (this.CustomerID));
                                command.Parameters.AddWithValue("@Datetime", datetime);
                                command.Parameters.AddWithValue("@Pax", pax);
                                command.Parameters.AddWithValue("@Type", type);
                                command.Parameters.AddWithValue("@Status", "Pending");

                                con.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                con.Close();

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

        public string SubmitFeedbackReservation(string atmosphere, string cleanliness, string music, string ease, string flexibility, string comments)
        {
            //validation check
            string status = "";
            if (atmosphere == "" || cleanliness == "" || ease == "" || flexibility == "" || music == "")
            {
                status = "Please select all rating options before submiting.";
                return status;
            }

            else
            {

                {
                    string query = "INSERT INTO FeedbackReservation (CustomerID, Atmosphere, Cleanliness, Music, EaseofReservation, Flexibility, Comments) " +
                   "VALUES (@CustomerID, @Atmosphere, @Cleanliness, @Music, @Ease, @Flexibility, @Comments)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@CustomerID", (this.CustomerID));
                        command.Parameters.AddWithValue("@Atmosphere", atmosphere);
                        command.Parameters.AddWithValue("@Cleanliness", cleanliness);
                        command.Parameters.AddWithValue("@Music", music);
                        command.Parameters.AddWithValue("@Ease", ease);
                        command.Parameters.AddWithValue("@Flexibility", flexibility);
                        command.Parameters.AddWithValue("@Comments", comments);
                        con.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            status = ("Feedback submitted successfully.");
                        }
                        else
                        {
                            status = ("Failed to submit feedback.");
                        }
                        con.Close();
                        return status;
                    }
                }
            }
        }

        public DataTable GetOrder()
        {
            {
                string query = @"
            SELECT o.OrderID, m.Item, m.Price
            FROM Orders o
            INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
            INNER JOIN Menu m ON od.ItemID = m.ItemID
            WHERE o.CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }
        public void GetReservation(DataGridView dataReserve)
        {
            dataReserve.Columns.Clear(); // Clear any existing columns in the DataGridView

            // Set the DataGridView column headers
            dataReserve.Columns.Add("ReservationID", "Reservation ID");
            dataReserve.Columns.Add("Datetime", "Date/Time");
            dataReserve.Columns.Add("Pax", "Pax");
            dataReserve.Columns.Add("Type", "Type");
            dataReserve.Columns.Add("Status", "Status");

            string query = "SELECT ReservationID, Datetime, Pax, Type, Status FROM Reservation WHERE CustomerID = @CustomerID";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataReserve.Rows.Clear(); // Clear any existing rows in the DataGridView
                    while (reader.Read())
                    {
                        int reservationId = reader.GetInt32(0);
                        DateTime dateTime = reader.GetDateTime(1);
                        int pax = reader.GetInt32(2);
                        string type = reader.GetString(3);
                        string status = reader.GetString(4);
                        dataReserve.Rows.Add(reservationId, dateTime, pax, type, status);
                    }
                }
                else
                {
                    dataReserve.Rows.Clear(); // Clear any existing rows in the DataGridView
                    dataReserve.Rows.Add("No reservations found.");
                }
                reader.Close();
                con.Close();
            }
        }
    }


}
