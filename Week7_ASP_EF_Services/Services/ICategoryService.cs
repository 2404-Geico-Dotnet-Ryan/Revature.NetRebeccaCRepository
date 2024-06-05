using EFCoreExample.DTOs;
using EFCoreExample.Models; 

namespace EFCoreExample.services
{
    public interface ICategoryService
    {
        //Method to get a list of all categories 
        IEnumerable<CategoryDTO>GetAllCategories();
        //Method to create a new category based on the provided DTO 
        Category CreateCategory(CategoryDTO categoryDto);
        
    }
    
}