using Microsoft.Data.SqlClient;

class UserRepo
{

    private readonly string _connectionString;

    public UserRepo(string connString)
    {
        _connectionString = connString;
    }



    //add, get-one, get-all, update, and delete
    public User AddUser(User u)
    {
        //Set up DB Connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "INSERT INTO [User] OUTPUT inserted.* VALUES (@Username, @Password, @Role)";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Username", u.Username);
        cmd.Parameters.AddWithValue("@Password", u.Password);
        cmd.Parameters.AddWithValue("@Role", u.Role);

        //Execute the Query
        // cmd.ExecuteNonQuery(); //This executes a non-select SQL statement (inserts, updates, deletes)
        using SqlDataReader reader = cmd.ExecuteReader();

        //Extract te Results
        if (reader.Read())
        {
            //If Read() found data -> then extract it.
            User newUser = new();
            newUser.Id = (int)reader["Id"];
            newUser.Username = (string)reader["Username"];
            newUser.Password = (string)reader["Password"];
            newUser.Role = (string)reader["Role"];

            return newUser;
        }
        else
        {
            //Else Read() found nothing -> Insert Failed. :(
            return null;
        }
    }

    public User GetUser(int id)
    {
        return null;
    }

    public List<User> GetAllUsers()
    {
        return null;
    }

    public User UpdateUser(User updatedUser)
    {
        return null;
    }

    public User DeleteUser(User u)
    {
        return null;
    }
}