class DriverStorage
{

    public Dictionary<int, Driver> drivers;
    public int idCounter = 1;

    public DriverStorage()
    {
        Driver driver1 = new(idCounter, "Rebecca", "pass1", "Admin"); idCounter++;
        Driver driver2 = new(idCounter, "Scott", "pass2", "user"); idCounter++;
        Driver driver3 = new(idCounter, "Derrick", "pass3", "user"); idCounter++;

        drivers = [];
        drivers.Add(driver1.DriverId, driver1);
        drivers.Add(driver2.DriverId, driver2);
        drivers.Add(driver3.DriverId, driver3);
    }
    

}