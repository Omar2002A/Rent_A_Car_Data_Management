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
    public partial class ReservationsViews : Form
    {

        SqlConnection connection = Connections.connection;

        public ReservationsViews()
        {
            InitializeComponent();
            load_data();
        }

        void load_data()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }            
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Reservations", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DGV1.DataSource = dt;
            connection.Close();
        }

        private void btn_addmore_Click(object sender, EventArgs e)
        {
            ReservationsInsert reservationsInsert = new ReservationsInsert();
            reservationsInsert.TopLevel = false;
            this.Parent.Controls.Add(reservationsInsert);
            reservationsInsert.Dock = DockStyle.Fill;
            reservationsInsert.BringToFront();
            reservationsInsert.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
