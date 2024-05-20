class DriverRepo
{

    DriverStorage driverStorage = new();

    //add, get-one, get-all, update, and delete
    public Driver AddDriver(Driver d)
    {
        d.Id = driverStorage.idCounter++;
        driverStorage.drivers.Add(d.Id, d);
        return d;
    }

    public Driver? GetDriver(int id)
    {
        if (driverStorage.drivers.ContainsKey(id))
        {
            Driver selectedDriver = driverStorage.drivers[id];
            return selectedDriver;
        }
        else
        {
            System.Console.WriteLine("Invalid Driver ID - Please Try Again");
            return null;
        }
    }

    public List<Driver> GetAllDrivers()
    {
        return driverStorage.drivers.Values.ToList();
    }

    public Driver UpdateDriver(Driver updatedDriver)
    {
        try
        {
            driverStorage.drivers[updatedDriver.Id] = updatedDriver;
            return updatedDriver;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Driver ID - Please Try Again");
            return null;
        }
    }

    public Driver DeleteDriver(Driver d)
    {
        bool didRemove = driverStorage.drivers.Remove(d.Id);

        if (didRemove)
        {
            return d;
        }
        else
        {
            System.Console.WriteLine("Invalid Driver ID - Please Try Again");
            return null;
        }
    }
}