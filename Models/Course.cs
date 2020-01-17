using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Courses")]
    public class Course : Entity
    {
        [Required]
        [StringLength(255)]
        public string Name {get; set;}
        public ICollection<StudentCourse> StudentCourses {get; set;}
        //public int InstructorId {get; set;}
        public Instructor Instructor {get; set;}
        public ICollection<Lesson> Lessons {get; set;}
        //public int LanguageId {get; set;}
        public Language Language {get; set;}
    }
}