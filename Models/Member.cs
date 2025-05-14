using System.ComponentModel.DataAnnotations;

namespace GymManagementSystem7.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } 
        public int Age { get; set; }
        public string MembershipType { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}

       