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
            newDriver.DriverId = (int)reader["DriverId"];
            newDriver.DriverName = (string)reader["DriverName"];
            newDriver.Password = (string)reader["Password"];
            newDriver.Role = (string)reader["Role"];

            return newDriver;
        }
        else
        {
            return null;
        }
    }
    public Driver? GetDriver(int DriverId)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM dbo.Driver WHERE DriverId = @DriverId";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@DriverId", DriverId);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Driver newDriver = BuildUser(reader);
                return newDriver;
            }

            return null; 

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public List<Driver>? GetAllDrivers()
    {
        List<Driver> drivers = [];

        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM dbo.Driver";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here with the use of var.

            //Extract the Results
            while (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Driver newDriver = BuildUser(reader);

                //don't return! Instead Add to List!
                drivers.Add(newDriver);
            }

            return drivers;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public Driver? UpdateDriver(Driver updatedDriver)
    {
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "UPDATE dbo.Driver SET Username = @Drivername, Password = @Password, Role = @Role OUTPUT inserted.* WHERE DriverId = @DriverId";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@DriverId", updatedDriver.DriverId);
            cmd.Parameters.AddWithValue("@Drivername", updatedDriver.DriverName);
            cmd.Parameters.AddWithValue("@Password", updatedDriver.Password);
            cmd.Parameters.AddWithValue("@Role", updatedDriver.Role);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            if (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Driver newDriver = BuildUser(reader);
                return newDriver;
            }

            return null; //Didnt find anyone :(

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public Driver? DeleteDriver(Driver d)
    {
        try
        {
            //Set up DB Connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "DELETE FROM dbo.Driver OUTPUT deleted.* WHERE DriverId = @DriverId";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@DriverId", d.DriverId);

            //Execute the Query
            using var reader = cmd.ExecuteReader();

            //Extract the Results
            if (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Driver newDriver = BuildUser(reader);
                return newDriver;
            }

            return null; //Didnt find anyone :(

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }


    //Helper Method
    private static Driver BuildUser(SqlDataReader reader)
    {
        Driver newDriver = new();
        newDriver.DriverId = (int)reader["DriverId"];
        newDriver.DriverName = (string)reader["Drivername"];
        newDriver.Password = (string)reader["Password"];
        newDriver.Role = (string)reader["Role"];

        return newDriver;
    }
}