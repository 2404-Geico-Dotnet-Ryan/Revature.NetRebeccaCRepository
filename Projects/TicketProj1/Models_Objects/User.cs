class User
{
    public int UserId { get; set; } //system will assign
    public string UserName { get; set; } //has to be unique user will create
    public string Password { get; set; } //user will create
    public string DriverName { get; set; } //user will provide
    public string Role { get; set; }  //unsure right now if will have user and admin or just user

    public Driver()
    {
        UserName= ""; 
        DriverName = "";
        Password = "";
        Role = "";
    }

    public Driver (int UserIdd, string UserName, string Password, string DriverName, string role)
    {
        UserId = userId;
        UserName = userName;
        Password = password;
        DriverName = drivername;
        Password = password;
        Role = role;
    }

    public override string ToString()
    {
        return "{UserId:" + UserId
        + ", User Name; " + UserName
        + "', password:'" + Password
        + ", Driver Name:'" + DriverName
        + "', role:'" + Role + "'}";
    }
}