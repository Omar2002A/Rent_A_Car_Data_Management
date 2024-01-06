using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace RentACarDataManagement.Forms
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query,Connections.connection))
            {
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                
                Connections.connection.Open();

                int result = (int)command.ExecuteScalar();

                if (result > 0)
                {
                    this.Hide();
                    DashBord dashBord = new DashBord();
                    dashBord.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }

                Connections.connection.Close();
            }
        }

        private void txtUsernameEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsernameLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
