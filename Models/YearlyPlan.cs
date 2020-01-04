using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("YearlyPlans")]
    public class YearlyPlan
    {
        public int Id {get; set;}
        public ICollection<MonthlyPlan> MonthlyPlans {get; set;}
        public YearlyPlan()
        {
            MonthlyPlans = new Collection<MonthlyPlan>();
        }  
    }
}