using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Students")]
    public class Student : Entity
    {
        [Required]
        [StringLength(255)]
        public string Login {get; set;}
        [ForeignKey("Persons")]
        public int PersonId {get; set;}
        public Person Person {get; set;}
        public ICollection<StudentCourse> StudentCourses {get; set;}
    }
}