﻿using TestApi.Models.Enum;
using TestApi.Models;

namespace TestApi.Services
{
    public class StudentService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            var students1 = new Student
            {
                Id = 1,
                FirstName = "Janindu",
                LastName = "Maleesha",
                Address = "57/K Haggalla, Ellakkala.",
                City = "Nittambuwa",
                IsDeleted = DeleteStatus.INPROGRESS
            };

            students.Add(students1);

            var students2 = new Student
            {
                Id = 2,
                FirstName = "Ravindu",
                LastName = "Himansha",
                Address = "57/K Pinnagolla, Ellakkala.",
                City = "Nittambuwa",
                IsDeleted = DeleteStatus.INPROGRESS
            };

            students.Add(students2);

            var students3 = new Student
            {
                Id = 3,
                FirstName = "Tharindu",
                LastName = "Harshana",
                Address = "57/K Kttawa, Ellakkala.",
                City = "Kottawa",
                IsDeleted = DeleteStatus.DELETED
            };

            students.Add(students3);

            return students;
        }
    }
}
