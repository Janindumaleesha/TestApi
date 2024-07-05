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

        public List<Student> GetStudents(int teacherId)
        {
            return _apiDbContext.Students.Where(x => x.TeacherId == teacherId).ToList();
        }

        public Student GetStudent(int teacherId, int id)
        {
            return _apiDbContext.Students.FirstOrDefault(x => x.TeacherId == teacherId && x.Id == id);
        }
    }
}
