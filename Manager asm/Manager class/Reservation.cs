using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Reservation(string customerName, DateTime date,TimeSpan time ,int pax, string type, string status)
        {
            this.customerName = customerName;
            this.date = date;
            this.time = time;
            this.pax = pax;
            this.type = type;
            this.status = status;
        }

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
    }
}
