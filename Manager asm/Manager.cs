using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Manager_asm
{
    internal class Manager
    {
        private int managerID;
        private int userID;
        private string name;
        private string email;
        private string phoneNum;
        private string address;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Manager(int managerID, int userID, string name, string email, string phoneNum, string address)
        {
            this.managerID = managerID;
            this.userID = userID;
            this.name = name;
            this.email = email;
            this.phoneNum = phoneNum;
            this.address = address;
        }
        public static Manager GetManagerByUserID(int userID)
        {
            Manager manager = null;
            string query = "SELECT ManagerID, Name, Email, PhoneNum, Address FROM Manager WHERE UserID = @UserID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int managerID = Convert.ToInt32(reader["ManagerID"]);
                        string name = reader["Name"].ToString();
                        string email = reader["Email"].ToString();
                        string phoneNum = reader["PhoneNum"].ToString();
                        string address = reader["Address"].ToString();
                        manager = new Manager(managerID, userID, name, email, phoneNum, address);
                    }
                }
                con.Close();
            }

            return manager;
        }
        public void UpdateManager()
        {
            string query = "UPDATE Manager SET Name = @Name, Email = @Email, PhoneNum = @PhoneNum, Address = @Address WHERE ManagerID = @ManagerID";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNum", phoneNum);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@ManagerID", managerID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }

}
