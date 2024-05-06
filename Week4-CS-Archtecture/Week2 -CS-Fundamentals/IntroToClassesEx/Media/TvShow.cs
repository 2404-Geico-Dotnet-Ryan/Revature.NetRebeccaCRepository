class TvShow
{

    public string? Title {get;set;}
    public int Rating {get;set;}
    public double Price {get; set;}

    public TvShow()
    {
        Title = "Please Provide Title";
    }
    
    public TvShow (string title, int rating, double price)
    {
        Title = title;
        Rating= rating;
        Price = price;

    }
}
