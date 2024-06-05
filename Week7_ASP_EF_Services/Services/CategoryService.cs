using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services

{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
    }    

    public IEnumerable<CategoryDTO> GetAllCategories()
        {
            var categories = _context.Categories
                .Include(c => c.Products)
                .Select(c => new CategoryDTO
                {
                    Name = c.Name,
                }).ToList();
                return categories;
        }

    public Category CreateCategory(CategoryDTO CategoryDto)
        {
            if (ValidateNewCategory(CategoryDto))
            {
                var category = new Category
                {
                    Name = CategoryDto.Name
                };

                _context.Category.Add(category);
                _context.SaveChanges();

                return category;
            }
            else
            {
                throw new Exception("Invalid Category");
            }
        }

        private bool ValidateNewCategory(CategoryDTO CategoryDto)
        {
            return !string.IsNullOrWhiteSpace(CategoryDto.Name);
        }
}