using Microsoft.AspNetCore.Mvc;

namespace Week7_ASP.Net.Controllers;

[ApiController]
[Route("[controller]")]

public class HaveAGoodDayController : ControllerBase
{
    [HttpGet]
    public IActionResult Get ()
    {
        return Ok("Have a Good Day!");
    }
}