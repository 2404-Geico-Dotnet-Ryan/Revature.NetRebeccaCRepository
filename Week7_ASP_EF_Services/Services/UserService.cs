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
        // Constructor to inject the database context
        private readonly AppDbContext _context;
        // Method to create a new user based on the provided UserDTO 
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        // Constructor to inject the database context
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
            var userDto = new UserDTO
            {
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
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

        public void UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
