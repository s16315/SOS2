using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SOS.Models
{
    public class DailyPlanLesson
    {
        public int Id {get; set;}
        public ICollection<Room> Rooms {get; set;}
        
        public DailyPlanLesson ()
        {
            Rooms = new Collection<Room>();
        }
    }
}