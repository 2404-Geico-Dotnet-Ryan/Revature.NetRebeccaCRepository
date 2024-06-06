# Exercise 2: Adding CRUD --where is this supposed to be completed in which project??? asked Brian in chat 6/5/2024 at 7:06 pm


## Objective

Create CRUD Methods for the `Products` API you created

## Steps

1. Implement a method for creating a `Product` and adding it to the in-memory list
    - Use the `[HttpPost]` annotation for creating data
    - The data should be passed in as a JSON object in the body of the HTTP POST request
    - The fields of the JSON object should match the fields of the `Product` class
2. Implement a method for updating an already existing `Product` from the in-memory list
    - Use the `[HttpPut]` annotation for updating the whole `Product`
    - It should be referencing an already existing `Product` through their id in the URL
        - Reference your `[HttpGet("{id}")]` for clues to how to identify a specific `Product`
3. Implement a method for deleting a `Product` from the in-memory list
    - Use the `[HttpDelete]` annotation for deleting a `Product`
    - It should be referencing an already existing `Product` through their id in the URL
        - Reference your `[HttpGet("{id}")]` for clues to how to identify a specific `Product`


## Starter Code

**`Controllers/ProductsController.cs`**

```csharp
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    // In memory data that you will be referencing in your methods
    private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, /* Include the fields you created */ },
        new Product { Id = 2, /* Include the fields you created */ },
        new Product { Id = 3, /* Include the fields you created */ }
    };

    [HttpGet]
    public IActionResult Get()
    {
        // return all products
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            // return not found
        }
        // return product found
    }

    [HttpPost]
    public IActionResult Post([FromBody] Product product)
    {
        // create and add to the in-memory list
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product updatedProduct)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            // return not found
        }
        // update the found product
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            // return not found
        }
        // remove the product from the in-memory list
    }
}
```

## Resources

- ASP.NET Core Web API Documentation: [Microsoft Documentation](https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-8.0)