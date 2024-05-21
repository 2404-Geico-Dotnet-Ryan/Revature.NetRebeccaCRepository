class MovieService
{
    /*
    Services:
        - Check out movies
        - Check in movies 
        - Get (your) checked out movies (action words not how UI will display that comes later)
        - Get Available movies 
    Trivial Services:
        - Remember why we organize our application into layers 
            - It allows us to organize and clearly conceptualize the flow of operations 
                with in the application at any given moment of time. 
            - We like to have the application Always flow up and down one layer at a time  
            - KISS = keep it in order so that we "Keep It Simple Stupid"
    Example of Business Logice for service layer:
            - need user account -> signed in 
            - Need to collect what they are wanting to check out 
            - we need to check if the move is currently available to be checked out 
            - make changes to the movie to represent that is checked out 
            - finalize check out
    */

    MovieRepo mr;

    public MovieService(MovieRepo mr)
    {
        this.mr = mr;
    }

    public Movie? CheckOut(Movie movie) //m is the movie we want to attempt to check out 
    {
        //lets first see if the movie is availabe - or lets return null if it is not available - get that out of the away
        if (movie.Available == false)// also can be written if(!movie.Available) reads if not available
        {
            System.Console.WriteLine("Movie Currently Unavailable");
            return null; //movie wont get checked out 
        }
        //Happy Path Execution -> Movie is good to go and can be checked out
        //what does it actually mean to check out the movie 
        // 1 - movie becomes unavailable 
        movie.Available = false; 
        // 2 - a returndate is set -- have to get unix code for today date and time- get unix
        // return right now DateTimeOffset.UtcNow.ToUnixTimeSeconds()
        // then add days + () adds in seconds (60seconds*60 minutes*24hours in day * number of days you choose)
        movie.ReturnDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60*60*24*14); //today plus 14 days)
        //movie.ReturnDate = DateTimeOffset.UtcNow.AddDays(2).ToUnixTimeSeconds(); this was a sideline conversation
        // (optional)  - it s set to a paticular user 
        // 3 - Make sure to update the data storage with changes
        mr.UpdateMovie(movie); //performs update in storage
        return movie; // I am choosing to send back the cehcked out movie - this is your choice.
    }


    //Try to check in method on your own --I have completed
    public Movie? CheckIn(Movie movie) //m is the movie we want to attempt to check in 
    {
        //lets first see if the movie is availabe - or lets return null if it is not available - get that out of the away
        if (movie.Available==true || movie.ReturnDate==0)// also can be written if(!movie.Available) reads if not available
        {
            System.Console.WriteLine("Movie is already checked in.");
            return null; //movie wont get checked out 
        }
        //Happy Path Execution -> Movie is checked out and ready to check in
        //what does it actually mean to check out the movie 
        // 1 - movie becomes available 
        movie.Available = true; 
        // 2 - a returndate is set back to null-
        movie.ReturnDate = 0; //put it back to null
        // 3 - Make sure to update the data storage with changes
        mr.UpdateMovie(movie); //performs update in storage
        return movie; // I am choosing to send back the checked in movie
    }


    public List<Movie> GetAvailableMovies() //no user input needed it gets all 
    {
        //Get all movies 
        List<Movie> allMovies = mr.GetAllMovies();
        // then filter out movies you do not want.
        List<Movie> availableMovies = new();
        //run a loop over all movies to determine if they make the cut to be added to the list
        foreach (Movie movie in allMovies) //means for each movie in the allMovies list
        {
            if (movie.Available)   //if the movie is available or  = true
            {
                availableMovies.Add(movie); //then add to new list for available movies 
            }
        }

        
        //another way to do this 
        /*
            see recording to see his display of how to do differently 
            Using Linq
            Language intergrated query
            which is intentionally designed to feel like you are writing database queries
            we will get into this next week sometime
        */
        //retun that filtered list 
        return availableMovies;
    }

    public List<Movie> CheckedOutMovies(User u)
    {
        List<Movie> allMovies = mr.GetAllMovies();

        //Similar process to GetAvailableMovies
        List<Movie> filteredMovies = [];

        foreach (Movie movie in allMovies)
        {
            //Using the Id values over the Whole User object is just a bit better/easier to compare.
            if (movie.Renter?.Id == u.Id) //Refresher: why '?.' Hmmmmm... 
            {
                filteredMovies.Add(movie);
            }
        }

        return filteredMovies;
    }
    public Movie? GetMovie(int id)
    {
        return mr.GetMovie(id);
    }

   
    
}