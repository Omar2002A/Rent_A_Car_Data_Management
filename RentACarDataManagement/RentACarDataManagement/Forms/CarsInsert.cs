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
    public partial class CarsInsert : Form
    {

        SqlConnection connection = Connections.connection;

        public CarsInsert()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Cars (VIN, car_desc, color, brand, model, cat_id, purch_date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Car Added Successfully");
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
