using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Services.Teachers;

namespace TestApi.Controllers
{
    [Route("api/teacher")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _service;
        public TeachersController(ITeacherService teacherService)
        {
            _service = teacherService;
        }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            var getTeachers = _service.GetAllTeacher();

            if (getTeachers == null)
            {
                return NotFound();
            }
            return Ok(getTeachers);
        }

        [HttpGet("{id}")]
        public IActionResult GetTeacher(int id)
        {
            var teacher = _service.GetTeacher(id);

            if(teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }
    }
}
