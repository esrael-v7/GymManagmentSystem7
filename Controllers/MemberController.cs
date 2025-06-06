using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.DTOs;
using Microsoft.Data.SqlClient;
using GymManagmentSystem7.DTOs;

namespace GymManagmentSystem7.Controller
{
    public class MemberController
    {
        public List<MemberResponseDTO> GetAllMembers()
        {
            var members = new List<MemberResponseDTO>();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
            SELECT 
                m.MemberId, 
                m.FirstName, 
                m.LastName, 
                m.Gender, 
                m.Age, 
                m.MembershipType,
                a.Username,
                a.Status,
                a.AccountId
            FROM Member m
            INNER JOIN Account a ON m.AccountId = a.AccountId";

                
                // Using SqlDataReader
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new MemberResponseDTO
                        {
                            MemberId = (int)reader["MemberId"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            MembershipType = reader["MembershipType"].ToString(),
                            Username = reader["Username"].ToString(),
                            Status = Convert.ToChar(reader["Status"]),
                            AccountId = Convert.ToInt32(reader["AccountId"])
                        });
                    }
                }

               
                // Using SqlDataAdapter
              
                /*
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    members.Add(new MemberResponseDTO
                    {
                        MemberId = Convert.ToInt32(row["MemberId"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Gender = row["Gender"].ToString(),
                        Age = Convert.ToInt32(row["Age"]),
                        MembershipType = row["MembershipType"].ToString(),
                        Username = row["Username"].ToString(),
                        Status = Convert.ToChar(row["Status"]),
                        AccountId = Convert.ToInt32(row["AccountId"])
                    });
                }
                */
            }

            return members;
        }
    }
}
