using Microsoft.AspNetCore.Mvc;

namespace Week7_ASP.NET.Controllers;

[ApiController]
[Route("[controller]")]
public class ByeController : ControllerBase  
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Later Gator!");
    }
}