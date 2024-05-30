using Microsoft.AspNetCore.Mvc;
using Week7_ASP.Net.Models;


namespace Week7_ASP.NET;

    // Attribute indicating that this class is an API controller
    [ApiController]
    // Attribute specifying the base route for this controller, which means this controller
    // will respond to requests that match the pattern "baseURL/Greetings"
    [Route("[controller]")]

    public class GreetingsController : ControllerBase
    {
        // Attribute specifying the HTTP method (GET) for this action method
        [HttpGet]
        // Action method to handle GET requests to the base route
        public IActionResult Get()
            {
                // Returns an HTTP 200 OK response with the message "Greetings!"
                return Ok("Greetings");
            }

        // Attribute specifying the HTTP method (GET) and a route parameter for this action method
        [HttpGet]
        [Route("{Id}")]
        // Action method to handle GET requests to the base route with an ID parameter
        public IActionResult GetSpecificId(int Id)
            {
                // Outputs the ID to the console
                System.Console.WriteLine(Id);
                // Returns an HTTP 200 OK response with the ID
                return Ok(Id);
            }

        // Attribute specifying the HTTP method (POST) for this action method
        [HttpPost]
        // Action method to handle POST requests to the base route
        public IActionResult Post(Message message)
            {
                // Outputs the 'note' property of the 'message' object to the console
                System.Console.WriteLine(message.note);
                // Returns an HTTP 200 OK response
                return Created();
            }
    }


