using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.UserId
                }).ToList();

            return profiles;
        }

        [HttpGet("{id}")]
        public ActionResult<ProfileDTO> GetProfile(int id)
        {
            var profile = _context.Profiles
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.UserId
                }).FirstOrDefault(p => p.UserId == id);

            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }

        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDto)
        {
            var profile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = profileDto.UserId
            };

            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfile), new { id = profile.UserId }, profileDto);
        }

        [HttpPut("{id}")]
        public IActionResult PutProfile(int id, ProfileDTO profileDto)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == id);

            if (profile == null)
            {
                return NotFound();
            }

            profile.Bio = profileDto.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProfile(int id)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == id);

            if (profile == null)
            {
                return NotFound();
            }

            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return NoContent();
        }
    }
}