using Microsoft.AspNetCore.Mvc;

namespace ASP.NETHTMLEx1.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController: ControllerBase
{ 
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}
