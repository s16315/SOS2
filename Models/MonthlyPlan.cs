using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("MonthlyPlans")]
    public class MonthlyPlan
    {
        public int Id {get; set;}
        public ICollection<WeeklyPlan> WeeklyPlans {get; set;}        
        public MonthlyPlan()
        {
            WeeklyPlans = new Collection<WeeklyPlan>();
        }
    }
}