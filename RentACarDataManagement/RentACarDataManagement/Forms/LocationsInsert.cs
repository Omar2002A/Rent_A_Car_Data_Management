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
    public partial class LocationsInsert : Form
    {

        SqlConnection connection = Connections.connection;

        public LocationsInsert()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Locations (street, street_number, city, lstate, lcountry) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Location Added Successfully");
        }

        void clear_all()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";            
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
