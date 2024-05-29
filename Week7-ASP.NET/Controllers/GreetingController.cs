using Microsoft.AspNetCore.Mvc;
using Week7_ASP.Net.Models;


namespace Week7_ASP.NET;

[ApiController]
[Route("[controller]")]

public class GreetingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Greetings");
    }

    [HttpGet]
    [Route("{Id}")]
    public IActionResult GetSpecificId(int Id)
    {
        System.Console.WriteLine(Id);
        return Ok(Id);
    }

    [HttpPost]
    public IActionResult Post(Message message)
    {
        System.Console.WriteLine(message.note);
        return Created();
    }
}

