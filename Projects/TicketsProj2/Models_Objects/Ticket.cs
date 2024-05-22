    class Ticket
    {
    public int TicketId { get; set; }  //Ticket number common between all
    public string Type {get; set; } // what type  of ticket (title)
    public string OpenedBy {get; set; } //Name of reporter 
    public string Department {get;set; } //which department is opening tickett
    public bool Available { get; set; }  // true if ticket still needs to be picked up
    public bool Completed { get; set; } //only marked true when completed
    public long DueDate {get; set;} //date ticket should be completed by 
    public long CompletedDate {get; set;} //date ticket was completed 
    public string EmployeeID { get; set; } //which user got the ticket

    public Ticket()
    {
        Type = "";
        EmployeeID = "";  
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
