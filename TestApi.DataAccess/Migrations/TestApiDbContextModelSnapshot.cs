﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi.DataAccess;

#nullable disable

namespace TestApi.DataAccess.Migrations
{
    [DbContext(typeof(TestApiDbContext))]
    partial class TestApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestApi.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Address = "57/K Pinnagolla, Ellakkala.",
                            City = "Nittambuwa",
                            FirstName = "Ravindu",
                            IsDeleted = 0,
                            LastName = "Himansha",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "57/K Haggalla, Pinnagolla.",
                            City = "Nittambuwa",
                            FirstName = "Hirusha",
                            IsDeleted = 0,
                            LastName = "Dilshan",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "57/K Kottawa, Ellakkala.",
                            City = "Kottawa",
                            FirstName = "Tharindu",
                            IsDeleted = 0,
                            LastName = "Harshana",
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("TestApi.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "56",
                            City = "Gampaha",
                            FullName = "Ramya",
                            Street = "Yakkala road"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "45",
                            City = "Haowalla",
                            FullName = "Kalyani",
                            Street = "Haowalla road"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "21",
                            City = "Kirindiwala",
                            FullName = "Samanthi Kumari",
                            Street = "Radawana road"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "65",
                            City = "Gampaha",
                            FullName = "Stela Rajasekara",
                            Street = "Waliweriya road"
                        });
                });

            modelBuilder.Entity("TestApi.Models.Student", b =>
                {
                    b.HasOne("TestApi.Models.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("TestApi.Models.Teacher", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
