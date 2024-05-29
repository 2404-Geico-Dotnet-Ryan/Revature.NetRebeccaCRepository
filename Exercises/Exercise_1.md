# Exercise 1: Simple ASP.NET Core API

## Objective

Create a basic ASP.NET Core API application with a single controller that returns a "Hello, World!" message.

## Steps

1. Create a new ASP.NET Core Web API Project.
    - `dotnet new webapi`
    - Remove the Weather related things
2. Add a new controller named `HelloController`.
3. Implement a GET endpoint that returns a "Hello, World" message.

## Starter Code

`Program.cs`

```csharp
var builder = WebApplication.CreateBuilder(args);

// Add this
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add this
app.MapControllers();

app.Run();

```

> You will need to create a folder for the controllers called "Controllers"

`HelloController.cs`

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


## Resources

- Reference for different Action Results
    - https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.httpresults?view=aspnetcore-8.0