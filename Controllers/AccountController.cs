using System;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.Models;
using GymManagmentSystem7.DB;
using GymManagementSystem7.Models;

namespace GymManagmentSystem7.Controller
{
    public class AccountController
    {
        public AccountController()
        {
        }


        public (Account, string) Login(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new DBConnection()._Connect)
                {
                    string query = @"SELECT AccountId, AccountGuid, Username, Password, Role, Status 
                             FROM Account 
                             WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["Password"].ToString();
                                string role = reader["Role"].ToString();
                                string status = reader["Status"].ToString();

                                if (dbPassword != password)
                                    return (null, "Invalid username or password.");

                                if (status != "A")
                                    return (null, "Your account is deactivated.");

                                var account = new Account
                                {
                                    AccountId = Convert.ToInt32(reader["AccountId"]),
                                    AccountGuid = Guid.Parse(reader["AccountGuid"].ToString()),
                                    Username = reader["Username"].ToString(),
                                    Password = dbPassword,
                                    Role = Enum.Parse<AccountRole>(role),
                                    Status = status
                                };

                                return (account, "Login successful.");
                            }
                            else
                            {
                                return (null, "Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, "Error: " + ex.Message);
            }
        }

    }
}
