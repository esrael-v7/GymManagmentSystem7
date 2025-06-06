using GymManagementSystem7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem7.Models
{
    public class Attendance
    {
       
      public int AttendanceId { get; set; }
      public int MemberId { get; set; }
      public int TrainerId { get; set; }
      public DateTime Date { get; set; }
      public string Status { get; set; } // "P" or "A"
        

    }
}
