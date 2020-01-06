using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("WeeklyPlans")]
    public class WeeklyPlan
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Name {get; set;}  
        public ICollection<DailyPlan> DailyPlans {get; set;}        
        public WeeklyPlan()
        {
            DailyPlans = new Collection<DailyPlan>();
        }
    }   
}