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
    public Movie? GetMovie(int id)
    {
        if (movieStorage.movies.ContainsKey(id))
        {
        Movie selectedMovie= movieStorage.movies[id];
        return selectedMovie;
            //uses key index strategy using the Key being the movie ID
            //review last friday recording 5/3/2024
        //Alternative Solution - simplier code
        //return movieStorage.movies[id]; 
        }
        else
        {
            return null; //if the key is not there return null
        }
    }
    /*
    //The Update Method portion of CRUD
    public Movie UpdatePrice(int id)
    {
        Movie selectedMovie= movieStorage.movies[id];
    }

    //The Delete Method portion of CRUD
    public Movie DeleteMovie(int id)
    {
        Movie selectedMovie= movieStorage.movies[id];
    }
    */






}