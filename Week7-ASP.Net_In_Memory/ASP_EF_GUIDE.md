You need models and DTOs

```csharp
dotnet new webapi --use-controllers
```

```csharp
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

This is all you really need to get started

Get rid of the controllers pre-generated

## Data Models

Make a folder `Models`

`One To One`

```csharp
namespace EFCoreExample.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

```

`One to Many`

```csharp
namespace EFCoreExample.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

```

## DB Context

Make a folder `Data`

```csharp
using Microsoft.EntityFrameworkCore;
using EFCoreExample.Models;

namespace EFCoreExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-one relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

            // One-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}

```

Create the Connection String

```csharp
  "ConnectionStrings": {
        "DefaultConnection": "Server=REV-PF3BP04L;Database=TestDb2;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
    },
```

## Program.cs

```csharp
using EFCoreExample.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

```

## EF Migrations

```csharp
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Setup DTOs (Data Transfer Object)

```csharp
namespace EFCoreExample.DTOs
{
    public class UserDTO
    {
        public int UserId {get;set;}
        public string Name { get; set; }

    }

    public class ProfileDTO
    {
        public string Bio { get; set; }
        public int UserId {get;set;}
    }

    public class CategoryDTO
    {
        public string Name { get; set; }
    }

    public class ProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}
```

## Controllers

`UsersController`

```csharp
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _context.Users
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                }).ToList();

            return users;
        }

        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDto = new UserDTO{
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = new User
            {
                Name = userDto.Name,
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, userDto);
        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(UpdatedUser);
        }

        [HttpDelete("{UserId}")]
        public IActionResult DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}

```

`ProfilesController`

```csharp
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProfileDTO>> GetProfiles()
        {
            var profiles = _context.Profiles
                .Include(p => p.User)
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.User.UserId
                }).ToList();

            return profiles;
        }

        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDto)
        {

            var user = _context.Users.Find(profileDto.UserId);
            var NewProfile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = profileDto.UserId,
                User = user
            };

            _context.Profiles.Add(NewProfile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfiles), new { id = NewProfile.ProfileId }, profileDto);
        }
    }
}

```

`ProductsController`

```csharp
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
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

            return products;
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> PostProduct(ProductDTO productDto)
        {
            var category = await _context.Categories.FirstAsync(c => c.Name == productDto.CategoryName);

            
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
    }
}

```

`CategoriesController`

```csharp
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
                Products = []
            };

            _context.Categories.Add(category);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCategories), new { id = category.CategoryId }, categoryDto);
        }
    }
}
```