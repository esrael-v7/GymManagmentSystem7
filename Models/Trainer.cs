using System.ComponentModel.DataAnnotations;

namespace GymManagementSystem7.Models
{
    public class Trainer
    {
     public int TrainerId { get; set; }
     public string FirstName { get; set; }
     public string LastName { get; set; }
     public string Specialization { get; set; } 
     public int AccountId { get; set; }
     public virtual Account Account { get; set; }
    }
}
