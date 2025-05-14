using GymManagmentSystem7.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace GymManagementSystem7.Models
{
    public enum AccountRole
    {
        Member,
        Trainer,
        Cashier,
        Admin
    }

    public class Account
    {
        public Account()
        {
            AccountGuid = Guid.NewGuid();
            Status = "A";
        }
public int AccountId { get; set; }
        public Guid AccountGuid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountRole Role { get; set; }
        public string Status { get; set; }
        public virtual Member Member { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
      
        
