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
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectingString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=TaskApiDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectingString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(new Teacher[]
            {
                new Teacher
                {
                    Id = 1,
                    FullName = "Ramya"
                },
                new Teacher
                {
                    Id = 2,
                    FullName = "Kalyani"
                },
                new Teacher
                {
                    Id = 3,
                    FullName = "Samanthi Kumari"
                },
                new Teacher
                {
                    Id = 4,
                    FullName = "Stela Rajasekara"
                }
            });

            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student
                {
                    Id = 2,
                    FirstName = "Ravindu",
                    LastName = "Himansha",
                    Address = "57/K Pinnagolla, Ellakkala.",
                    City = "Nittambuwa",
                    IsDeleted = DeleteStatus.INPROGRESS,
                    TeacherId = 1
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Hirusha",
                    LastName = "Dilshan",
                    Address = "57/K Haggalla, Pinnagolla.",
                    City = "Nittambuwa",
                    IsDeleted = DeleteStatus.INPROGRESS,
                    TeacherId = 1
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Tharindu",
                    LastName = "Harshana",
                    Address = "57/K Kottawa, Ellakkala.",
                    City = "Kottawa",
                    IsDeleted = DeleteStatus.INPROGRESS,
                    TeacherId = 3
                },
            });
        }
    }
}
