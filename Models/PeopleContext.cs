using Microsoft.EntityFrameworkCore;
using System.Data;
using System;

namespace TestApiProject.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Animal> Animals { get; set; }

        public DbSet<Color> Colors {get;set;}

        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {

        }

        public PeopleContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Console.WriteLine("<----------------BOO---------------->");
            modelBuilder.Entity<AnimalColor>()
                .HasKey(ac => new{ ac.AnimalId, ac.ColorId });
            modelBuilder.Entity<AnimalColor>()
                .HasOne(ac => ac.Animal)
                .WithMany(a => a.AnimalColors)
                .HasForeignKey(ac => ac.AnimalId);
            modelBuilder.Entity<AnimalColor>()
                .HasOne(ac => ac.Color)
                .WithMany(c => c.AnimalColors)
                .HasForeignKey(ac => ac.ColorId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"server=localhost;Port=8889;database=peopleApi;uid=root;pwd=root;");
    }
}