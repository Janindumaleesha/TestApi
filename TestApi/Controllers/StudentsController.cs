using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IstudentService _istudentService;

        public StudentsController(IstudentService istudentService) 
        {
            _istudentService = istudentService;
        }

        [HttpGet("{id?}")]
        public IActionResult GetAllStudent(int? id)
        {
            var student = _istudentService.GetStudents();

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
