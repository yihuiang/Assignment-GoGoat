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

    public class MenuZ
    {
        private string item;
        private string category;
        private double price;
        private Image image;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;



        public string Item { get => item; set => item = value; }
        public int ItemID { get; set; }
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

        public void LoadMenuItems(FlowLayoutPanel panel, string category)
        {
            //panel.Controls.Clear();
            string query = "SELECT Item, Price, Image FROM Menu";
            if (!string.IsNullOrEmpty(category) && category != "All")
            {
                query += " WHERE Category = @category";
            }
            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(category) && category != "All")
                    {
                        cmd.Parameters.AddWithValue("@category", category);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["Item"].ToString();
                            string itemPrice = "RM" + reader["Price"].ToString();
                            byte[] imgBytes = (byte[])reader["Image"];

                            // Debug: Check if the image bytes are not null and have length
                            if (imgBytes != null && imgBytes.Length > 0)
                            {
                                Image itemImage = ByteArrayToImage(imgBytes);

                                // Check if a btnitem control with the same item name already exists
                                btnitem existingMenuItem = panel.Controls.OfType<btnitem>().FirstOrDefault(item => item.ItemName == itemName);

                                if (existingMenuItem != null)
                                {
                                    // Update the existing btnitem control's properties
                                    existingMenuItem.ItemPrice = itemPrice;
                                    existingMenuItem.ItemImage = itemImage;
                                }
                                else
                                {
                                    // Create a new instance of btnitem control
                                    btnitem menuItem = new btnitem();
                                    menuItem.ItemName = itemName;
                                    menuItem.ItemPrice = itemPrice;
                                    menuItem.ItemImage = itemImage;

                                    panel.Controls.Add(menuItem);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Image data for item '{itemName}' is null or empty.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading menu items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }


    }
}

