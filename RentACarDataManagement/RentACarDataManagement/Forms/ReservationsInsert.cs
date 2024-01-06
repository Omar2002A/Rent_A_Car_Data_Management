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

namespace RentACarDataManagement.Forms
{
    public partial class ReservationsInsert : Form
    {

        SqlConnection connection = Connections.connection;

        public ReservationsInsert()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservations (VIN, customer_id, amount, p_loc, p_date, r_loc, r_date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Reservation Added Successfully");
        }

        void clear_all()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
