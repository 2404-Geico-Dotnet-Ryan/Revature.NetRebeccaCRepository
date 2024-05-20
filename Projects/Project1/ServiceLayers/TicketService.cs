
class TicketService
{

    TicketRepo tr = new();

    public static Ticket? CheckBalance(Ticket t)
    {

        if (t.Balance == 0)
        {
            System.Console.WriteLine("This ticket is already paid in full. Thank you!");
            return null;
        }
            return t;
            System.Console.WriteLine("Ticket currently has balance: " + t.Balance);
            System.Console.WriteLine("Ticket balance is due by " + t.DueDate);
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
        double payment = double.Parse(Console.ReadLine());
        t.Balance = t.Balance - payment;
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


    //Trivial Service
    public Ticket? GetTicket(int ticketId)
    {
        return tr.GetTicket(ticketId);
    }

    internal Ticket? CheckBalance(int input)
    {
        throw new NotImplementedException();
    }
}