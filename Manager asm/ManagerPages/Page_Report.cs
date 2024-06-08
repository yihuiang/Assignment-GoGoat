using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Cryptography;


namespace Manager_asm.Pages
{
    public partial class Page_Report : UserControl
    {
        
        public Page_Report()
        {
            InitializeComponent();
        }

        private void PopulateComboBoxes()
        {
            List<string> customerNames = Reservation.GetDistinctCustomerNames();
            customerComboBox.Items.AddRange(customerNames.ToArray());
        }

        private void Page_Report_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
            generateReportButton.Click += new EventHandler(generateReportButton_Click);

            reservationDataGridView.RowTemplate.Height = 30;
            reservationDataGridView.AllowUserToAddRows = false;
            reservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationDataGridView.MultiSelect = false;
        }


        private void generateReportButton_Click(object sender, EventArgs e)
        {
            string selectedMonth = monthComboBox.SelectedItem?.ToString();
            string selectedReservationType = reservationTypeComboBox.SelectedItem?.ToString();
            string selectedCustomer = customerComboBox.SelectedItem?.ToString();

            DataTable reservationData = Reservation.GetReservationData(selectedMonth, selectedReservationType, selectedCustomer);

            // Set properties for DataGridView
            reservationDataGridView.RowTemplate.Height = 30;
            reservationDataGridView.AllowUserToAddRows = false;
            reservationDataGridView.DataSource = reservationData;
            reservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationDataGridView.MultiSelect = false;

            string popularTimeSlot = Reservation.GetMostPopularTimeSlot(selectedMonth, selectedReservationType, selectedCustomer);
            popularTimeSlotLabel.Text = popularTimeSlot;

            int cancellationCount = Reservation.GetCancellationCount(selectedMonth, selectedReservationType, selectedCustomer);
            cancellationCountLabel.Text = cancellationCount.ToString();
        }
    

        private void printReportButton_Click(object sender, EventArgs e)
        {
            string selectedMonth = monthComboBox.SelectedItem?.ToString();
            string selectedReservationType = reservationTypeComboBox.SelectedItem?.ToString();
            string selectedCustomer = customerComboBox.SelectedItem?.ToString();

            DataTable reservationData = Reservation.GetReservationData(selectedMonth, selectedReservationType, selectedCustomer);
            Reservation.GeneratePDF(reservationData, selectedMonth, selectedReservationType, selectedCustomer);
        }
    }
}
