using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    /*
        We use an interface because the Dependency Injection (DI) container prefers having the most generic version of the dependency to work with.
        The DI container will look for any instances of this interface and use the provided implementation to inject it where it is needed.

        An interface is a contract for a class. It lays out the required methods that any class must implement if it chooses to use the interface.
    */
    public interface IProductService
    {
        // Method to get a list of all users
        //IEnumerable<UserDTO> GetAllProducts();

        // Method to get a specific user by their ID
        //UserDTO GetProductById(int UserId);

        // Method to create a new user based on the provided UserDTO
        //User CreateUser(UserDTO UserDto);

        // Method to update an existing user based on their ID and the provided updated UserDTO
        //void UpdateUser(int UserId, UserDTO UpdatedUser);

        // Method to delete a user based on their ID
        //void DeleteUser(int UserId);
    }
}