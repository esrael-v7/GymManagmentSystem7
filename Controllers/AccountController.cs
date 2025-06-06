using System;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.Models;
using GymManagmentSystem7.DB;
using GymManagementSystem7.Models;

namespace GymManagmentSystem7.Controller
{
    public class AccountController
    {
        public AccountController() { }

        // ✅ 1. LOGIN
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

        // ✅ 2. TOGGLE ACCOUNT STATUS (ACTIVE ↔ DEACTIVATED)
        public bool ToggleAccountStatus(int accountId)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string checkSql = "SELECT Status FROM Account WHERE AccountId = @id";
                using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", accountId);
                    char currentStatus = Convert.ToChar(cmd.ExecuteScalar());

                    char newStatus = (currentStatus == 'A') ? 'D' : 'A';

                    string updateSql = "UPDATE Account SET Status = @status WHERE AccountId = @id";
                    SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@status", newStatus);
                    updateCmd.Parameters.AddWithValue("@id", accountId);

                    return updateCmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
