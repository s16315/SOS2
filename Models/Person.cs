using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOS.Models
{
    [Table("Persons")]
    public class Person : Entity
    {
        [Required]
        [StringLength(255)]
        public string FirstName {get; set;}
        [Required]
        [StringLength(255)]
        public string LastName {get; set;}
    }
}