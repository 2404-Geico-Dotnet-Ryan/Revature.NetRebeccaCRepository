using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EFCoreExample.Services;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
         private readonly ICategoryService _categoryService;
         public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpPost]
        public ActionResult<CategoryDTO> PostCategory(CategoryDTO categoryDto)
        {
            var category = _categoryService.CreateCategory(categoryDto);

            return CreatedAtAction(nameof(GetCategories), new { CategoryId = category.CategoryId }, categoryDto);
        }
    }
}