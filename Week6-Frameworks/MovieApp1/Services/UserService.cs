class UserService
{
    UserRepo ur;

    public UserService(UserRepo ur)
    {
        this.ur = ur;
    }

    //Register
    public User? Register(User u)
    {
        //let's not let them register if the role is anything other than "user"
        if (u.Role != "user")
        {
            //reject them
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;
        }

        //let's not let them register if the username is already taken! :o
        //Get all users
        List<User> allUsers = ur.GetAllUsers() ?? [];
        //Check if our new username matches any of the usernames on all those users.
        foreach (User user in allUsers)
        {
            if (user.Username == u.Username)
            {
                System.Console.WriteLine("Username already taken! - Please try again!");
                return null;//reject them
            }
        }
        //IF we make it this far, then we are saying that the role is good to go 
        //and the username is good to go.
        return ur.AddUser(u);
    }

    //Login
    public User? Login(string username, string password)
    {
        //Get all users
        List<User> allUsers = ur.GetAllUsers() ?? [];

        //check each one to see if we find a match.
        foreach (User user in allUsers)
        {
            //If matching username and password, they 'login' -> return that user
            if (user.Username == username && user.Password == password)
            {
                //Yay! Login!
                return user; //us returning the user will indicate success.
            }
        }

        //If we make it this far - we didnt find a match! Oh no!
        System.Console.WriteLine("Invalid Usernamd / Password combo! Please Try Again!");
        return null; //reject the login
    }
}