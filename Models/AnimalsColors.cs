using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApiProject.Models
{
    [Table("AnimalColor")]
    public class AnimalColor
    {
        [Key]
        public int AnimalId { get; set; }
        public int ColorId {get;set;}
        public Animal Animal {get;set;}
        public Color Color {get;set;}
    }
}