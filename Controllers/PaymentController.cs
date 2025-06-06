using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.DTOs;
using System.Data;

namespace GymManagmentSystem7.Controllers
{
    public class PaymentController
    {
        public List<PaymentResponseDTO> GetAllPayments()
        {
            var list = new List<PaymentResponseDTO>();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
                    SELECT 
                        p.PaymentId, 
                        p.Amount, 
                        p.PaymentDate,
                        m.FirstName + ' ' + m.LastName AS MemberFullName,
                        a.Status, 
                        a.AccountId
                    FROM Payment p
                    INNER JOIN Member m ON p.MemberId = m.MemberId
                    INNER JOIN Account a ON m.AccountId = a.AccountId";

                // SqlDataReader
                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PaymentResponseDTO
                        {
                            PaymentId = Convert.ToInt32(reader["PaymentId"]),
                            MemberFullName = reader["MemberFullName"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            PaymentDate = Convert.ToDateTime(reader["PaymentDate"]),
                            Status = reader["Status"].ToString(),
                            AccountId = Convert.ToInt32(reader["AccountId"])
                        });
                    }
                }


                // SqlDataAdapter
                /*
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // You can loop through DataTable if needed
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new PaymentResponseDTO
                    {
                        PaymentId = Convert.ToInt32(row["PaymentId"]),
                        MemberFullName = row["MemberFullName"].ToString(),
                        Amount = Convert.ToDecimal(row["Amount"]),
                        PaymentDate = Convert.ToDateTime(row["PaymentDate"]),
                        Status = row["Status"].ToString(),
                        AccountId = Convert.ToInt32(row["AccountId"])
                    });
                }
                */
            }

            return list;
        }

        public bool AddPayment(int memberId, decimal amount, DateTime paymentDate)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"INSERT INTO Payment (MemberId, Amount, PaymentDate)
                               VALUES (@MemberId, @Amount, @PaymentDate)";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable GetPaymentsByMember(int memberId)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"SELECT PaymentDate, Amount, 'Monthly Gym Payment' AS Description
                       FROM Payment
                       WHERE MemberId = @MemberId
                       ORDER BY PaymentDate DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
