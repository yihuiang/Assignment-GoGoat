using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class Feedback
    {
        public int CustomerID { get; set; }
        public string FoodQuality { get; set; }
        public string StaffFriendliness { get; set; }
        public string PriceWorthiness { get; set; }
        public string PortionSize { get; set; }
        public string MenuVariety { get; set; }
        public string Comments { get; set; }

        public void SaveToDb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO FeedbackMenu (CustomerID, FoodQuality, Staff, Price, PortionSize, MenuVariety, Comments) " +
                               "VALUES (@CustomerID, @FoodQuality, @Staff, @Price, @PortionSize, @MenuVariety, @Comments)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);
                command.Parameters.AddWithValue("@FoodQuality", FoodQuality);
                command.Parameters.AddWithValue("@Staff", StaffFriendliness);
                command.Parameters.AddWithValue("@Price", PriceWorthiness);
                command.Parameters.AddWithValue("@PortionSize", PortionSize);
                command.Parameters.AddWithValue("@MenuVariety", MenuVariety);
                command.Parameters.AddWithValue("@Comments", Comments);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
