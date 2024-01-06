using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDataManagement.Forms
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            CustomersViews customersViews = new CustomersViews();
            gradientPanel1.Controls.Clear();
            customersViews.TopLevel = false;
            customersViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(customersViews);
            customersViews.Show();
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            CategoriesViews categoriesViews = new CategoriesViews();
            gradientPanel1.Controls.Clear();
            categoriesViews.TopLevel = false;
            categoriesViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(categoriesViews);
            categoriesViews.Show();
        }

        private void btn_Cars_Click(object sender, EventArgs e)
        {
            CarsViews carsViews = new CarsViews();
            gradientPanel1.Controls.Clear();
            carsViews.TopLevel = false;
            carsViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(carsViews);
            carsViews.Show();
        }

        private void btn_Locations_Click(object sender, EventArgs e)
        {
            LocationsViews locationsViews = new LocationsViews();
            gradientPanel1.Controls.Clear();
            locationsViews.TopLevel = false;
            locationsViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(locationsViews);
            locationsViews.Show();
        }

        private void btn_Phones_Click(object sender, EventArgs e)
        {
            PhonesViews phonesViews = new PhonesViews();
            gradientPanel1.Controls.Clear();
            phonesViews.TopLevel = false;
            phonesViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(phonesViews);
            phonesViews.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            ReservationsViews reservationsViews = new ReservationsViews();
            gradientPanel1.Controls.Clear();
            reservationsViews.TopLevel = false;
            reservationsViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(reservationsViews);
            reservationsViews.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void onload(object sender, EventArgs e)
        {
            gradientPanel1.Controls.Clear();
            ReservationsViews reservationsViews = new ReservationsViews();
            reservationsViews.TopLevel = false;
            reservationsViews.Dock = DockStyle.Fill;
            gradientPanel1.Controls.Add(reservationsViews);
            reservationsViews.Show();

        }
    }
}
