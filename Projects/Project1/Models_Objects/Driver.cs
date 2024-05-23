class Driver
{
    public int DriverId { get; set; }
    public string DriverName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public Driver()
    {
        DriverName = "";
        Password = "";
        Role = "";
    }

    public Driver (int driverid, string drivername, string password, string role)
    {
        DriverId = DriverId;
        DriverName = drivername;
        Password = password;
        Role = role;
    }

    public override string ToString()
    {
        return "{Driver Id:" + DriverId
        + ", Driver Name:'" + DriverName
        + "', password:'" + Password
        + "', role:'" + Role + "'}";
    }
}