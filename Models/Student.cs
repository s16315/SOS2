using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Students")]
    public class Student
    {
        public int Id {get; set;}
    }
}