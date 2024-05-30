using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;

namespace ProductApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    // In memory data that you will be referencing in your methods
    private static List<Product> Products = new List<Product>
    {
        /*
        int ProductId, 
        string ProductName, 
        string ProductDescription, 
        decimal ProductPrice, 
        bool ProductInStock
        */
        new Product(1, "Roku Remote", "No volume control", 5, true),
        new Product(2, "Fountain pen", "To write down important things", 10, true),
        new Product(3, "Blanket", "Keeps you warm", 15, true),
        new Product(4, "Slim Jims", "Snack from gas station", 20, true),
        new Product(5, "Purse", "plain white", 25, true),
        new Product(6, "Maytag Microwave", "Basic", 50, false),
        new Product(7, "Graco Car Seat", "Grow with me 3 in 1", 75, false),
        new Product(8, "Polaris", "In Ground Pool Cleaner", 90, true),
        new Product(9, "Shark Vacuum", "Pet hair plus", 250, true)
    };

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(Products);
    }


    [HttpGet("{Id}")]
    public IActionResult GetProductById(int Id)
    {
        var product = Products.FirstOrDefault(p => p.ProductId == Id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    
    [HttpPost]
    public IActionResult PostProduct([FromBody] Product product)
    {
        product.ProductId = Products.Count + 1;
        Products.Add(product);
        return Ok();
    }

    [HttpPut("{Id}")]
    public IActionResult PutProduct(int Id, [FromBody] Product updatedProduct)
    {
        var product = Products.FirstOrDefault(p => p.ProductId == Id);
        if (product == null)
        {
            return NotFound();
        }
        int index = Products.FindIndex(p => p.ProductId == Id);
        Products[index] = updatedProduct;
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int Id)
    
    {
        foreach(Product product in Products)
        {
            if(product.ProductId == Id)
            {
                Products.Remove(product);
                return Ok();
            }
        }
        return NotFound();
        
    }
    
}