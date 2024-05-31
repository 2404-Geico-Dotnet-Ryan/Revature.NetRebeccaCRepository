using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _context.Users
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                }).ToList();

            return users;
        }

        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDto = new UserDTO{
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            //return Ok(userDto);
            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDto);
        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;// can be more fields here if you want fields updated
            

            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(UpdatedUser);
        }

        [HttpDelete("{UserId}")]
        public IActionResult DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}