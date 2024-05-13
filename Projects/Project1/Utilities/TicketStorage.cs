class TicketStorage
{
    public Dictionary<int, TicketStorage> ticket;
    public ticketID= 1;


    public TicketStorage()
    {
        Ticket ticket1 = new(idCounter, "Speeding", 205.00, 205.00, False, 0, null); idCounter++;
        Ticket ticket2 = new(idCounter, "Failure to Yeild Right of Way", 50.00, 25.00, False, 0, null); idCounter++;
        Ticket ticket3 = new(idCounter, "SeltBelt Violation", 30.85, 30.85, False, 0, null); idCounter++;ticket =[];
        Tickets= [];
        ticket.Add(ticket1.ticketID, ticket1);
        ticket.Add(ticket2.ticketID, ticket2);
        ticket.Add(ticket3.ticketID, ticket3);

    }
}