using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Languages")]
    public class Language : Entity
    {
        [Required]
        [StringLength(255)]
        public string Name {get; set;}        
    }
}