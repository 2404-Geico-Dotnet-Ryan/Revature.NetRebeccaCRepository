# Exercise 1: Simple ASP.NET Core API

## Objective

Create a basic ASP.NET Core API application with a single controller that returns a "Hello, World!" message.

## Steps

1. Create a new ASP.NET Core Web API Project.--done
    - `dotnet new webapi -controllers -f net8.0`--done
    - Remove the Weather related things --done
2. Add a new controller named `HelloController`.  -- done
3. Implement a GET endpoint that returns a "Hello, World" message.

## Starter Code

`Program.cs`  --done

```csharp
var builder = WebApplication.CreateBuilder(args); -- done

// Add this
builder.Services.AddControllers(); -- done

builder.Services.AddEndpointsApiExplorer(); -- done
builder.Services.AddSwaggerGen(); --done

var app = builder.Build(); -- done

if (app.Environment.IsDevelopment())-- done
{
    app.UseSwagger(); -- done
    app.UseSwaggerUI(); --done
}

app.UseHttpsRedirection();-- done

// Add this
app.MapControllers(); --done

app.Run(); -done

```

> You will need to create a folder for the controllers called "Controllers"

`HelloController.cs` --done

```csharp
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // TODO:
        // return a message "Hello, World!"
    }
}
```

// this exercise is completed
## Resources

- Reference for different Action Results
    - https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.httpresults?view=aspnetcore-8.0