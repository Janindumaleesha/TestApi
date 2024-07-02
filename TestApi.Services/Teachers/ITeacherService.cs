using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Services.Teachers
{
    public interface ITeacherService
    {
        public List<Teacher> GetAllTeacher();
        public Teacher GetTeacher(int id);
    }
}
