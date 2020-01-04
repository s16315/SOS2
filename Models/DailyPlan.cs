using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("DailyPlans")]
    public class DailyPlan
    {
        public int Id {get; set;}
        public ICollection<Room> Rooms {get; set;}
        
        public DailyPlan ()
        {
            Rooms = new Collection<Room>();
        }
    }
}