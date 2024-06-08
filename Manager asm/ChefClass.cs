using System;
using System.Collections.Generic;
using System.Configuration;
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
                string query = "INSERT INTO Ingredients (Name, Category, Unit) VALUES (@IngredientName, @Category, @Unit)";

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


    }

}



