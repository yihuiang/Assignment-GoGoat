using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    public class ChefClass
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ConnectionString);
        static SqlCommand cmd;

        public void AddIngredient(string ingredientName, string category, string unit)
        {
            try
            {
                string query = "INSERT INTO Ingredients (Name, Category, Unit, Amount) VALUES (@IngredientName, @Category, @Unit, @Amount)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Unit", unit);
                cmd.Parameters.AddWithValue("@Amount", 1);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable GetIngredients() // Added method to get ingredients data
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Ingredients";

                cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public void DeleteIngredient(int ingredientsID)
        {
            try
            {
                string query = "DELETE FROM Ingredients WHERE IngredientsID = @IngredientsID";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IngredientsID", ingredientsID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public DataTable GetOrders()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT o.OrderID, o.Status, od.ItemID, m.Item, od.Amount
                                 FROM [Order] o
                                 INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
                                 INNER JOIN Menu m ON od.ItemID = m.ItemID";

                cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public void UpdateOrderStatus(int orderID, string status)
        {
            try
            {
                string query = "UPDATE [Order] SET Status = @Status WHERE OrderID = @OrderID";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}