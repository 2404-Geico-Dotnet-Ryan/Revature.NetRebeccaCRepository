using System.ComponentModel;

class UserRepo
{
    UserStorage userStorage = new();

    //add, get-one, get-all, update, and delete
    public User AddUser(User u)
    {
        u.Id = userStorage.idCounter++;
        userStorage.users.Add(u.Id, u);
        return u;
    }

    public User? GetUser(int id)
    {
        if (userStorage.users.ContainsKey(id))
        {
            User selectedUser = userStorage.users[id];
            return selectedUser;
        }
        else
        {
            System.Console.WriteLine("Invalid User ID - Please Try Again");
            return null;
        }
    }

    public List<User> GetAllUsers()
    {
        return userStorage.users.Values.ToList();
    }

    public User? UpdateUser(User updatedUser)
    {
        try
        {
            userStorage.users[updatedUser.Id] = updatedUser;
            return updatedUser;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid User ID - Please Try Again");
            return null;
        }
    }

    public User? DeleteUser(User u)
    {
        bool didRemove = userStorage.users.Remove(u.Id);

        if (didRemove)
        {
            return u;
        }
        else
        {
            System.Console.WriteLine("Invalid User ID - Please Try Again");
            return null;
        }
    }
}