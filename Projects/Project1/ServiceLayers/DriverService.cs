class DriverService
{
    DriverRepo driverr = new();

    //Register
    public Driver? Register(Driver d)
    {
        if (d.Role != "user")
        {
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;
        }

        
        List<Driver> allDrivers= ur.GetAllDrivers();
        foreach (Driver driver in allDrivers)
        {
            if (driver.Username == u.Username)
            {
                System.Console.WriteLine("Username already taken! - Please try again!");
                return null;
            }
        }
        
        returndur.AddDriver(d);
    }

    //Login
    public Driver? Login(string username, string password)
    {
        List<Driver> allDrivers = dr.GetAllDrivers();
        foreach (Diver driver in allDrivers)
        {
            if (driver.Username == username && driver.Password == password)
            {
                return user; 
            }
        }
        System.Console.WriteLine("Invalid DriverName / Password combo! Please Try Again!");
        return null; 
    }
}