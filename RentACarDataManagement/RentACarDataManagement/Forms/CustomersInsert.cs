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

    public partial class CustomersInsert : Form
    {
        SqlConnection connection = Connections.connection;
        
        public CustomersInsert()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Customers (firstName, lastName, email, ssn, mobile, state_abbrev, state_name, country) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer Added Successfully");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        void clear_all()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }
    }
}
