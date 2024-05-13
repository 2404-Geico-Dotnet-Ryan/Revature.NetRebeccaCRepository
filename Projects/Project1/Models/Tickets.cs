    public int TicketId { get; set; }  //Ticket number common between all
    public string Driver { get; set; }
    public string Type {get; set; }
    public double Cost {get; set: }
    public double Balance {get;set; }
    public bool Status { get; set; }
    

    public Ticket()
    {
        TicketID = "";
    }

    public Ticket (int id, string driver , string type, double cost, bool status)
    {
        Id = id;
        Title = title;
        Price = price;
        Available = available;
        ReturnDate = returnDate;
    }

    public override string ToString() // you must have this to print out all information on a movie
    {
        return "{id:" + Id + 
        ", title:" + Title + 
        ", price: " +Price + 
        ", available: " + Available + 
        ", returnDate: " + ReturnDate + "}";
    }

}
