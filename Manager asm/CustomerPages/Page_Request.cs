using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_asm.CustomerPages
{
    public partial class Page_Request : UserControl
    {   
        Customer customer;

        public Page_Request()
        {
            InitializeComponent();
            customer = new Customer(5);

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = datepicker.Value.Date;
                int pax = cmbPax.SelectedIndex + 1;
                string type = cmbType.Text;

                string result = customer.RequestReservation(datetime, pax, type);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Page_Request_Load(object sender, EventArgs e)
        {
            // Set the ListView column headers
            lvReserve.Columns.Add("Reservation ID");
            lvReserve.Columns.Add("Date/Time");
            lvReserve.Columns.Add("Pax");
            lvReserve.Columns.Add("Type");
            lvReserve.Columns.Add("Status");

            // Load the reservation details
            customer.GetReservation(lvReserve);
        }
    }
}
