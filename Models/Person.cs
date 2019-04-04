using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApiProject.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public int Age { get; set;}
        public string Name { get; set; }
        public string Gender {get;set;}
        public virtual ICollection<Animal> Animals {get;set;}
    }
}