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
                    FullName = "Ramya",
                    AddressNo = "56",
                    Street = "Yakkala road",
                    City = "Gampaha"
                },
                new Teacher
                {
                    Id = 2,
                    FullName = "Kalyani",
                    AddressNo = "45",
                    Street = "Haowalla road",
                    City = "Haowalla"
                },
                new Teacher
                {
                    Id = 3,
                    FullName = "Samanthi Kumari",
                    AddressNo = "21",
                    Street = "Radawana road",
                    City = "Kirindiwala"
                },
                new Teacher
                {
                    Id = 4,
                    FullName = "Stela Rajasekara",
                    AddressNo = "65",
                    Street = "Waliweriya road",
                    City = "Gampaha"
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
