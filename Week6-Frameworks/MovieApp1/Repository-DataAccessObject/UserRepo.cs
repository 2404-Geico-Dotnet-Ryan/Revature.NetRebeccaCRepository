using System.ComponentModel;
using Microsoft.Data.SqlClient;

class UserRepo
{
    private readonly string _connectionString; // read only field can never be changed once it is set 
            // the underscore means private too 
    
    //Dependency inject specific form of this is Constructor Injection - it is happening in the constructor
    public UserRepo(string connString)
    {
        _connectionString = connString;
    }


    //add, get-one, get-all, update, and delete
    public User AddUser(User u)
    {
        //Set up db connection
        using SqlConnection connection = new SqlConnection(_connectionString); //feed it connection 
        connection.Open(); //opens the connection
        // uses I disposable which is a managed resource in VS Code we have to make sure we open them and close them 
        //this is method scoped as well as it is within a method
        //make SQL string
        string sql = "INSERT INTO [User] OUTPUTTED inserted. * VALUES (@UserName, @Password, @Role)";
        //Set up SQLCommand Object and use its methods to modify the Parameterized values.
        using SqlCommand cmd = new(sql, connection); 
        cmd.Parameters.AddWithValue("@UserName", u.Username);
        cmd.Parameters.AddWithValue("@Password", u.Password);
        cmd.Parameters.AddWithValue("@Role", u.Role);
        //Execute the query
        //if you do not care what is displayed after the action
        //cmd.ExecuteNonQuery (); //this executes a non select SQL statement (insert updates deletes)
        using SqlDataReader reader = cmd.ExecuteReader();
        //Extract the results
        if (reader.Read()) 
        {
            //If read found data then extract it (like a dictionary when it is used it uses a KEY to locate)
            User newUser = new();
            newUser.Id = (int)reader["Id"];   //basically csharp = SQL
            newUser.Username = (string)reader["Username"];
            newUser.Password = (string)reader["Password"];
            newUser.Role = (string)reader["Role"];
            return newUser;
        }
        else
        {
           //Else read found nothing and thus failed and then returns nothing 
           return null; 
        }
    }

    public User? GetUser(int id)
    {
       return null; 
    }

    public List<User> GetAllUsers()
    {
        return null;
    }

    public User? UpdateUser(User updatedUser)
    {
       return null;
    }

    public User? DeleteUser(User u)
    {
       return null;
    }
}