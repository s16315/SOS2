using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Instructors")]
    public class Instructor
    {
        public int Id {get; set;}   
    }
}