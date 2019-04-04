using Microsoft.EntityFrameworkCore;

namespace TestApiProject.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Animal> Animals { get; set; }

        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {

        }

        public PeopleContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(@"server=localhost;Port=8889;database=peopleApi;uid=root;pwd=root;");
    }
}