using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Courses")]
    public class Course
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Name {get; set;}
        public ICollection<Student> Students {get; set;}
        public ICollection<Instructor> Instructors {get; set;}
        public ICollection<Lesson> Lessons {get; set;}
    }
}