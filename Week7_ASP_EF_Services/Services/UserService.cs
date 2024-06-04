using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    /*
       The service class implements the IUserService interface.
       This means that all the declared methods in the interface must have some kind of implementation inside the service class.

       We are also using dependency injection to have access to the database context.

       Most of the core methods inside the service will just be moving the operations that were happening inside the controller endpoints into the service methods.

       Additional validations and checks are added to improve the stability of your application, such as:
       - Validating if the new data is in the right format.
       - Handling cases where an ID is provided for a user that doesn't exist.
       - Incorporating null checks in your service layer.
   */
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        // Constructor to inject the database context 
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        // Method to get a list of all users
        public IEnumerable<UserDTO> GetAllUsers()
        {
            var users = _context.Users
               .Select(u => new UserDTO
               {
                   UserId = u.UserId,
                   Name = u.Name,
               }).ToList();
            return users;
        }


        public UserDTO GetUserByID(int UserId)
        {
            var user = _context.Users.Find(UserId);
            if (user != null)
            {
                var userDto = new UserDTO
                {
                    Name = user.Name,
                    UserId = user.UserId
                };
            return userDto;
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        // Method to create a new user based on the provided UserDTO
        public User CreateUser(UserDTO UserDto)
        {
            if (ValidateNewUser(UserDto))
            {
                var user = new User
                {
                    Name = UserDto.Name
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
            }
            else
            {
                throw new Exception("Invalid User");
            }
        }

        private bool ValidateNewUser(UserDTO userDto)
        {
            if (userDto.Name.Trim().Length == 0)
            {
                return false;
            }
            else return true;
        }

        // Method to update an existing user based on their ID and the provided updated UserDTO
        public void UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            if (user != null)
            {
                user.Name = UpdatedUser.Name;

                _context.Users.Update(user);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        // Method to delete a user based on their ID
        public void DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            if (user != null)
            {
            _context.Users.Remove(user);
            _context.SaveChanges();
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}
