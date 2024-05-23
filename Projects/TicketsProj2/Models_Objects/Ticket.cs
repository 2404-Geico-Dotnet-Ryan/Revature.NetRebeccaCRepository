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
    public decimal Cost {get; set} //how much working the ticket cost
    public string EmployeeID { get; set; } //which user got the ticket


    public Ticket()
    {
        Type = "";
        EmployeeID = "";  
    }

    public Ticket (int ticketId, string type, string openedby, string deptartment, bool avialable, bool completed, long duedate, long completeddate, decimal cost, string employee)
    {
        TicketId = ticketId;
        Type = type;
        OpenedBy = openedby;
        Department = Department;
        Available = available;
        Completed = completed;
        DueDate = duedate;
        CompletedDate = completeddate;
        Cost = cost;
        Employee = employee;
    }

    public override string ToString() 
    {
        return "{Ticket ID:" + TicketId + 
        ", Type:" + Type + 
        ", Cost: " + Cost +
        ", Opened By: " + OpenedBy +
        ", Department: " + Department + 
        ", Available for pick up:" + Available +
        ", Completed: " + Completed +
        ", DueDate: " + DueDate +
        ", Completed Date: " + CompletedDate +
        ", Cost: "+ Cost +
        ", Employee: " + Employee.ToString() + "}";
    }

}
