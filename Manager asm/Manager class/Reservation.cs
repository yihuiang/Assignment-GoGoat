using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class Reservation
    {
        private string CustName;
        private string date;
        private string Time;
        private int Pax;
        private string Status;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Reservation(string CustName, string date, string Time, int Pax,string Status)
        {
            this.CustName = CustName;
            this.date = date;
            this.Time = Time;
            this.Pax = Pax;
            this.Status = Status;
        }
    }
}
