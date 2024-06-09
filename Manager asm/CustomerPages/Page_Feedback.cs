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
    public partial class Page_Feedback : UserControl
    {
        private int customerID;
        public Page_Feedback(int customerID)
        {
            InitializeComponent();
            Page_Feedback_Menu page_Feedback_Food = new Page_Feedback_Menu(customerID);
            addpage(page_Feedback_Food);
            this.customerID = customerID;
        }

        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelFeedback.Controls.Clear();
            panelFeedback.Controls.Add(Page);
            Page.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Page_Feedback_Menu page_Feedback_Food = new Page_Feedback_Menu(customerID);
            addpage(page_Feedback_Food);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Page_Feedback_Reservation page_Feedback_Reservation = new Page_Feedback_Reservation(customerID);  
            addpage(page_Feedback_Reservation);
        }
    }
}
