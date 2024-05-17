using System.Net.Sockets;

class MovieStorage
{
   /*
    This entire set up is TEMPORARY 
    we do not know how to work with Databases yet 
    -by extension -communicate with them 

    SO we are going to build some devices for storing Movies
    BUT everything is sadly lost everytime the application shuts down
   */ 

    public Dictionary<int,Movie> movies; //using the int ID to map too the movie as a whole
    public int idCounter = 5;
    //Making this constructor to give us some pre-loaded Moviesto work with 
    public MovieStorage() //this is the constructor
    {
        Movie movie1 =new(1,"Iron Man",5, true, 0, null);
        Movie movie2 =new(2,"The Avengers",4.50, true, 0, null);
        Movie movie3 =new(3,"Winter Solidier",3.99, true, 0, null);
        Movie movie4 =new(4,"AntMan",4.25, true, 0, null);
        //introducing automatic way to keep up with ID **this is when line 15 in code was introduced we hard coded before that
        Movie movie5 =new (idCounter,"Xmen", 5.00, true,0, null); idCounter++; //this is post incremented to increase idCounter for next movie
        //now need to add to the dictionary 
        Movie movie6 =new (idCounter,"Wolverine", 5.99, true,0, null); idCounter++; 
        movies = new(); //Sets the Dictionary to an empty colletion then you add to like below.
        movies.Add(1, movie1);
        movies.Add(movie2.Id, movie2);   //this is better syntax so you do not have memorize id numbers etc.
        movies.Add(3, movie3);
        movies.Add(4, movie4);
        movies.Add(movie5.Id, movie5);
        movies.Add(movie6.Id, movie6);
    }
}