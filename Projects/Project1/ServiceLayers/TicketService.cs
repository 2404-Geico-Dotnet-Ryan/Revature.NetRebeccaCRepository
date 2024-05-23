

class TicketService
{
    TicketRepo tr;  
    private readonly string _connectionString;
    private DriverRepo dr;
     
    public TicketService(TicketRepo tr)
    {
        this.tr = tr;
    }
    
    public Ticket? Pay(Ticket t)
    {
        if (t.PaidInFull == true)
        {
            System.Console.WriteLine("This ticket is already paid in full. Thank you!");
            return null;
        }
        System.Console.WriteLine("The Balance on this ticket is " + t.Balance);
        System.Console.WriteLine("How much would you like to pay today?");
        decimal payment = decimal.Parse(Console.ReadLine()); //ask Jennifer about
        t.Balance -= payment;
        tr.UpdateTicket(t);
        return t;
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

    public List<Ticket> GetSpecificTicket(int id)
    {
        List<Ticket> allTickets = tr.GetAllTickets();
        List<Ticket> SpecificTicket= new();

        foreach (Ticket t in allTickets)
        {
            if (t.TicketId == id)
            {
                SpecificTicket.Add(t);
            }
        }
        return SpecificTicket;
    }
    //Trivial Service
    public Ticket? GetTicket(int ticketId)
    {
        return tr.GetTicket(ticketId);
    }

    
}