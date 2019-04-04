using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApiProject.Models
{
    [Table("Colors")]
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set;}
        public virtual ICollection<AnimalColor> AnimalColors {get;set;}

    }
}