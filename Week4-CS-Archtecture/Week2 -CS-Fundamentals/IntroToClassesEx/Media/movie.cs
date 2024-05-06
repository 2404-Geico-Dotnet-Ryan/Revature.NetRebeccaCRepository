namespace media
{

class Movie
{
    public string? Title {get;set;}
    public int Rating {get;set;}
    public double Price {get; set;}

    public Movie()
    {
        Title = "Please Provide Title";
    }
    
    public Movie (string title, int rating, double price)
    {
        Title = title;
        Rating= rating;
        Price = price;

    }
}
}