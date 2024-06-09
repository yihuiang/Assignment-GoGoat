using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.ChefPagess
{
    public partial class Page_Orders_Chef : UserControl
    {
        ChefClass chef = new ChefClass();

        public Page_Orders_Chef()
        {
            InitializeComponent();
            LoadOrders();
        }

                private void Page_Orders_Chef_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            DataTable dt = chef.GetOrders();
            datagridviewOrders.DataSource = dt;
        }


        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (datagridviewOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in datagridviewOrders.SelectedRows)
                {
                    int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);
                    chef.UpdateOrderStatus(orderID, "In Progress");
                }
                MessageBox.Show("Order(s) accepted successfully!");
                LoadOrders(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select an order to accept.");
            }
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            if (datagridviewOrders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in datagridviewOrders.SelectedRows)
                {
                    int orderID = Convert.ToInt32(row.Cells["OrderID"].Value);
                    chef.UpdateOrderStatus(orderID, "Completed");
                }
                MessageBox.Show("Order(s) completed successfully!");
                LoadOrders(); // Refresh the DataGridView
            }
            else
            {
                MessageBox.Show("Please select an order to complete.");
            }
        }
    }
}
