class UserRepo
{

    UserStorage userStorage = new();

    //add, get-one, get-all, update, and delete
    public User? AddUser(User u)
    {
        u.Id = userStorage.idCounter++;
        userStorage.users.Add(u.userId, u);
        return u;
    }

    public User? GetUser(int userId)
    {
        if (userStorage.users.ContainsKey(userId))
        {
            User selectedUser = userStorage.users[userId];
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

    public User UpdateUser(User updatedUser)
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

    public User DeleteUser(user u)
    {
        bool didRemove = userStorage.users.Remove(u.userId);

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