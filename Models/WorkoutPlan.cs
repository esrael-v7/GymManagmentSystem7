using GymManagementSystem7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem7.Models
{
    public class WorkoutPlan
    {
        public int PlanId { get; set; }
        public int MemberId { get; set; }
        public int TrainerId { get; set; }
        public string Duration { get; set; }
        public DateTime AssignedDate { get; set; }

        // Navigation properties (optional for advanced use)
        public Member Member { get; set; }
        public Trainer Trainer { get; set; }
    }

}
