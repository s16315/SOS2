using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Name {get; set;}
        
    }
}