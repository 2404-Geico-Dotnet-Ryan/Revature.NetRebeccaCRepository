// Importing necessary namespaces
using Microsoft.AspNetCore.Mvc;

namespace Week7_ASP.NET.Controllers;

    // Attribute indicating that this class is an API controller
    [ApiController]
    // Attribute specifying the base route for this controller, which means this controller
    // will respond to requests that match the pattern "baseURL/HelloWorld"
    // baseURL would be something like http://localhost:3423
    [Route("[controller]")]
    public class HelloController : ControllerBase  
    {
        // Attribute specifying the HTTP method (GET) and route for this action method
        [HttpGet]
        // Action method to handle GET requests to the base route
        public IActionResult Get()
            {
                // Returns an HTTP 200 OK response with the message "Hello"
                return Ok("Hello");
            }
    }


