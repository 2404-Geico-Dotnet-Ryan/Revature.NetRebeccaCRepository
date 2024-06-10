using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        // This appdbcontext is used to interact with our database
        // The constructor is used by our dependency manager to inject it into our class
        // We do not have to instantiate the controller or provide the app db context into the constructor
        // this is managed for us by the Dependency Injection Container
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public ActionResult<CategoryDTO> PostCategory(CategoryDTO categoryDTO)
        {
            var category = new Category
            {
                Name = categoryDTO.Name,
                Products = new List<Product>()
            };

            _context.Categories.Add(category);
            _context.SaveChanges();

            return Created();
        }
    }
}