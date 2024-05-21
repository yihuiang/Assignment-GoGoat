using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_asm
{
    internal class User
    {
        protected string username;
        protected string password;
        protected string role;

        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            role = "Customer";
        }

        public string login(string un)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from users where username=@a and password =@b", con);
            cmd.Parameters.AddWithValue("@a", username);
            cmd.Parameters.AddWithValue("@b", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)//if login success
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username =@a and password =@b", con);
                cmd2.Parameters.AddWithValue("@a", username);
                cmd2.Parameters.AddWithValue("@b", password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole == "Admin")
                {
                    //redirect to AdminHome form
                  //  AdminHome a = new AdminHome(un);
                    //a.ShowDialog();
                }
                else if (userRole == "Manager")
                {
                    FrmManagerUI s = new FrmManagerUI();
                    s.ShowDialog();
                }
                else if (userRole == "Chef")
                {
                   // StudentHome s = new StudentHome(un);
                   // s.ShowDialog();
                }
                else if (userRole == "Customer")
                {
                    frmCustomerUI s = new frmCustomerUI();
                    s.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();
            return status;
            //status = null if login success
            //status = "Incorrect username/password" if login fail.
        }
    }
}
