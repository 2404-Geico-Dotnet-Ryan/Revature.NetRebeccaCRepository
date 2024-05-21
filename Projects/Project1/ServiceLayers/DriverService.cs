class DriverService
{
    DriverRepo dr;
    public DriverService(DriverRepo dr)
    {
        this.dr=dr;
    }

    //Register
    public Driver? Register(Driver d)
    {
        if (d.Role != "user")
        {
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;
        }
        List<Driver> allDrivers= dr.GetAllDrivers();
        foreach (Driver driver in allDrivers)
        {
            if (driver.DriverName == d.DriverName)
            {
                System.Console.WriteLine("Driver Name already taken! - Please try again!");
                return null;
            }
        }
        return dr.AddDriver(d);
    }

    //Login
    public Driver? Login(string driverName, string password)
    {
        List<Driver> allDrivers = dr.GetAllDrivers();
        foreach (Driver driver in allDrivers)
        {
            if (driver.DriverName == driverName && driver.Password == password)
            {
                return driver; 
            }
        }
        System.Console.WriteLine("Invalid Driver Name / Password combo! Please Try Again!");
        return null;
    }
}