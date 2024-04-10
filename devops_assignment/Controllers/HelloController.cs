using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devops_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, World!" });
        }

    }
}
