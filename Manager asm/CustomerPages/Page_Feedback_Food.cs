using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Manager_asm.CustomerPages
{
    public partial class Page_Feedback_Food : UserControl
    {
        Customer customer;
        public Page_Feedback_Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                 customer = new Customer(6);

                // Call the SubmitFeedback method
                string result = customer.SubmitFeedback(foodQuality, staffFriendliness, priceWorthiness, portionSize, menuVariety, comments);

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
        private void Page_Feedback_Food_Load(object sender, EventArgs e)
        {

        }
    }
}

    
