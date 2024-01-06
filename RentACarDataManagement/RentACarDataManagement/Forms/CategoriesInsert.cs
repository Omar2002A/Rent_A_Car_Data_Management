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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACarDataManagement.Forms
{
    public partial class CategoriesInsert : Form
    {

        SqlConnection connection = Connections.connection;

        public CategoriesInsert()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Categories (cat_label, cat_description) values ('" + textBox1.Text + "','" + textBox2.Text + "')", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Categories Added Successfully");
        }

        void clear_all()
        {
            textBox1.Text = "";
            textBox2.Text = "";
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
