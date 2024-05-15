class TicketRepo
{
    //make at least CRUD methods here

    TicketStorage ticketStorage =new();

    public Ticket AddTicket(Ticket t)
    {
        t.Id = ticketStorage.idCounter++;
        ticketStorage.tickets.Add(t.Id, t);
        return t; 
    }

    public Ticket? GetTicket(int id)
    {
        // Alternative approach that breaks each step down.
        if (ticketStorage.tickets.ContainsKey(id))
        {
            Ticket selectedTicket = ticketStorage.tickets[id];
            return selectedTicket;
            // return movieStorage.movies[id];
        }
        else
        {
            System.Console.WriteLine("Invalid Ticket ID - Please Try Again");
            return null;
        }
    }

    public List<Ticket> GetAllTickets()
    {
        return ticketStorage.tickets.Values.ToList();
    }

    public Ticket? UpdateTicket(Ticket updatedTicket)
    {
        try
        {
            ticketStorage.tickets[updatedticket.Id] = updatedTicket;
            return updatedTicket;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Ticket ID - Please Try Again");
            return null;
        }
    }

      public Ticket? DeleteTicket(Ticket t)
    {
        bool didRemove = ticketStorage.tickets.Remove(t.Id);
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

}