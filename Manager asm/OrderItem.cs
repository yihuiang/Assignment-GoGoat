/*using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class OrderItem
    {


        
            public string ItemName { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            static SqlCommand cmd;

        public string PlaceOrder(List<OrderItem> orderItems)
        {
            string status;
            con.Open();

            try
            {
                // Start a new transaction
                SqlTransaction transaction = con.BeginTransaction();

                // Insert the order into the Order table
                cmd = new SqlCommand("INSERT INTO [Order] (CustomerID, OrderDate) VALUES (@CustomerID, @OrderDate); SELECT SCOPE_IDENTITY()", con, transaction);
                cmd.Parameters.AddWithValue("@CustomerID", 1); // Replace with the actual customer ID
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert the order items into the OrderDetails table
                foreach (OrderItem item in orderItems)
                {
                    cmd = new SqlCommand("INSERT INTO OrderDetails (OrderID, ItemID, Quantity, Price) VALUES (@OrderID, (SELECT ItemID FROM Menu WHERE Item = @ItemName), @Quantity, @Price)", con, transaction);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@Price", item.Price);
                    cmd.ExecuteNonQuery();
                }

                // Commit the transaction
                transaction.Commit();
                status = "Order placed successfully.";
            }
            catch (Exception ex)
            {
                status = "Failed to place the order. Error: " + ex.Message;
            }
            finally
            {
                con.Close();
            }

            return status;
        }
    }
    }
*/