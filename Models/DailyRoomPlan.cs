using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("DailyRoomPlans")]
    public class DailyRoomPlan
    {
        public int Id {get; set;}
        public Room Room {get; set;}
        public Lesson Lesson01 {get; set;}
        public Lesson Lesson02 {get; set;}
        public Lesson Lesson03 {get; set;}
        public Lesson Lesson04 {get; set;}
        public Lesson Lesson05 {get; set;}
        public Lesson Lesson06 {get; set;}
        public Lesson Lesson07 {get; set;}
        public Lesson Lesson08 {get; set;}
        public Lesson Lesson09 {get; set;}
        public Lesson Lesson10 {get; set;}
    }
}