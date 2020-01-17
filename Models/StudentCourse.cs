using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("StudentCourses")]
    public class StudentCourse : Entity
    {
        [ForeignKey("Students")]
        public int StudentId {get; set;}
        public Student Student {get; set;}
        [ForeignKey("Courses")]
        public int CourseId {get; set;}
        public Course Course {get; set;}
    }
}