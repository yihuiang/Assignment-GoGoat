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
        private int managerID;
      
        private string ManName;
        private string email;
        private string phoneNum;
        private string address;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        
        public string Email { get => email; set => email = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        public int ManagerID { get => managerID; set => managerID = value; }
        public string ManName1 { get => ManName; set => ManName = value; }
        

        public Manager(int managerID,string ManName, string email, string phoneNum, string address)
        {
            this.managerID = managerID;
            
            this.ManName = ManName;
            this.email = email;
            this.phoneNum = phoneNum;
            this.address = address;
        }

        public static Manager GetManagerByName(string name)
        {
            Manager manager = null;
            string query = "SELECT ManagerID, Name, Email, PhoneNum, Address FROM Manager WHERE Name = @Name";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ManagerID"]);
                        string managerName = reader["Name"].ToString();
                        string email = reader["Email"].ToString();
                        string phoneNum = reader["PhoneNum"].ToString();
                        string address = reader["Address"].ToString();
                        manager = new Manager(id, managerName, email, phoneNum, address);
                    }
                }
                con.Close();
            }
            return manager;
        }
        public void Update()
        {
            string query = "UPDATE Manager SET Email = @Email, PhoneNum = @PhoneNum, Address = @Address WHERE ManagerID = @ManagerID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@PhoneNum", this.PhoneNum);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@ManagerID", this.ManagerID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }


}
