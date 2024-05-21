    class Ticket
    {
    public int TicketId { get; set; }  //Ticket number common between all
    public string Type {get; set; } // what type  of ticket (title)
    public double Cost {get; set; } //how much ticket was for 
    public double Balance {get;set; } //how much is left to pay on ticket
    public bool PaidInFull { get; set; }  // true if ticket still has balance
    public long DueDate { get; set; } //when is the ticket due
    public string Driver { get; set; } //which user got the ticket

    public Ticket()
    {
        Type = "";
        Driver = "";  
    }

    public Ticket (int ticketId, string type, double cost, double balance, bool paidinfull, long duedate, string driver)
    {
        TicketId = ticketId;
        Type = type;
        Cost = cost;
        Balance = balance;
        PaidInFull = paidinfull;
        DueDate = duedate;
        Driver = driver;
    }

    public override string ToString() 
    {
        return "{Ticket ID:" + TicketId + 
        ", Type:" + Type + 
        ", Cost: " + Cost + 
        ", Balance: " + Balance + 
        ", PaidInFull: " + PaidInFull +
        ", DueDate: " + DueDate +
        ", Driver: " + Driver.ToString() + "}";
    }

}
