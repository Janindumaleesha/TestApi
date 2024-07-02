using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Services.Students;

namespace TestApi.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IstudentService _istudentService;

        public StudentsController(IstudentService istudentService) 
        {
            _istudentService = istudentService;
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            var students = _istudentService.GetStudents();

            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _istudentService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
