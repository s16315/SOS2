using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("DailyPlans")]
    public class DailyPlan : Entity
    {
        [Required]
        public int DayNoInWeek {get; set;}
        [Required]
        public int DayNo {get; set;}         
        public ICollection<DailyRoomPlan> DailyRoomPlans {get; set;}
        
        public DailyPlan ()
        {
            DailyRoomPlans = new Collection<DailyRoomPlan>();
        }
    }
}