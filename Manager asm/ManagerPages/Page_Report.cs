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
        private string ConstructQuery(string month, string reservationType, string customer, out List<SqlParameter> parameters)
        {
            List<string> conditions = new List<string>();
            parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(month))
            {
                conditions.Add("FORMAT(Date, 'MMMM') = @Month");
                parameters.Add(new SqlParameter("@Month", month));
            }

            if (!string.IsNullOrEmpty(reservationType))
            {
                conditions.Add("Type = @ReservationType");
                parameters.Add(new SqlParameter("@ReservationType", reservationType));
            }

            if (!string.IsNullOrEmpty(customer))
            {
                conditions.Add("CustomerName = @Customer");
                parameters.Add(new SqlParameter("@Customer", customer));
            }

            string query = "SELECT * FROM TableReservation";
            if (conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            return query;
        }
        private List<string> GetDistinctCustomerNames()
        {
            List<string> customerNames = new List<string>();

            try
            {
                string connectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB; Integrated Security = True;");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT CustomerName FROM Reservation";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerNames.Add(reader["CustomerName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer names: " + ex.Message);
            }

            return customerNames;
        }


        private DataTable GetReservationData(string month, string reservationType, string customer)
        {
            DataTable dataTable = new DataTable();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }


        private string GetMostPopularTimeSlot(string month, string reservationType, string customer)
        {
            string popularTimeSlot = string.Empty;
            string connectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB; Integrated Security = True;");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);
                query = query.Replace("SELECT *", "SELECT TOP 1 Time, COUNT(*) AS ReservationCount ") + " GROUP BY Time ORDER BY ReservationCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            popularTimeSlot = reader["Time"].ToString();
                        }
                    }

                }
            }

            return popularTimeSlot;
        }
        private int GetCancellationCount(string month, string reservationType, string customer)
        {
            int cancellationCount = 0;
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GoDB.mdf;Integrated Security=True;TrustServerCertificate=True;Initial Catalog=GoDB;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<SqlParameter> parameters;
                string query = ConstructQuery(month, reservationType, customer, out parameters);

                // Ensure 'Status = 'Cancelled'' is properly appended to the WHERE clause
                if (query.Contains("WHERE"))
                {
                    query += " AND Status = 'Cancelled'";
                }
                else
                {
                    query += " WHERE Status = 'Cancelled'";
                }

                query = query.Replace("SELECT *", "SELECT COUNT(*)");

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    conn.Open();
                    cancellationCount = (int)cmd.ExecuteScalar();
                }
            }

            return cancellationCount;
        }

        private void PopulateComboBoxes()
        {
            monthComboBox.Items.AddRange(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            reservationTypeComboBox.Items.AddRange(new string[] { "Outdoor Dine-in", "Indoor Dine-in" });
            List<string> customerNames = GetDistinctCustomerNames();
            customerComboBox.Items.AddRange(customerNames.ToArray());
        }

        private void Page_Report_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
            generateReportButton.Click += new EventHandler(generateReportButton_Click);
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            string selectedMonth = monthComboBox.SelectedItem?.ToString();
            string selectedReservationType = reservationTypeComboBox.SelectedItem?.ToString();
            string selectedCustomer = customerComboBox.SelectedItem?.ToString();

            DataTable reservationData = GetReservationData(selectedMonth, selectedReservationType, selectedCustomer);
            reservationDataGridView.DataSource = reservationData;

            string popularTimeSlot = GetMostPopularTimeSlot(selectedMonth, selectedReservationType, selectedCustomer);
            popularTimeSlotLabel.Text = popularTimeSlot;

            int cancellationCount = GetCancellationCount(selectedMonth, selectedReservationType, selectedCustomer);
            cancellationCountLabel.Text = cancellationCount.ToString();

        }
        private void GeneratePDF(DataTable reservationData, string month, string reservationType, string customer)
        {
            string filePath = "ReservationReport.pdf"; // You can change this path if needed

            using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs);
                document.Open();

                // Add title
                document.Add(new iTextSharp.text.Paragraph("Go-Goat Reservation Report"));

                // Add filters
                if (!string.IsNullOrEmpty(month)) document.Add(new iTextSharp.text.Paragraph("Month: " + month));
                if (!string.IsNullOrEmpty(reservationType)) document.Add(new iTextSharp.text.Paragraph("Reservation Type: " + reservationType));
                if (!string.IsNullOrEmpty(customer)) document.Add(new iTextSharp.text.Paragraph("Customer: " + customer));
                document.Add(new iTextSharp.text.Paragraph(" ")); // Empty line

                // Add table
                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(reservationData.Columns.Count);
                // Add headers
                foreach (DataColumn column in reservationData.Columns)
                {
                    table.AddCell(new iTextSharp.text.Phrase(column.ColumnName));
                }
                // Add data rows
                foreach (DataRow row in reservationData.Rows)
                {
                    foreach (var cell in row.ItemArray)
                    {
                        table.AddCell(new iTextSharp.text.Phrase(cell.ToString()));
                    }
                }
                document.Add(table);

                // Add popular time slot and cancellations
                string popularTimeSlot = GetMostPopularTimeSlot(month, reservationType, customer);
                int cancellationCount = GetCancellationCount(month, reservationType, customer);
                document.Add(new iTextSharp.text.Paragraph("Most Popular Time Slot: " + popularTimeSlot));
                document.Add(new iTextSharp.text.Paragraph("Number of Cancellations: " + cancellationCount.ToString()));

                document.Close();
            }

            MessageBox.Show("PDF report generated successfully!");

            // Open the PDF file
            System.Diagnostics.Process.Start(filePath);
        }


        private void printReportButton_Click(object sender, EventArgs e)
        {
            string selectedMonth = monthComboBox.SelectedItem?.ToString();
            string selectedReservationType = reservationTypeComboBox.SelectedItem?.ToString();
            string selectedCustomer = customerComboBox.SelectedItem?.ToString();

            DataTable reservationData = GetReservationData(selectedMonth, selectedReservationType, selectedCustomer);
            GeneratePDF(reservationData, selectedMonth, selectedReservationType, selectedCustomer);
        }
    }
}
