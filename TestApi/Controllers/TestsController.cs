using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Task()
        {
            var task = new string[] { "Task1", "Task2", "Task3" };
            return Ok(task);
        }

        [HttpPost]
        public IActionResult CreateTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
