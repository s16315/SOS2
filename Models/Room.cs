using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS.Models
{
    [Table("Rooms")]
    public class Room
    {
        public int Id {get; set;}
        [Required]
        [StringLength(255)]

        public string Name {get; set;}

    }
}