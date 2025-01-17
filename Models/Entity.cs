using System;
using System.ComponentModel.DataAnnotations;

namespace SOS.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id {get; set;}
        public DateTime? LastUpdate { get; set; }
    }
}