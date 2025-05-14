using System;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.Models;
using GymManagementSystem7.Models;

namespace GymManagmentSystem7.Data
{
    public class SuperAdminSeeder
    {
        private static readonly Guid SuperAdminGuid = new Guid("99999999-9999-9999-9999-999999999999");

        public void SeedSuperAdmin()
        {
            try
            {
                using (SqlConnection con = new DBConnection()._Connect)
                {
                    // Check if Super Admin already exists
                    string checkSql = "SELECT COUNT(*) FROM Account WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", "superadmin");
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                            return; // Already seeded
                    }

                    // Insert Super Admin
                    string insertSql = @"INSERT INTO Account (AccountGuid, Username, Password, Role, Status)
                                         VALUES (@Guid, @Username, @Password, @Role, @Status)";

                    using (SqlCommand cmd = new SqlCommand(insertSql, con))
                    {
                        cmd.Parameters.AddWithValue("@Guid", SuperAdminGuid);
                        cmd.Parameters.AddWithValue("@Username", "superadmin");
                        cmd.Parameters.AddWithValue("@Password", "admin123"); // Consider hashing later
                        cmd.Parameters.AddWithValue("@Role", AccountRole.Admin.ToString());
                        cmd.Parameters.AddWithValue("@Status", "A"); // Active status

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error seeding Super Admin:\n{ex.Message}",
                    "Seeder Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
