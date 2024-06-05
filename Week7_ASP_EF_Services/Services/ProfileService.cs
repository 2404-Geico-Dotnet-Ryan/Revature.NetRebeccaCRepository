using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    public class ProfileService : IProfileService
    {
        private readonly AppDbContext _context;
        
        public ProfileService(AppDbContext context)
        {
            _context = context;
        }

    }
}