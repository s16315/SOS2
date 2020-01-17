using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("MonthlyPlans")]
    public class MonthlyPlan : Entity
    {
        [Required]
        [StringLength(255)]
        public string Name {get; set;}  
        public ICollection<WeeklyPlan> WeeklyPlans {get; set;}        
        public MonthlyPlan()
        {
            WeeklyPlans = new Collection<WeeklyPlan>();
        }
    }
}