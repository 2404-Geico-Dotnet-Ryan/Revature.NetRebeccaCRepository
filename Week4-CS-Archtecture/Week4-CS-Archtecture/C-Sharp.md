# Intro to .NET and C#

### .NET
- .NET Platform provides comprehensive tooling/environment to develop different types of applications
  - This means we don't have to go look for own package manager, etc. It comes all bundled in the SDK (Software Development Kit)
- .NET releases yearly, with even numbers bring LTS (Long Term Support)
  - .NET 8 is the latest release
- The MS Documentation is actually really good!

### .NET Naming Issues
- .NET Framework is the first, windows-only implementation of .NET that is now super duper legacy.
- .NET Core - is their new cross platform implementation, starting with .NET Core 1
- Moving forward they dropped the wore "Core" (and also skipped version 4 for some reason) and now all releases of .NET are simply .NET
  - .NET Core 1 -> ... -> .NET Core 3 -> .NET 5 -> .NET 6
- EXCEPT for Frameworks...
  - Frameworks that exist both in .NET framework and .NET (such as ASP.NET or EF - Entity Framework) is still differentiated by the word Core.
    - ASP.NET -> a web framework for .NET framework
    - ASP.NET Core -> a web framework for .NET (Core)


### Dependency Management
- When programming in a language (like C#) that will come with a standard set of code that we can regularly use.
- Every programming language have a Depenency (package) Manager for managing new "code/libraries/frameworks" that we like to introduce on top of our readily available Standard Library.
- Nuget is dependency manager for .NET. It comes preinstalled with all .NET SDKs and by defalt looks for packages at nuget.org
- `dotnet add package <package-name>` - adds packaged dependency to your .csproj file

### .NET SDK commands
- `dotnet --version` : confirms what version of dotnet you ar eusing - helpful for "proving" you have the .NET SDK installed.
- `dotnet new ...` - scaffold a new project.
  - `dotnet new console` - creates a new console app project
  - `dotnet new console -n HelloWorld` - make a new console app with the name HelloWorld
  - `dotnet new gitignore` create new .NET specific gitignore file
- `dotnet run` - clean, restore, build, and run the project

### C#
- There are several various programming languages that can utilize the .NET Framework.
- The primary language of choice for .NET
- Latest is C# 12 (with .NET 8)
- Strong, static typing, mostly OOP, some functional language capabilities

### C# Compiler

- The Problem: Humans read in characters - Machines read in binary (0s and 1s) - and these should not mix.
- The Solution: FIRST we as humans write the code in a human-readable format. SECOND we *compile* our code into something more interpretable by a machine (aka binary). THEN our machine executes the Binary File.
- `Something.cs` -> a file written using human readable characters, more specifically is code written in C#
- When you execute `dotnet run` part of that process is to first *compile* our code into a format suitable for a computer. In our case the default is `Something.exe`.
- C# is considered a Compiled Language 
  - C# will compile ALL of its code BEFORE execution and THEN run the entire application.
  - vs Interpreted - Each line of code is compiled and then immediately executed. One line at a time.