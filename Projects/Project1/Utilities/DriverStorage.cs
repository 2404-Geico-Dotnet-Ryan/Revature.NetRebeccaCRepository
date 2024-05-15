class DriverStorage
{

    public Dictionary<int, Driver> Drivers;
    public int idCounter = 1;

    public DriverStorage()
    {
        Driver driver1 = new(idCounter, "Rebecca", "pass1", "user"); idCounter++;
        Driver driver2 = new(idCounter, "Scott", "pass2", "user"); idCounter++;
        Driver driver3 = new(idCounter, "admin", "pass3", "admin"); idCounter++;

        drivers = [];
        drivers.Add(driver1.Id, driver1);
        drivers.Add(driver2.Id, driver2);
        drivers.Add(driver3.Id, driver3);
    }
    

}