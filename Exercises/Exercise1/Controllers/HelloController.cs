using Microsoft.AspNetCore.Mvc;

namespace Exercise1.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}