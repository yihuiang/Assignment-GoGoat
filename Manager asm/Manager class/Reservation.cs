using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    internal class Reservation
    {
        private string customerName;
        private DateTime date;
        private TimeSpan time;
        private int pax;
        private string type;
        private string status;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;

        public string CustomerName { get => customerName; set => customerName = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public int Pax { get => pax; set => pax = value; }
        public string Type { get => type; set => type = value; }
        public string Status { get => status; set => status = value; }

        public Reservation(string customerName, DateTime date, TimeSpan time, int pax, string type, string status)
        {
            this.customerName = customerName;
            this.date = date;
            this.time = time;
            this.pax = pax;
            this.type = type;
            this.status = status;
        }
        public Reservation() { }

        //ok
        public string AddReservation()
        {
            string result;
            try
            {
                con.Open();

                // Get CustomerID
                cmd = new SqlCommand("SELECT CustomerID FROM Customer WHERE Name = @name", con);
                cmd.Parameters.AddWithValue("@name", customerName);
                int customerId = (int)cmd.ExecuteScalar();

                // Insert Reservation
                cmd = new SqlCommand("INSERT INTO Reservation (CustomerID, [Date], [Time], Pax, Type, [Status]) VALUES (@customerid, @date, @time, @pax, @type, @status)", con);
                cmd.Parameters.AddWithValue("@customerid", customerId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@pax", pax);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@status", status);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    result = "Reservation added successfully.";
                else
                    result = "Failed to add reservation.";

                con.Close();
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }

            return result;
        }

        //ok
        public string UpdateReservation()
        {
            string status;

            con.Open();

            cmd = new SqlCommand("SELECT CustomerID FROM Customer WHERE Name = @name", con);
            cmd.Parameters.AddWithValue("@name", customerName);
            int customerId = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("UPDATE Reservation SET Date = @date, Time = @time, Pax = @pax, Type = @type, Status = @status WHERE CustomerID = @customerid", con);

            cmd.Parameters.AddWithValue("@customerid", customerId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time.ToString(@"hh\:mm\:ss"));
            cmd.Parameters.AddWithValue("@pax", pax);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", this.status);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";

            con.Close();
            return status;
        }
        //ok
        public string DeleteReservation()
        {
            string status;
            con.Open();

            cmd = new SqlCommand("SELECT CustomerID FROM Customer WHERE Name = @name", con);
            cmd.Parameters.AddWithValue("@name", customerName);
            int customerId = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("DELETE FROM Reservation WHERE CustomerID = @customerid AND Date = @date AND Time = @time", con);

            cmd.Parameters.AddWithValue("@customerid", customerId);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time.ToString(@"hh\:mm\:ss"));

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Delete Successfully.";
            else
                status = "Unable to delete.";

            con.Close();
            return status;
        }

        public static string ConstructQuery(string month, string reservationType, string customer, out List<SqlParameter> parameters)
        {
            List<string> conditions = new List<string>();
            parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(month))
            {
                conditions.Add("FORMAT(r.Date, 'MMMM') = @Month");
                parameters.Add(new SqlParameter("@Month", month));
            }

            if (!string.IsNullOrEmpty(reservationType))
            {
                conditions.Add("r.Type = @ReservationType");
                parameters.Add(new SqlParameter("@ReservationType", reservationType));
            }

            if (!string.IsNullOrEmpty(customer))
            {
                conditions.Add("c.Name = @Customer");
                parameters.Add(new SqlParameter("@Customer", customer));
            }

            string query = @"
            SELECT r.ReservationID, r.Date, r.Time, r.Pax, r.Type, r.Status, c.Name AS CustomerName 
            FROM Reservation r
            INNER JOIN Customer c ON r.CustomerID = c.CustomerID";

            if (conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            return query;
        }


        public static List<string> GetDistinctCustomerNames()
        {
            List<string> customerNames = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    string query = @"
                SELECT DISTINCT c.Name AS CustomerName 
                FROM Reservation r
                INNER JOIN Customer c ON r.CustomerID = c.CustomerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerNames.Add(reader["CustomerName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer names: " + ex.Message);
            }

            return customerNames;
        }


        public static DataTable GetReservationData(string month, string reservationType, string customer)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        public static string GetMostPopularTimeSlot(string month, string reservationType, string customer)
        {
            string popularTimeSlot = string.Empty;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);
                query = query.Replace("SELECT r.ReservationID, r.Date, r.Time, r.Pax, r.Type, r.Status, c.Name AS CustomerName", "SELECT TOP 1 r.Time, COUNT(*) AS ReservationCount ") + " GROUP BY r.Time ORDER BY ReservationCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            popularTimeSlot = reader["Time"].ToString();
                        }
                    }
                }
            }

            return popularTimeSlot;
        }


        public static int GetCancellationCount(string month, string reservationType, string customer)
        {
            int cancellationCount = 0;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);

                // Ensure 'Status = 'Cancelled'' is properly appended to the WHERE clause
                if (query.Contains("WHERE"))
                {
                    query += " AND r.Status = 'Cancelled'";
                }
                else
                {
                    query += " WHERE r.Status = 'Cancelled'";
                }

                query = query.Replace("SELECT r.ReservationID, r.Date, r.Time, r.Pax, r.Type, r.Status, c.Name AS CustomerName", "SELECT COUNT(*)");

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    conn.Open();
                    cancellationCount = (int)cmd.ExecuteScalar();
                }
            }

            return cancellationCount;
        }


        public static void GeneratePDF(DataTable reservationData, string month, string reservationType, string customer)
        {
            string filePath = "ReservationReport.pdf"; // You can change this path if needed

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                // Add title
                document.Add(new Paragraph("Go-Goat Reservation Report"));

                // Add filters
                if (!string.IsNullOrEmpty(month)) document.Add(new Paragraph("Month: " + month));
                if (!string.IsNullOrEmpty(reservationType)) document.Add(new Paragraph("Reservation Type: " + reservationType));
                if (!string.IsNullOrEmpty(customer)) document.Add(new Paragraph("Customer: " + customer));
                document.Add(new Paragraph(" ")); // Empty line

                // Add table
                PdfPTable table = new PdfPTable(reservationData.Columns.Count);
                // Add headers
                foreach (DataColumn column in reservationData.Columns)
                {
                    table.AddCell(new Phrase(column.ColumnName));
                }
                // Add data rows
                foreach (DataRow row in reservationData.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        table.AddCell(new Phrase(cell.ToString()));
                    }
                }
                document.Add(table);

                // Add popular time slot and cancellations
                string popularTimeSlot = GetMostPopularTimeSlot(month, reservationType, customer);
                int cancellationCount = GetCancellationCount(month, reservationType, customer);
                document.Add(new Paragraph("Most Popular Time Slot: " + popularTimeSlot));
                document.Add(new Paragraph("Number of Cancellations: " + cancellationCount.ToString()));

                document.Close();
            }

            MessageBox.Show("PDF report generated successfully!");

            // Open the PDF file
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
