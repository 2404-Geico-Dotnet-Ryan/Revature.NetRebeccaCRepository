    class Ticket
    {
    public int TicketId { get; set; }  //Ticket number common between all
    public string Type {get; set; } // what type  of ticket (title)
    public decimal Cost {get; set; } //how much ticket was for 
    public decimal Balance {get;set; } //how much is left to pay on ticket
    public bool PaidInFull { get; set; }  // true if ticket still has balance
    public long DueDate { get; set; } //when is the ticket due
    public int DriverId { get; set; } //which user got the ticket

    public Ticket()
    {
        Type = ""; 
    }

    public Ticket (int ticketId, string type, decimal cost, decimal balance, bool paidinfull, long duedate, int driverid)
    {
        TicketId = ticketId;
        Type = type;
        Cost = cost;
        Balance = balance;
        PaidInFull = paidinfull;
        DueDate = duedate;
        DriverId = driverid;
    }

    public override string ToString() 
    {
        return "{Ticket ID:" + TicketId + 
        ", Type:" + Type + 
        ", Cost: " + Cost + 
        ", Balance: " + Balance + 
        ", PaidInFull: " + PaidInFull +
        ", DueDate: " + DueDate +
        ", Driver ID: " + DriverId + "}";
    }

}
