using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Instructors")]
    public class Instructor : Entity
    {
        [Required]
        [StringLength(255)]
        public string Login {get; set;}
        [ForeignKey("Persons")]
        public int PersonId {get; set;}
        public Person Person {get; set;}
        [ForeignKey("Languages")]
        public int LanguageId {get; set;}
        public Language Language {get; set;}
    }
}