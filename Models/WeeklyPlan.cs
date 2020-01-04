using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("WeeklyPlans")]
    public class WeeklyPlan
    {
        public int Id {get; set;}
        public ICollection<DailyPlan> DailyPlans {get; set;}        
        public WeeklyPlan()
        {
            DailyPlans = new Collection<DailyPlan>();
        }
    }   
}