using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;



namespace Manager_asm
{
    internal class MenuZ
    {
        private string item;
        private string category;
        private double price;
        private Image image;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        


        public string Item { get => item; set => item = value; }
        public string Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }
        public Image Image { get => image; set => image = value; }

        public MenuZ(string item, string category, double price, Image image)
        {

            this.item = item;
            this.category = category;
            this.price = price;
            this.image = image;
        }
        public MenuZ(string item)
        {
            Item = item;
        }
        public MenuZ()
        {
            // Parameterless constructor
        }

        //Add Menu //ok
        public string AddMenuItem()
        {
            string status;
            con.Open();

            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] img = ms.ToArray();

            cmd = new SqlCommand("INSERT INTO Menu(Item, Category, Price, Image) VALUES (@item, @category, @price, @image)", con);

            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary, img.Length).Value = img;

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                status = "Item Add Successful.";
            else
                status = "Item Add Unsuccessful. Try Again.";

            con.Close();
            return status;

        }

        // Update Menu //ok
        public string UpdateMenuItem()
        {
            string status;

            con.Open();

            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            byte[] img = ms.ToArray();

            cmd = new SqlCommand("UPDATE Menu SET Category = @category, Price = @price, Image = @image WHERE Item = @item", con);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary, img.Length).Value = img;

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";

            con.Close();
            return status;
        }

        //Delete //ok
        public string DeleteMenuItem()
        {
            string status;
            con.Open();

            cmd = new SqlCommand("DELETE FROM Menu WHERE Item = @item", con);
            cmd.Parameters.AddWithValue("@item", item);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Delete Successfully.";
            else
                status = "Unable to delete.";

            con.Close();
            return status;
        }
        //Search
        /*
        public string SearchMenuItem(string item)
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM Menu WHERE Item LIKE @searchText", con);
            cmd.Parameters.AddWithValue("@searchText", "%" + item + "%");

            
        }
        */

        //GetData for Flow 

        public void LoadMenuItems(FlowLayoutPanel panel, string category = "")
        {
            string query = "SELECT Item, Category, Price, Image FROM Menu";
            if (!string.IsNullOrEmpty(category) && category != "All")
            {
                query += " WHERE Category = @category";
            }

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (!string.IsNullOrEmpty(category) && category != "All")
                {
                    cmd.Parameters.AddWithValue("@category", category);
                }

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                panel.Controls.Clear();

                while (reader.Read())
                {
                    btnitem menuItem = new btnitem();
                    menuItem.ItemName = reader["Item"].ToString();
                    menuItem.ItemPrice = reader["Price"].ToString();

                    byte[] imgBytes = (byte[])reader["Image"];
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        menuItem.ItemImage = Image.FromStream(ms);
                    }

                    panel.Controls.Add(menuItem);
                }

                con.Close();
            }
        }

    }
}
