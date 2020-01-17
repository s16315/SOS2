using System;

namespace SOS.Models
{
    public abstract class Entity
    {
        public int Id {get; set;}
        public DateTime LastUpdate { get; set; }
    }
}