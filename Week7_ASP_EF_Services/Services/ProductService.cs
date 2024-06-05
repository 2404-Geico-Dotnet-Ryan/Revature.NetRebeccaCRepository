using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

    }
    public ProductDTO GetProductById(int ProductId)
    {
        var products = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == ProductId);
        var productDto = new ProductDTO
        {
            Name = products.Name,
            Price = products.Price, 
            CategoryName = products.Category.Name
        };
        return productDto;
    }
}
