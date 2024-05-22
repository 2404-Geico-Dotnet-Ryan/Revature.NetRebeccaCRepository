
using Microsoft.Identity.Client;

class UserRepo : IUserRepo
{
    private readonly MovieEFAppDBContext _context;  

    public UserRepo(MovieEFAppDBContext context)
    {
        _context = context;
    } 
    public void AddUser(User u)
    {
        _context.Users.Add(u);
    }
    public void DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        if (user != null)
        {
        _context.Users.Remove(user);
        }
    }
    public List<User> GetAllUser()
    {
        return _context.Users.ToList();
    }
    public User? GetUser(int id)
    {
        return _context.Users.Find(id);
    }
    public void Save()
    {
      _context.SaveChanges();
    }
    public void UpdateUser(User u)
    {
        _context.Users.Update(u);
    }
}