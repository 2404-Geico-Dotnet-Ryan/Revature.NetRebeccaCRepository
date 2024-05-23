

class TicketService
{
    TicketRepo tr;  
    private readonly string _connectionString;
    private DriverRepo dr;
     
    public TicketService(TicketRepo tr)
    {
        this.tr = tr;
    }
    
    
    public Ticket? MakeAPay(Ticket ticket, decimal pay)
    {
        ticket.Balance -= pay;

        tr.UpdateTicket(ticket);

        return ticket;
        }
    public List<Ticket> GetUnpaidTickets()
    {
        List<Ticket> allTickets = tr.GetAllTickets();
        List<Ticket> allUnpaidTickets = new();

        foreach (Ticket t in allTickets)
        {
            if (t.PaidInFull == false)
            {
                allUnpaidTickets.Add(t);
            }
        }
        return allUnpaidTickets;
    }

    
    //Trivial Service
    public Ticket? GetTicket(int ticketId)
    {
        return tr.GetTicket(ticketId);
    }
    public Ticket? AddTicket(Ticket ticket)
    {
        return tr.AddTicket(ticket);
    }
    
}