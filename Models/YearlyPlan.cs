using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("YearlyPlans")]
    public class YearlyPlan : Entity
    {
        [Required]
        [StringLength(255)]
        public string Name {get; set;}  
        public ICollection<MonthlyPlan> MonthlyPlans {get; set;}
        public YearlyPlan()
        {
            MonthlyPlans = new Collection<MonthlyPlan>();
        }  
    }
}