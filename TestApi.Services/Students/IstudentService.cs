using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Services.Students
{
    public interface IstudentService
    {
        public List<Student> GetStudents(int teacherId);
        public Student GetStudent(int teacherId, int id);
    }
}
