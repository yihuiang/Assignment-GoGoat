using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.CustomerPages
{
    public partial class Page_Feedback_Reservation : UserControl
    {
        Customer customer;
        private string con = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        public Page_Feedback_Reservation()
        {
            InitializeComponent();
        }

        private void Page_Feedback_Reservation_Load(object sender, EventArgs e)
        {
            // Fetch the customer's previous order IDs from the database
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "SELECT ReservationID FROM TableReservation WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", 2); //get customerid from login

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbOrderID.Items.Add(reader["OrderID"]);
                }
                reader.Close();
            }
        }
        private string GetSelectedValue(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                // Get the selected values from the radio buttons
                string atmoshpere = GetSelectedValue(grpAtmosphere);
                string cleanliness = GetSelectedValue(grpCleanliness);
                string ease = GetSelectedValue(grpEase);
                string flexibility = GetSelectedValue(grpFlexibility);
                string music = GetSelectedValue(grpMusic);

                // Get the comments from the text box
                string comments = richResFeedback.Text;

                // Create an instance of the Customer class
                customer = new Customer(6);

                // Call the SubmitFeedback method
                string result = customer.SubmitFeedbackReservation(atmoshpere, cleanliness, music, ease, flexibility, comments);

                // Display the result
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }

