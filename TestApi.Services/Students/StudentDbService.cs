using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;
using TestApi.DataAccess;


namespace TestApi.Services.Students
{
    public class StudentDbService : IstudentService
    {
        private readonly TestApiDbContext _apiDbContext = new TestApiDbContext();

        public List<Student> GetStudents()
        {
            return _apiDbContext.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return _apiDbContext.Students.Find(id);
        }
    }
}
