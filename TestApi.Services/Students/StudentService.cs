using TestApi.Models.Enum;
using TestApi.Models;

namespace TestApi.Services.Students
{
    public class StudentService : IstudentService
    {
        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            var students1 = new Student
            {
                Id = 1,
                FirstName = "Janindu",
                LastName = "Ariyasinghe",
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
