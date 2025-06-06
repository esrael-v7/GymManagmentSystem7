using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem7.DB;
using GymManagmentSystem7.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GymManagementSystem7.Models;
using System.Numerics;
using GymManagmentSystem7.DTOs;
using System.Data;


namespace GymManagmentSystem7.Controllers
{
    public class TrainerController
    {
        public List<TrainerResponseDTO> GetAllTrainers()
        {
            var trainers = new List<TrainerResponseDTO>();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
                SELECT 
                    t.TrainerId,
                    t.FirstName,
                    t.LastName,
                    t.Specialization,
                    a.Username,
                    a.Status,
                    a.AccountId
                FROM Trainer t
                INNER JOIN Account a ON t.AccountId = a.AccountId";

                
                // SqlDataReader 
               
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        trainers.Add(new TrainerResponseDTO
                        {
                            TrainerId = (int)reader["TrainerId"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Specialization = reader["Specialization"].ToString(),
                            Username = reader["Username"].ToString(),
                            Status = Convert.ToChar(reader["Status"]),
                            AccountId = Convert.ToInt32(reader["AccountId"])
                        });
                    }
                }

                
               
                // SqlDataAdapter
                /*
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    trainers.Add(new TrainerResponseDTO
                    {
                        TrainerId = Convert.ToInt32(row["TrainerId"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Specialization = row["Specialization"].ToString(),
                        Username = row["Username"].ToString(),
                        Status = Convert.ToChar(row["Status"]),
                        AccountId = Convert.ToInt32(row["AccountId"])
                    });
                }
                */
            }

            return trainers;
        }
        public List<WorkoutPlanResponseDTO> GetAllPlans()
        {
            var plans = new List<WorkoutPlanResponseDTO>();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
                  SELECT wp.PlanId, wp.MemberId, wp.TrainerId, wp.Duration, wp.AssignedDate,
                   m.FirstName + ' ' + m.LastName AS MemberFullName,
                   t.FirstName + ' ' + t.LastName AS TrainerFullName,
                   a.Status
                  FROM WorkoutPlan wp
                  JOIN Member m ON wp.MemberId = m.MemberId
                  JOIN Trainer t ON wp.TrainerId = t.TrainerId
                  JOIN Account a ON m.AccountId = a.AccountId";

                // SqlDataReader 

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        plans.Add(new WorkoutPlanResponseDTO
                        {
                            PlanId = Convert.ToInt32(reader["PlanId"]),
                            MemberId = Convert.ToInt32(reader["MemberId"]),
                            TrainerId = Convert.ToInt32(reader["TrainerId"]),
                            Duration = reader["Duration"].ToString(),
                            AssignedDate = Convert.ToDateTime(reader["AssignedDate"]),
                            MemberFullName = reader["MemberFullName"].ToString(),
                            TrainerFullName = reader["TrainerFullName"].ToString(),
                            Status = Convert.ToChar(reader["Status"])
                        });
                    }
                }

                // SqlDataAdapter
                /*
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    plans.Add(new WorkoutPlanResponseDTO
                    {
                        PlanId = Convert.ToInt32(row["PlanId"]),
                        MemberId = Convert.ToInt32(row["MemberId"]),
                        TrainerId = Convert.ToInt32(row["TrainerId"]),
                        Duration = row["Duration"].ToString(),
                        AssignedDate = Convert.ToDateTime(row["AssignedDate"]),
                        MemberFullName = row["MemberFullName"].ToString(),
                        TrainerFullName = row["TrainerFullName"].ToString(),
                        Status = Convert.ToChar(row["Status"])
                    });
                }
                */

                return plans;
            }
        }


        public bool AddPlan(WorkoutPlan plan)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"INSERT INTO WorkoutPlan (MemberId, TrainerId, Duration, AssignedDate)
                       VALUES (@MemberId, @TrainerId, @Duration, @AssignedDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", plan.MemberId);
                cmd.Parameters.AddWithValue("@TrainerId", plan.TrainerId);
                cmd.Parameters.AddWithValue("@Duration", plan.Duration);
                cmd.Parameters.AddWithValue("@AssignedDate", plan.AssignedDate);
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public bool UpdatePlan(int planId, int memberId, string duration, DateTime assignedDate)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"UPDATE WorkoutPlan 
                       SET MemberId = @MemberId, Duration = @Duration, AssignedDate = @AssignedDate
                       WHERE PlanId = @PlanId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@AssignedDate", assignedDate);
                cmd.Parameters.AddWithValue("@PlanId", planId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public bool DeletePlan(WorkoutPlan plan)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"DELETE FROM WorkoutPlan WHERE PlanId = @PlanId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PlanId", plan.PlanId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<AttendanceResponseDTO> GetAllAttendance()
        {
            var data = new List<AttendanceResponseDTO>();

            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
            SELECT 
                a.AttendanceId,
                a.MemberId,
                m.FirstName + ' ' + m.LastName AS MemberFullName,
                a.Date,
                a.Status
            FROM Attendance a
            JOIN Member m ON a.MemberId = m.MemberId";

                // SqlDataReader
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(new AttendanceResponseDTO
                        {
                            AttendanceId = Convert.ToInt32(reader["AttendanceId"]),
                            MemberId = Convert.ToInt32(reader["MemberId"]),
                            MemberFullName = reader["MemberFullName"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"]),
                            Status = reader["Status"].ToString()
                        });
                    }
                }

                
                //SqlDataAdapter
                /*
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    data.Add(new AttendanceResponseDTO
                    {
                        AttendanceId = Convert.ToInt32(row["AttendanceId"]),
                        MemberId = Convert.ToInt32(row["MemberId"]),
                        MemberFullName = row["MemberFullName"].ToString(),
                        Date = Convert.ToDateTime(row["Date"]),
                        Status = row["Status"].ToString()
                    });
                }
                */
            }

            return data;
        }
        public bool AddAttendance(Attendance att)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"INSERT INTO Attendance (MemberId, TrainerId, Date, Status)
                       VALUES (@MemberId, @TrainerId, @Date, @Status)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", att.MemberId);
                cmd.Parameters.AddWithValue("@TrainerId", att.TrainerId);
                cmd.Parameters.AddWithValue("@Date", att.Date);
                cmd.Parameters.AddWithValue("@Status", att.Status);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable GetPlansByMember(int memberId)
        {
            using (var conn = new DBConnection()._Connect)
            {
                string sql = @"
            SELECT 
                wp.PlanId,
                wp.Duration,
                wp.AssignedDate,
                CONCAT(t.FirstName, ' ', t.LastName) AS Trainer
            FROM WorkoutPlan wp
            INNER JOIN Trainer t ON wp.TrainerId = t.TrainerId
            WHERE wp.MemberId = @MemberId";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MemberId", memberId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // ✅ Error may occur here if SQL is broken
                    return dt;
                }
            }
        }
    }
    
}

