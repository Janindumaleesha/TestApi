using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Models.Enum;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsController() 
        {
            _studentService = new StudentService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetAllStudent(int? id)
        {
            var student = _studentService.GetStudents();

            if (id != null)
            {
                student.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                student.ToList();
            }
            return Ok(student);
        }
    }
}
