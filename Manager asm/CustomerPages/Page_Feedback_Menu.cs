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
    public partial class Page_Feedback_Menu : UserControl
    {
        Customer customer;
        private string con = ConfigurationManager.ConnectionStrings["myCS"].ToString();

        public Page_Feedback_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (cmbOrderID.SelectedValue == null)
                {
                    MessageBox.Show("Please select an order.");
                    return;
                }

                Feedback feedback = new Feedback
                {
                    CustomerID = (int)cmbOrderID.SelectedValue,
                    FoodQuality = GetSelectedRadioButtonText(grpFood),
                    StaffFriendliness = GetSelectedRadioButtonText(grpStaff),
                    PriceWorthiness = GetSelectedRadioButtonText(grpPrice),
                    PortionSize = GetSelectedRadioButtonText(GrpPortion),
                    MenuVariety = GetSelectedRadioButtonText(grpMenu),
                    Comments = richFoodFeedback.Text
                };

                feedback.SaveToDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while submitting feedback: {ex.Message}");
            }
            */

                
                try
                {

                    // Get the selected values from the radio buttons
                    string foodQuality = GetSelectedValue(grpFood);
                    string staffFriendliness = GetSelectedValue(grpStaff);
                    string priceWorthiness = GetSelectedValue(grpPrice);
                    string portionSize = GetSelectedValue(GrpPortion);
                    string menuVariety = GetSelectedValue(grpMenu);

                    // Get the comments from the text box
                    string comments = richFoodFeedback.Text;

                    // Create an instance of the Customer class
                     customer = new Customer(1);

                    // Call the SubmitFeedback method
                    string result = customer.SubmitFeedbackMenu(foodQuality, staffFriendliness, priceWorthiness, portionSize, menuVariety, comments);

                    // Display the result
                    MessageBox.Show(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
        
            private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
        private void Page_Feedback_Food_Load(object sender, EventArgs e)
        {
            //// Fetch the customer's previous order IDs from the database
            //using (SqlConnection conn = new SqlConnection(con))
            //{
            //    conn.Open();
            //    string query = "SELECT OrderID FROM Order WHERE CustomerID = @CustomerID";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@CustomerID", 2); //get customerid from login

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        cmbOrderID.Items.Add(reader["OrderID"]);
            //    }
            //    reader.Close();
            //}
        }
    }
}


