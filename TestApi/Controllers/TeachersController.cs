using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Services.Teachers;
using TestApi.Services.ViewModels;

namespace TestApi.Controllers
{
    [Route("api/teacher")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _service;
        private readonly IMapper _mapper;

        public TeachersController(ITeacherService teacherService, IMapper mapper)
        {
            _service = teacherService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TeacherViewModel>> GetTeachers()
        {
            var getTeachers = _service.GetAllTeacher();
            //var getTeachersView = new List<TeacherViewModel>();

            if (getTeachers == null)
            {
                return NotFound();
            }

            var mapperTeachers = _mapper.Map<ICollection<TeacherViewModel>>(getTeachers);

            /*foreach (var item in getTeachers)
            {
                getTeachersView.Add(new TeacherViewModel 
                {
                    Id = item.Id,
                    FullName = item.FullName,
                    Address = $"{item.AddressNo}, {item.Street}, {item.City}"
                });
            }*/

            return Ok(mapperTeachers);
        }

        [HttpGet("{id}")]
        public IActionResult GetTeacher(int id)
        {
            var teacher = _service.GetTeacher(id);

            if(teacher == null)
            {
                return NotFound();
            }

            var mapperTeacher = _mapper.Map<TeacherViewModel>(teacher);
            return Ok(teacher);
        }
    }
}
