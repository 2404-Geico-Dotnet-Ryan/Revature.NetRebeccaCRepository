using System;

class Program
{
    static void Main(string[] args)
    {
        MovieRepo mr =new(); //mr think of as movie retrieval but you can assign any title you want

        //lets test retrieving a movie that exist.
        //We have to make a little bit of an assumption 
        //the user has to know what kind of IDs might work
        System.Console.WriteLine("Please enter a Movie ID: ");
        int input = int.Parse(Console.ReadLine() ?? "0"); //the ?? "0" defaults the value to 0 if none is provided
        Movie retrievedMovie = mr.GetMovie(input);
        //easiest way to showcase what movie we recieved is to print it out 
        System.Console.WriteLine("Retrieved Movie: "+ retrievedMovie);

        //lets test adding a new movie into our collection




    }
}
