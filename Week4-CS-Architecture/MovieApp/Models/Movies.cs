class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; }
    public long ReturnDate { get; set; }

    public Movie()
    {
        Title = "";
    }

    public Movie(int id, string title, double price, bool available, long returnDate)
    {
        Id = id;
        Title = title;
        Price = price;
        Available = available;
        ReturnDate = returnDate;
    }

}