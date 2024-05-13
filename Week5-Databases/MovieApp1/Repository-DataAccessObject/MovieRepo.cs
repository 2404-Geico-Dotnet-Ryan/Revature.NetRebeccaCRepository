class MovieRepo
{
    /*
    This Class is in the Data Access/repository layer of our application (creating your method)
    So it is solely responsible for any data access and management centered around our movie object.

    4 major Operations we would like to manage in this location (methods)
    - CRUD operators (really need to make all four even if you do not think you will use it)  
    will possibly need more than one for some of these scenarios
        -C (Create)  - add a new movie
        -R (Read)    - see what is in our data
        -U (Update)  - update property of a movie
        -D (Delete)  - removing a movie
    */
    MovieStorage movieStorage=new();

    // the Create Method portion of CRUD
    public Movie AddMovie(Movie m) //this is different than the constructor this is adding it to our collection
    {
        //we need to first ensure that movie being added has a correct id
        //so best way is to assume it doesn't, and force it to use our idCounter
        m.Id = movieStorage.idCounter++; //increments the value after to prep for next time needed

        //add the movie into our collection
        movieStorage.movies.Add(m.Id, m);
        return m;

    }

    //The READ Method portion of CRUD
    public Movie? GetMovie(int id) //this will help when user puts in invalid infomration - preventative approach
    {
        if (movieStorage.movies.ContainsKey(id))
            {
            Movie selectedMovie= movieStorage.movies[id];
            return selectedMovie;
            //return movieStorage.movies[id]; 
        }
        else
        {
            System.Console.WriteLine("Invalid Movie Id - please try again.");
            return null; //if the key is not there return null
        }
    }
    //THIS IS A NEW METHOD!
    //No Parameters because...get everything is get everything. No options to choose.
    public List<Movie> GetAllMovies()
    {
        //I am chooseing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        //this is a nice to have not a neccessary function but changing this storaged infromation to a list 
        //makes this easier to iterate though and list will be all over when coding in real world
        return movieStorage.movies.Values.ToList();
    }


    public Movie? UpdateMovie(Movie updatedMovie)
    {
        //Assuming that the ID is consistent with an ID that exists
        //then we just have to update the value (aka Movie) for said key (ID) within the Dictionary.
        try
        {
            movieStorage.movies[updatedMovie.Id] = updatedMovie;
            //I choose to send the updated movie back as a "response-feedback" system.
            //"Here is me telling you that I have updated the storage with this movie I send back to you"
            return updatedMovie;
        }
        catch (Exception)
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

    public Movie? DeleteMovie(Movie m)
    {
        //If we have the ID -> then simply Remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);

        if (didRemove)
        {
            //now we will return the movie that got deleted.
            return m;
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

}
