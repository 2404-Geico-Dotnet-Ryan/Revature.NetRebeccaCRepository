class Book
{
    /*
        General Structure to Models:
            - fields (Properties)
            - constructors
            - any other methods for this class       
    */

    // Vocab of the Day : Encapsulation 
    //  - Hiding or protecting our data to further control of who has access
    //  - This is not "secure or encrypt" our data - just makes them go through the correct process to change data 
    //  - Involves two main things
    //      -Make *private*  fields (defualt is private)
    //      -Make *public* methods for accessing and manipulating those fields
    //      - Accessing the field: Accessors (method)-> Getters
    //      - Modifying the field: Modifiers/Mutators -> Setters


    //fields
     string? title;
     string? author;
     int pages;

    //Constructors
    public Book()
    {

    }

    public Book(string title, string author, int pages)
    {
        Title =title;   //changing from this.title to Title
        Author =author;
        Pages = pages;
    }

    //Getters and setters 
    /*
    public string? GetTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }
    */

    //Alternative to Getter/Setter called PROPERTIES
    public string Title{ get;set; }
    public string Author{ get;set; }
    public int Pages{ get;set; }

    //Method


    //ToString

}