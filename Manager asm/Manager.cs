using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class Manager
    {
        private string ManName;
        private string email;
        private string phoneNum;
        private string Address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Manager(string ManName, string email, string phoneNum, string Address)
        {
            this.ManName = ManName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.Address = Address;
        }

        public Manager(string mn)
        {
            ManName = mn;
        }

        
    }


    
}
