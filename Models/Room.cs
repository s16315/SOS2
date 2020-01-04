using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Rooms")]
    public class Room
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]

        public string Name {get; set;}
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