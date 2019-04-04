using Microsoft.EntityFrameworkCore;
using System.Data;

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
            modelBuilder.Entity<AnimalColor>()
                .HasKey(x => new{x.AnimalId, x.ColorId});
            modelBuilder.Entity<AnimalColor>()
                .HasOne(x => x.Animal)
                .WithMany(y => y.Colors)
                .HasForeignKey(y => y.ColorId);
            modelBuilder.Entity<AnimalColor>()
                .HasOne(x => x.Color)
                .WithMany(y => y.Animals)
                .HasForeignKey(y => y.AnimalId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"server=localhost;Port=8889;database=peopleApi;uid=root;pwd=root;");
    }
}