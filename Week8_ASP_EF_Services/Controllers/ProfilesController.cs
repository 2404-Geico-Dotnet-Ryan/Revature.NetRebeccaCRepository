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
    public class ProfilesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProfileDTO>> GetProfiles()
        {
            var profiles = _context.Profiles
                .Include(p => p.User)
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.User.UserId
                }).ToList();

            return profiles;
        }

        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDto)
        {

            var user = _context.Users.Find(profileDto.UserId);
            var NewProfile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = profileDto.UserId,
                User = user
            };

            _context.Profiles.Add(NewProfile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfiles), new { ProfileId = NewProfile.ProfileId }, profileDto);
        }
    }
}