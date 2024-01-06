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
    public partial class LocationsViews : Form
    {

        SqlConnection connection = new SqlConnection();

        public LocationsViews()
        {
            InitializeComponent();
            load_data();
        }

        void load_data()
        {
            connection.ConnectionString = Connections.connectionString;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Locations", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DGV1.DataSource = dataTable;
            connection.Close();
        }

        private void btn_addmore_Click(object sender, EventArgs e)
        {
            LocationsInsert locationsInsert = new LocationsInsert();
            locationsInsert.TopLevel = false;
            this.Parent.Controls.Add(locationsInsert);
            locationsInsert.Dock = DockStyle.Fill;
            locationsInsert.BringToFront();
            locationsInsert.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
