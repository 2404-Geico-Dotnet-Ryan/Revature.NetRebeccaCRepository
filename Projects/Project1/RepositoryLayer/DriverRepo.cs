using Microsoft.Data.SqlClient;

class DriverRepo
{

    private readonly string _connectionString;
    public DriverRepo(string connString)
    {
        _connectionString = connString;
    }

    public Driver? AddDriver(Driver d)
    {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "INSERT INTO DRIVER OUTPUT inserted.* VALUES (@Drivername, @Password, @Role)";

        
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Drivername", d.DriverName);
        cmd.Parameters.AddWithValue("@Password", d.Password);
        cmd.Parameters.AddWithValue("@Role", d.Role);

        using SqlDataReader reader = cmd.ExecuteReader();

        //Extract te Results
        if (reader.Read())
        {
            Driver newDriver = new();
            newDriver.Id = (int)reader["Id"];
            newDriver.DriverName = (string)reader["Username"];
            newDriver.Password = (string)reader["Password"];
            newDriver.Role = (string)reader["Role"];

            return newDriver;
        }
        else
        {
            return null;
        }
    }
    
    /* here down needs new methods - was told not to start yet though
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

    public Driver? UpdateDriver(Driver updatedDriver)
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

    public Driver? DeleteDriver(Driver d)
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
    */
}