using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.DataAccess;
using TestApi.Models;
using TestApi.Services.Students;

namespace TestApi.Services.Teachers
{
    public class TeacherService : ITeacherService
    {
        private readonly TestApiDbContext _context = new TestApiDbContext();
        public List<Teacher> GetAllTeacher()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacher(int id)
        {
            return _context.Teachers.Find(id);
        }
    }
}
