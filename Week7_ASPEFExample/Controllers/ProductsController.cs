using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        // This appdbcontext is used to interact with our database
        // The constructor is used by our dependency manager to inject it into our class
        // We do not have to instantiate the controller or provide the app db context into the constructor
        // this is managed for us by the Dependency Injection Container
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            /*
                Entity Framework does lazy loading, where if an entity contains another entity as a foreign key relationship
                EF will not load it (null value) unless you explicitly tell it to include it
                This is done to reduce unecessary calls to the database from the api
            */
            IEnumerable<ProductDTO> products = _context.Products
                                                .Include(p => p.Category)
                                                .Select(p => new ProductDTO
                                                    {
                                                        ProductId = p.ProductId,
                                                        Name = p.Name,
                                                        Price = p.Price,
                                                        CategoryName = p.Category.Name
                                                    }
                                                ).ToList();
            
            return Ok(products);
        }

        // POST: /Products
        // we expect them to provide a JSON body that matches our ProductDTO
        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductDTO productDTO)
        {
            // Because the Product entity contains the entity of Category, we need to include all the entities in our to be created entity
            // First we need to grab the category entity from our database, and since the ProductDTO only has the category name, that is the only way we can filter through the categories entity
            var category = _context.Categories.FirstOrDefault(c => c.Name == productDTO.CategoryName);

            // We now need to check to see if the category name that they provided actually does exist
            // If this category is null, then it means the category that they provided does not exist in our database and we can let them know it is a bad request
            if(category == null)
            {
                // "Category " + productDTO.CategoryName + " does not exist."
                // using a $ in front of the double quotes allows us to use string interpolation
                // letting us insert values that are automatically converted into the string, and maintain the format of the string by default
                return BadRequest($"Category {productDTO.CategoryName} does not exist.");
            }

            // If the category does exist, then we can use both the category entity and the product DTO to create the product entity
            var product = new Product
            {
                Name = productDTO.Name,
                Price = productDTO.Price,
                CategoryId = category.CategoryId,
                Category = category
            };

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProducts), new {id = product.ProductId}, productDTO);

        }


        // PUT: /Products/23
        [HttpPut("{id:int}")]
        public IActionResult PutProduct(int id, ProductDTO productDTO)
        {
            var product = _context.Products
                            .Include(p => p.Category)
                            .FirstOrDefault(p => p.ProductId == id );
            
            if(product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDTO.CategoryName);

            if(category == null)
            {
                return BadRequest($"Category {productDTO.CategoryName} does not exist.");
            }

            product.Name = productDTO.Name;
            product.Price = productDTO.Price;
            product.CategoryId = category.CategoryId;
            product.Category = category;

            _context.Products.Update(product);
            _context.SaveChanges();

            return NoContent();
            
        }

        [HttpPut("{name}")]
        public IActionResult PutProductByName(string name, ProductDTO productDTO)
        {
            var product = _context.Products
                            .Include(p => p.Category)
                            .FirstOrDefault(p => p.Name == name );
            
            if(product == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Name == productDTO.CategoryName);

            if(category == null)
            {
                return BadRequest($"Category {productDTO.CategoryName} does not exist.");
            }

            product.Name = productDTO.Name;
            product.Price = productDTO.Price;
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