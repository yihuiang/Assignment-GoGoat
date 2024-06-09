using Manager_asm.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Manager_asm
{
    internal class Manager
    {
        private string manName;
        private string email;
        private string phoneNum;
        private string address;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;

        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        
        public string ManName { get => manName; set => manName = value; }
       

        public Manager(string manName, string email, string phoneNum, string address)
        {
            
            this.manName = manName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.address = address;
        }

        public Manager(string username)
        {
            manName = username;
        }

        

        public static void viewProfile(Manager o1)//object as parameter
        {
            con.Open();
            cmd = new SqlCommand("select * from Manager where Name = @a", con);
            cmd.Parameters.AddWithValue("@a", o1.manName);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.manName = rd.GetString(2);
                o1.email = rd.GetString(3);
                o1.phoneNum = rd.GetString(4);
                o1.address = rd.GetString(5);
            }
            con.Close();
        }
        public string updateProfile(string em, string num,string add)
        {
            string status; con.Open();
            SqlCommand cmd = new SqlCommand("update Manager set Email =@e, PhoneNum=@p , Address = @add where Name =@mn", con);// can change the update to delete 
            cmd.Parameters.AddWithValue("@e", em);
            cmd.Parameters.AddWithValue("@p", num);
            cmd.Parameters.AddWithValue("add", add);
            cmd.Parameters.AddWithValue("@nm", manName);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

        public static void viewLogin(User o1)//object as parameter
        {
            con.Open();
            cmd = new SqlCommand("select Username ,Password from Users where Username = @a", con);
            cmd.Parameters.AddWithValue("@a", o1.username);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.username = rd.GetString(0);
                o1.password = rd.GetString(1);
            }
            con.Close();
        }
        public string updatePass(string ps)
        {
            string status; con.Open();
            SqlCommand cmd = new SqlCommand("update Users set Password =@ps where Username =@mn", con);// can change the update to delete 
            cmd.Parameters.AddWithValue("@ps", ps);
            cmd.Parameters.AddWithValue("@mn", manName);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();
            return status;
        }

    }

}




