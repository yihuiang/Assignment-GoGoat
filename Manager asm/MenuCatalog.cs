using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class MenuCatalog
    {
        private string foodname;
        private double price;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public MenuCatalog(string foodname, double price)
        {
            this.foodname = foodname;
            this.price = price;
        }

        

       
    }
}
