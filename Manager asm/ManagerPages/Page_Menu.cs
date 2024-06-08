using Manager_asm.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.User_Control
{
    public partial class Page_Menu : UserControl
    {
        private MenuZ menu;
        private Order order;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        static SqlDataReader dr;

        private PictureBox pic;
        private Label name;
        private Label price;
        public Page_Menu()
        {
            InitializeComponent();
            menu  = new MenuZ();
            
        }
        private void LoadMenuItems(string category)
        {
            flowLayoutPanelMenu.Controls.Clear();
            menu.LoadMenuItems(flowLayoutPanelMenu, category);
        }

        private void Page_Menu_Load(object sender, EventArgs e)
        {
            order = new Order(lstCart);
            order.DisplayCart();
            LoadMenuItems("All");
            //GetMenuItems();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Noodle");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadMenuItems("All");

        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            LoadMenuItems("Sandwich");
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
           LoadMenuItems("Beverage");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /*
        private void LoadMenuItems(string category)
        {
            flowLayoutPanelMenu.Controls.Clear();
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
                            Image itemImage = ByteArrayToImage(imgBytes);

                            btnitem menuItem = new btnitem
                            {
                                ItemName = itemName,
                                ItemPrice = itemPrice,
                                ItemImage = itemImage
                            };
                            flowLayoutPanelMenu.Controls.Add(menuItem);
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
        
        private void GetMenuItems()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Item, Price, Image FROM Menu", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Retrieve image data using column index
                byte[] imgBytes = (byte[])dr[2]; // Assuming 'Image' column is at index 2

                // Create PictureBox and configure it
                pic = new PictureBox();
                pic.Width = 150;
                pic.Height = 150;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                // Create Label for item name
                name = new Label();
                name.Text = dr["Item"].ToString();
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Dock = DockStyle.Fill;

                // Convert byte array to Bitmap and set as background image
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    Bitmap bmp = new Bitmap(ms);
                    pic.BackgroundImage = bmp;
                }

                // Add label to PictureBox and PictureBox to FlowLayoutPanel
                pic.Controls.Add(name);
                flowLayoutPanelMenu.Controls.Add(pic);
            }
            dr.Close();
            con.Close();
            
        }
        */

    }

}




