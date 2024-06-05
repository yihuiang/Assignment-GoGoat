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

namespace Manager_asm
{
    internal class Menu
    {
        private string item;
        private string category;
        private double price;
        
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        
     

        private PictureBox pic = new PictureBox();

        public Menu(string item, string category, double price)
        {
            this.item = item;
            this.category = category;
            this.price = price;
        }

        

    }
}
