class DriverService
{
    DriverRepo dr = new();

    //Register
    public Driver? Register(Driver d)
    {
        if (d.Role != "user")//we are only allowing User roles at this time
        {
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;
        }

        
        List<Driver> allDrivers= dr.GetAllDrivers();
        foreach (Driver driver in allDrivers)
        {
            if (driverName.DriverName == d.DriverName)
            {
                System.Console.WriteLine("DriverName already taken! - Please try again!");
                return null;
            }
        }
        
        return dr.AddDriver(d);
    }

    //Login
    public Driver? Login(string driverName, string password)
    {
        List<Driver> allDrivers = dr.GetAllDrivers();
        foreach (Diver driver in allDrivers)
        {
            if (driver.DriverName == driverName && driver.Password == password)
            {
                return driver; 
            }
        }
        System.Console.WriteLine("Invalid DriverName / Password combo! Please Try Again!");
        return null; 
    }
}