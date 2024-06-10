using LoginAPI.DTOs;
using LoginAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LoginAPI.Controllers;

// http://localhost:2392/Users

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    /*
        This is now a field that is scoped to the user controller
        We can now use the userService anywhere in this controller
    */
    private readonly IUserService _userService;

    // Constructor to inject the IUserService dependency
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    // GET: /Users
    // Retrieves all users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
    {
        var users = await _userService.GetAllUsers();
        return users;
    }

    // GET: /Users/{id}
    // Retrieves a user by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetUser(int id)
    {
        var user = await _userService.GetUser(id);
        if(user == null){
            return NotFound();
        }
        return user;
    }

    // POST: /Users
    // Creates a new user
    [HttpPost]
    public async Task<ActionResult<UserDTO>> PostUser(UserDTO userDto)
    {
        await _userService.CreateUser(userDto);
        return Created(); // CreatedAtAction can be used for more specific resource location
    }

    // PUT: /Users/{id}
    // Updates an existing user by ID
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, UserDTO userDto)
    {
        var userDTO = await _userService.UpdateUser(id, userDto);
        if (userDTO == null){
            return NotFound();
        }
        return NoContent();
    }

    // DELETE: /Users/{id}
    // Deletes a user by ID
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {        
        int idReturned = await _userService.DeleteUser(id);

        if(idReturned == -1)
        {
            return NotFound();
        }
        return NoContent();

    }

    // GET: /Users/email?Email=email2@email.com
    // Retrieves a user by email using query parameter
    // If the HTTPGet is matching something else, it will lead to an ambiguous endpoint and another path is needed to differentiate the two from each other
    [HttpGet("email")]
    public async Task<ActionResult<UserDTO>> GetUserByEmail([FromQuery] string Email)
    {
        var user = await _userService.GetUserByEmail(Email);
        return user;
    }

    // POST: /Users/login
    // Logs in a user
    [HttpPost("login")]
    public async Task<ActionResult<LoginResponseDTO>> Login(UserLoginDTO userLogin)
    {
        var user = await _userService.LoginUser(userLogin);

        // if the username or password was not valid, we will get back a null user
        // based on that, we can send back a response telling the client that it was invalid
        if (user == null)
        {
            return Ok("Invalid Login, please try again!");
        }

        // When a user logs in, if you have some kind of role property, this is where you would add it
        // Since I do not have it, I'm going to hard code it
        // Response.Headers.Append("Authorization", "Admin"); first attempt, we cannot access custom headers in cors responses
        // Instead, we will add it to the response body
        
        return new LoginResponseDTO{
            Username = user.Value.Username,
            Authorization = "Admin"
        };
    }

    [HttpGet("protected")]
    public async Task<IActionResult> ProtectedEndpoint([FromHeader] string Authorization)
    {
        if(Authorization == "Admin"){
            return Ok("Hi there admin!");
        }else{
            return Unauthorized("You are not an admin!");
        }
    }
}