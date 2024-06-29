using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.Models.Enum;

namespace TestApi.DataAccess
{
    public class TestApiDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectingString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=TaskApiDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectingString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FirstName = "Janindu",
                LastName = "Maleesha",
                Address = "57/K Haggalla, Ellakkala.",
                City = "Nittambuwa",
                IsDeleted = DeleteStatus.INPROGRESS
            });
        }
    }
}
