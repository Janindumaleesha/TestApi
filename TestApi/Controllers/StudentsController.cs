using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Services.Students;
using TestApi.Services.ViewModels;

namespace TestApi.Controllers
{
    [Route("api/teachers/{teacherId}/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IstudentService _istudentService;
        private readonly IMapper _mapper;

        public StudentsController(IstudentService istudentService, IMapper mapper) 
        {
            _istudentService = istudentService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<StudentViewModel>> GetAllStudent(int teacherId)
        {
            //throw new Exception("eror");
            var students = _istudentService.GetStudents(teacherId);

            if (students == null)
            {
                return NotFound();
            }

            var mappedStudents = _mapper.Map<ICollection<StudentViewModel>>(students);

            return Ok(mappedStudents);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int teacherId, int id)
        {
            var student = _istudentService.GetStudent(teacherId, id);

            if (student == null)
            {
                return NotFound();
            }

            var mappedStudent = _mapper.Map<StudentViewModel>(student);

            return Ok(mappedStudent);
        }
    }
}
