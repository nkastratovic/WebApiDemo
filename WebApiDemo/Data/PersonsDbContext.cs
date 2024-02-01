using Microsoft.EntityFrameworkCore;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class PersonsDbContext : DbContext
    {
        public PersonsDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().ToTable("Persons");

            //Add Seed Data
            modelBuilder.Entity<Person>().HasData(new Person()
            {
                PersonId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = new DateTime(1992, 12, 13)
            });

            modelBuilder.Entity<Person>().HasData(new Person()
            {
                PersonId = Guid.NewGuid(),
                FirstName = "David",
                LastName = "Adams",
                DateOfBirth = new DateTime(1990, 09, 20)
            }); ;
        }
    }
}
