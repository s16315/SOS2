using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Lessons")]
    public class Lesson
    {
        public int Id {get; set;}
        public bool Replacement {get; set;}
    }
}