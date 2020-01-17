using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Lessons")]
    public class Lesson : Entity
    {
        public bool Replacement {get; set;}
        /*[ForeignKey("Course")]
        public int CourseId {get; set;}*/
    }
}