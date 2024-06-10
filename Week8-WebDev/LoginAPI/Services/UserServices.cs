using Azure.Identity;
using LoginAPI.Controllers;
using LoginAPI.Data;
using LoginAPI.DTOs;
using LoginAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Services;

// Implementation of IUserService
public class UserService : IUserService
{
    private readonly AppDbContext _context;

    // Constructor to inject the AppDbContext dependency
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    // Method to create a new user
    public async Task<UserDTO> CreateUser(UserDTO userDto)
    {
        // Convert the UserDTO to a User entity
        var user = ConvertUserDTOToUser(userDto);
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        // Return the original UserDTO
        return userDto;
    }

    // Method to retrieve all users
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
    {
        // Query the database for all users and convert them to UserDTOs
        var users = await _context.Users
                            .Select(u => new UserDTO
                            {
                                Username = u.Username,
                                Password = u.Password,
                                Email = u.Email
                            }).ToListAsync();
        
        return users;
    }

    // Method to retrieve a user by ID
    public async Task<ActionResult<UserDTO>> GetUser(int id)
    {
        // Find the user by ID
        var userEntity = await GetUserById(id);

        if (userEntity == null)
        {
            return null;
        }

        // Convert the User entity to a UserDTO
        var user = ConvertUserToUserDTO(userEntity);

        return user;
    }

    // Method to convert a User entity to a UserDTO
    private UserDTO ConvertUserToUserDTO(User user)
    {
        return new UserDTO
        {
            Username = user.Username,
            Password = user.Password,
            Email = user.Email
        };
    }

    // Method to convert a UserDTO to a User entity
    private User ConvertUserDTOToUser(UserDTO userDto)
    {
        return new User
        {
            Username = userDto.Username,
            Password = userDto.Password,
            Email = userDto.Email
        };
    }

    // Method to update an existing user
    public async Task<UserDTO> UpdateUser(int id, UserDTO userDto)
    {
        // Find the user by ID
        var user = await GetUserById(id);

        if (user == null)
        {
            return null;
        }

        // Update the user's properties
        user.Username = userDto.Username;
        user.Password = userDto.Password;
        user.Email = userDto.Email;

        _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return userDto;
    }

    // Method to delete a user by ID
    public async Task<int> DeleteUser(int id)
    {
        // Find the user by ID
        var user = await GetUserById(id);
        if (user == null)
        {
            return -1; // Indicate failure to find the user
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return id; // Return the ID of the deleted user
    }

    // Helper method to find a user by ID
    private async Task<User> GetUserById(int id)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);

        if (user == null)
        {
            return null;
        }

        return user;
    }

    // Method to log in a user
    public async Task<ActionResult<UserDTO>> LoginUser(UserLoginDTO userLogin)
    {
        // Find the user by username and password
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == userLogin.Username && u.Password == userLogin.Password);

        if (user == null)
        {
            return null; // Indicate failure to find the user
        }

        // Convert the User entity to a UserDTO
        var userDto = ConvertUserToUserDTO(user);

        return userDto;
    }

    // Method to retrieve a user by email
    public async Task<ActionResult<UserDTO>> GetUserByEmail(string email)
    {
        // Find the user by email
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        if (user == null)
        {
            return null; // Indicate failure to find the user
        }

        // Convert the User entity to a UserDTO
        var userDto = ConvertUserToUserDTO(user);

        return userDto;
    }
}