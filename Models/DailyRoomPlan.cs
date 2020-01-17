using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("DailyRoomPlans")]
    public class DailyRoomPlan : Entity
    {
        public int RoomId;
        public Room Room {get; set;}
        public int Lesson01Id {get; set;}
        public Lesson Lesson01 {get; set;}
        public int Lesson02Id {get; set;}
        public Lesson Lesson02 {get; set;}
        public int Lesson03Id {get; set;}
        public Lesson Lesson03 {get; set;}
        public int Lesson04Id {get; set;}
        public Lesson Lesson04 {get; set;}
        public int Lesson05Id {get; set;}
        public Lesson Lesson05 {get; set;}
        public int Lesson06Id {get; set;}
        public Lesson Lesson06 {get; set;}
        public int Lesson07Id {get; set;}
        public Lesson Lesson07 {get; set;}
        public int Lesson08Id {get; set;}
        public Lesson Lesson08 {get; set;}
        public int Lesson09Id {get; set;}
        public Lesson Lesson09 {get; set;}
        public int Lesson10Id {get; set;}
        public Lesson Lesson10 {get; set;}
    }
}