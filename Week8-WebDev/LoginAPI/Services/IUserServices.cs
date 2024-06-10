using LoginAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Services;

public interface IUserService
{
    Task<UserDTO> CreateUser(UserDTO userDto);
    Task<int> DeleteUser(int id);
    Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers();
    Task<ActionResult<UserDTO>> GetUser(int id);
    Task<ActionResult<UserDTO>> GetUserByEmail(string email);
    Task<ActionResult<UserDTO>> LoginUser(UserLoginDTO userLogin);
    Task<UserDTO> UpdateUser(int id, UserDTO userDto);
}