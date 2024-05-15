class TicketService
{

    TicketRepo tr = new();

    public Ticket? CheckBalance(Ticket t)
    {
        if (t.PaidInFull || t.Balance == 0)
        {
            System.Console.WriteLine("This ticket is already paid in full. Thank you!");
        }
        else
            System.Console.WriteLine("Ticket currently has balance: " + Balance);
            System.Console.WriteLine("Ticket balance is due by " + DueDate);
    }
    public Ticket Pay(Ticket t)
    {
        if (TicketService.PaidInFull == true)
        {
            System.Console.WriteLine("This ticket is already paid in full. Thank you!");
        }
        System.Console.WriteLine("The Balance on this ticket is " + balance);
        System.Console.WriteLine("How much would you like to pay today?");
        payment = int.Parse(Console.ReadLine());
        balance = t.balance - payment;
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
    public Ticket? GetTicket(int id)
    {
        return tr.GetTicket(id);
    }
}