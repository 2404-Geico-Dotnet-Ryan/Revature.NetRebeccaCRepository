class Driver
{
    public int Id { get; set; }
    public string DriverName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public Driver()
    {
        DriverName = "";
        Password = "";
        Role = "";
    }

    public Driver (int id, string drivername, string password, string role)
    {
        Id = id;
        DriverName = drivername;
        Password = password;
        Role = role;
    }

    public override string ToString()
    {
        return "{id:" + Id
        + ", Driver Name:'" + DriverName
        + "', password:'" + Password
        + "', role:'" + Role + "'}";
    }
}