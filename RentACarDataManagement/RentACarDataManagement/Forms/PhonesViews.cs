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
    public partial class PhonesViews : Form
    {

        SqlConnection connection = new SqlConnection();

        public PhonesViews()
        {
            InitializeComponent();
            load_data();
        }

        void load_data()
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Phones", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGV1.DataSource = dataTable;
            connection.Close();
        }

        private void btn_addmore_Click(object sender, EventArgs e)
        {
            PhonesInsert phonesInsert = new PhonesInsert();
            phonesInsert.TopLevel = false;
            this.Parent.Controls.Add(phonesInsert);
            phonesInsert.Dock = DockStyle.Fill;
            phonesInsert.BringToFront();
            phonesInsert.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
