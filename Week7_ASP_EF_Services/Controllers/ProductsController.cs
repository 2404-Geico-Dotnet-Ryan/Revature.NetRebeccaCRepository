using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.Category.Name
                }).ToList();

            return Ok(products);
        }

        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDto)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);

            if (category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist.");
            }

            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                CategoryId = category.CategoryId,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new { id = product.ProductId }, productDto);
        }

        [HttpPut]
        public IActionResult PutProduct(ProductDTO productDto)
        {
            var product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);
            if (category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist.");
            }

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        public IActionResult PutProductByName(ProductDTO productDto)
        {
            var product = _context.Products.Include(p => p.Category)
                                                .FirstOrDefault(p => p.Name == productDto.Name);

            if (product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDto.CategoryName);
            if (category == null)
            {
                return BadRequest($"Category {productDto.CategoryName} does not exist.");
            }

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return NoContent();
        }
    }
}