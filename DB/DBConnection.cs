using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace GymManagmentSystem7.DB
{
    class DBConnection
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hudso\OneDrive\Desktop\cobra kai\GymManagmentSystem7\Database1.mdf;Integrated Security=True";
        public SqlConnection _Connect
        {
            get 
            {
                var con  = new SqlConnection(connectionString);
                con.Open();
                return con;
            }
        }

    }
}

