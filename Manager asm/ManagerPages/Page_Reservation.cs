using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Manager_asm.Pages
{
    public partial class Page_Reservation : UserControl
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        static SqlDataAdapter da;

        public Page_Reservation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Page_Reservation_Load(object sender, EventArgs e)
        {
            ShowReservationDatanotpending();
            ShowReservationDataPending();
        }
        //ok
        public void ShowReservationDatanotpending()
        {
            
            cmd = new SqlCommand("Select r.ReservationID,r.CustomerID ,c.Name, c.PhoneNum, r.Date, r.Time ,r.Pax, r.Type, r.Status From Reservation r inner join Customer c on r.CustomerID = c.CustomerID where Status != 'Pending' order by r.ReservationID desc", con);
            da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
       //ok
        private void ShowReservationDataPending()
        {
            cmd = new SqlCommand("Select r.ReservationID,r.CustomerID ,c.Name, c.PhoneNum, r.Date, r.Time,r.Pax, r.Type, r.Status From Reservation r inner join Customer c on r.CustomerID = c.CustomerID where Status = 'Pending' order by r.ReservationID desc", con);
            da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = table;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = txtboxName.Text;
            DateTime reservationDate = dateTimePicker1.Value.Date;
            TimeSpan reservationTime = dateTimePicker2.Value.TimeOfDay;

           
            int pax;
            if (cmbPax.SelectedItem != null && int.TryParse(cmbPax.SelectedItem.ToString(), out pax))
            {
                string type = cmbType.SelectedItem?.ToString(); 
                string status = "Confirmed";
                


                // Pass date and time separately to the Reservation constructor
                Reservation reservation = new Reservation(customerName, reservationDate, reservationTime, pax, type, status);
                MessageBox.Show(reservation.AddReservation());
            }
            else
            {
                MessageBox.Show("Please select a valid number of pax.");
            }
            ShowReservationDatanotpending();
            ShowReservationDataPending();
        }

        //ok
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtboxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbPax.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbType.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cmbStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }
        //ok
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtboxName.Text;
            DateTime reservationDate = dateTimePicker1.Value.Date;
            TimeSpan reservationTime = dateTimePicker2.Value.TimeOfDay;

            int pax = int.Parse(cmbPax.Text);
            Reservation obj = new Reservation(txtboxName.Text, reservationDate,reservationTime ,pax, cmbType.Text, cmbStatus.Text);
            MessageBox.Show(obj.UpdateReservation());
            ShowReservationDatanotpending();
            ShowReservationDataPending();
        }
        //ok
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            txtboxName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbPax.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            cmbType.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            cmbStatus.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string customerName = txtboxName.Text;
            DateTime reservationDate = dateTimePicker1.Value.Date;
            TimeSpan reservationTime = dateTimePicker2.Value.TimeOfDay;
            int pax = int.Parse(cmbPax.Text);
            Reservation obj = new Reservation(txtboxName.Text, reservationDate, reservationTime, pax, cmbType.Text, cmbStatus.Text); // Pax, Type, Status are not needed for deletion
            MessageBox.Show(obj.DeleteReservation());

            ShowReservationDatanotpending();
            ShowReservationDataPending();

        }
    }
}
