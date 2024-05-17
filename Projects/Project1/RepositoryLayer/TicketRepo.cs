class TicketRepo
{
    //make at least CRUD methods here

    TicketStorage ticketStorage =new();

    public Ticket? AddTicket(Ticket t)
    {
        t.TicketId= ticketStorage.ticketIdCounter++;
        ticketStorage.tickets.Add(t.TicketId, t);
        return t; 
    }

    public Ticket? GetTicket(int ticketId)
    {
        if (ticketStorage.tickets.ContainsKey(ticketId))
        {
            Ticket selectedTicket = ticketStorage.tickets[ticketId];
            return selectedTicket;
            System.Console.WriteLine(selectedTicket);
            
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
            ticketStorage.tickets[updatedTicket.TicketId] = updatedTicket;
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

}