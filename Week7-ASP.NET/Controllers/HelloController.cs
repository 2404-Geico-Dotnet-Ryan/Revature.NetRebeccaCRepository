using Microsoft.AspNetCore.Mvc;

namespace Week7_ASP.NET.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase  
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }
}
/*
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }
}
*/

