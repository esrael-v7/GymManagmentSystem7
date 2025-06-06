

namespace GymManagmentSystem7.DTOs
{
    public class MemberResponseDTO
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string MembershipType { get; set; }

        // Account-related fields
        public string Username { get; set; }
        public char Status { get; set; }
        public int AccountId { get; set; }
    }
    public class AccountResponseDTO
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public char Status { get; set; }  // A or D
    }


    public class AttendanceDTO
    {
        public int AttendanceId { get; set; }
        public int MemberId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
    public class TrainerResponseDTO
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }

        // Account-related
        public string Username { get; set; }
        public char Status { get; set; }
        public int AccountId { get; set; }
    }
    public class PaymentResponseDTO
    {
        public int PaymentId { get; set; }
        public string MemberFullName { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }  // From Member.Account.Status
        public int AccountId { get; set; }
    }
    public class WorkoutPlanResponseDTO
    {
        public int PlanId { get; set; }
        public int MemberId { get; set; }
        public int TrainerId { get; set; }
        public string Duration { get; set; }
        public DateTime AssignedDate { get; set; }
        public char Status { get; set; }


        // Optional display fields
        public string MemberFullName { get; set; }
        public string TrainerFullName { get; set; }
    }
    public class AttendanceResponseDTO
    {
        public int AttendanceId { get; set; }
        public int MemberId { get; set; }
        public string MemberFullName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}