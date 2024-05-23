using Microsoft.Data.SqlClient;

class TicketRepo
{

    private readonly string _connectionString;
    private readonly DriverRepo dr;
    public TicketRepo(string connectionString, DriverRepo driverRepo)
    {
        _connectionString = connectionString;
        dr = driverRepo;
    }

    
    public Ticket? AddTicket(Ticket t)
    {

        using SqlConnection connection = new(_connectionString);
        connection.Open();

        string sql = "INSERT INTO dbo.Ticket OUTPUT inserted.* VALUES (@Type, @Cost, @Balance, @PaidInFull, @DueDate, @DriverID)";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Type", t.Type);
        cmd.Parameters.AddWithValue("@Cost", t.Cost);
        cmd.Parameters.AddWithValue("@Balance", t.Balance);
        cmd.Parameters.AddWithValue("@PaidInFull", t.PaidInFull);
        cmd.Parameters.AddWithValue("@DueDate", t.DueDate);
        cmd.Parameters.AddWithValue("@DriverID", t.DriverId);

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            Ticket newTicket = BuildTicket(reader); 
            return newTicket;
        }
        else
        {
            return null;
        }
    }

    public Ticket? GetTicket(int TicketId)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM dbo.Ticket WHERE TicketId = @TicketId";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@TicketId", TicketId);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Ticket getTicket = BuildTicket(reader);
                return getTicket;
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

    public List<Ticket>? GetAllTickets()
    {
        List<Ticket> tickets = [];

        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM dbo.Ticket";

            using SqlCommand cmd = new(sql, connection);

            using SqlDataReader reader = cmd.ExecuteReader();

            //Extract the Results
            while (reader.Read())
            {
                //for each iteration -> extract the results to a User object -> add to list.
                Ticket newTicket = BuildTicket(reader);

                //don't return! Instead Add to List!
                tickets.Add(newTicket);
            }

            return tickets;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
    }

    public Ticket? UpdateTicket(Ticket updatedTicket)
    {
        try
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string sql = "UPDATE dbo.Ticket SET Type = @Type, Cost = @Cost, Balance = @Balance, PaidInFull = @PaidInFull, DueDate = @DueDate, DriverId = @DriverID OUTPUT inserted.* WHERE TicketId = @TicketId";

            using SqlCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@TicketId", updatedTicket.TicketId);
            cmd.Parameters.AddWithValue("@Type", updatedTicket.Type);
            cmd.Parameters.AddWithValue("@Cost", updatedTicket.Cost);
            cmd.Parameters.AddWithValue("@Balance", updatedTicket.Balance);
            cmd.Parameters.AddWithValue("@PaidInFull", updatedTicket.PaidInFull);
            cmd.Parameters.AddWithValue("@DueDate", updatedTicket.DueDate);
            cmd.Parameters.AddWithValue("@DriverID", updatedTicket.DriverId);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Ticket newTicket = BuildTicket(reader);
                return newTicket;
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

    private Ticket BuildTicket(SqlDataReader reader)
    {
        Ticket newTicket = new();
        newTicket.TicketId = (int)reader["TicketId"];
        newTicket.Cost = (decimal)reader["Cost"];
        newTicket.Balance = (decimal)reader["Balance"];
        newTicket.PaidInFull = (bool)reader["PaidInFull"];
        newTicket.DueDate = (long)reader["DueDate"];
        newTicket.DriverId = (int)reader["DriverId"];
        return newTicket;
    }

    /* unsure if I even want this option
 
    public Ticket? DeleteTicket(Ticket t)
    {
        bool didRemove = ticketStorage.tickets.Remove(t.TicketId);
        if (didRemove)
        {
            return t;
        }
        else
        {
            System.Console.WriteLine("Invalid Ticket ID - Please Try Again");
            return null;
        }
    }
    */
}