using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApiProject.Models
{
    [Table("Animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set;}
        public string Species { get; set; }
        public int PersonId {get;set;}
        public virtual Person Person {get;set;}
        public virtual ICollection<AnimalColor> Colors {get;set;}
    }
}