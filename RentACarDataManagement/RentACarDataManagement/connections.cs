using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RentACarDataManagement
{
    internal class Connections
    {
        public static string databaseFileName = "Database1.mdf";
        public static string databasePath = System.IO.Path.Combine(Application.StartupPath, databaseFileName);

        public static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);

        
    }
}