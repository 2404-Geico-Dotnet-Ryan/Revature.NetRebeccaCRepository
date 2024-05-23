class TicketStorage
{
    public Dictionary<int, Ticket> tickets;
    public int ticketIdCounter = 1;


    public TicketStorage()
    {
        Ticket ticket1 = new(1, "Speeding", 205.00M, 205.00M, false, 0, 1); 
        Ticket ticket2 = new(2, "Failure to Yeild Right of Way", 50.00M, 25.00M, false, 0, 2 );
        Ticket ticket3 = new(3, "SeltBelt Violation", 30.85M, 30.85M, false, 0, 3); ticketIdCounter++;
        tickets = new();
        tickets.Add(1, ticket1);
        tickets.Add(ticket2.TicketId, ticket2);
        tickets.Add(ticket3.TicketId, ticket3);
    }
}