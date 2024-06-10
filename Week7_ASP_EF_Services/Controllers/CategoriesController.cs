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
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categories = _context.Categories
                .Include(c => c.Products)
                .Select(c => new CategoryDTO
                {
                    Name = c.Name,
                }).ToList();

            return categories;
        }

        [HttpPost]
        public ActionResult<CategoryDTO> PostCategory(CategoryDTO categoryDto)
        {
            var category = new Category
            {
                Name = categoryDto.Name,
                Products = new List<Product>()
            };

            _context.Categories.Add(category);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCategories), new { id = category.CategoryId }, categoryDto);
        }

        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, CategoryDTO categoryDto)
        {
            var category = _context.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = categoryDto.Name;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        public IActionResult PutCategoryByName(CategoryDTO categoryDto)
        {
            var category = _context.Categories.Include(c => c.Products)
                                              .FirstOrDefault(c => c.Name == categoryDto.Name);

            if (category == null)
            {
                return NotFound();
            }

            category.Name = categoryDto.Name;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return NoContent();
        }
    }
}