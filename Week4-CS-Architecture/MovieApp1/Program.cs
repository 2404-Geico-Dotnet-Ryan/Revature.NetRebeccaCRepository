using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        MovieRepo mr = new(); //mr think of as movie retrieval but you can assign any title you want

         //I'm going to add a fancier UI this afternoon.
        MainMenu(mr);
        //When done - Goodbye!
        System.Console.WriteLine("Goodbye!");

    }
private static void MainMenu(MovieRepo mr)
    {
        System.Console.WriteLine("Welcome to the Movie App!");
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] View All Movies");
            System.Console.WriteLine("[2] Add New Movie");
            System.Console.WriteLine("[3] Update a Movie");
            System.Console.WriteLine("[4] Delete a Movie");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");
            //A fun addition - made a nice Input validator for these commands
            //the 4 represents the highest option allowed.
            input = ValidateCmd(input, 4);

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(mr, input);


            //need to make a rent a movie option that is purpose of the app and checck a movie back in etc.
            /*
            Business Logice for service layer 
            need user account -> signed in 
            Need to collect what they are wanting to check out 
            we need to check if the move is currently available to be checked out 
            make changes to the movie to represent that is checked out 
            finalize check out
            notes from 5/10/024
            */
        }
    }

    private static bool DecideNextOption(MovieRepo mr, int input)
    {
        //Let's use a Switch-Case for these numerical options
        // this takes the number and tells the application to go to a specific method
        switch (input)
        {
            case 1:
                {
                    //Call View All Movies - THIS IS A NEW METHOD!
                    RetrievingAllMovies(mr);
                    break;
                }
            case 2:
                {
                    //If option 2 -> Call Add New Movie UI method.
                    AddingNewMovie(mr);
                    break;
                }
            case 3:
                {
                    //If option 3 -> Call Update A Movie UI method.
                    UpdatingMovie(mr);
                    break;
                }
            case 4:
                {
                    //If option 4 -> Call Delete A Movie UI method.
                    DeletingMovie(mr);
                    break;
                }
            case 0:
            default:   //this syntax will handle when 0 or something else is entered
                {
                    //If option 0 or anything else -> set keepGoing to false.
                    return false;
                }
        }

        return true;
    }

    //Old testing at this point.
    private static void LinearTest(MovieRepo mr)
    {
        RetrievingMovie(mr); //Tested the MovieRepo - GetMovie()

        //Let's test adding a new movie into our collection.
        AddingNewMovie(mr);

        //Let's test updating a movie in our collection.
        UpdatingMovie(mr);

        //Let's test deleting a movie in our collection.
        DeletingMovie(mr);
    }

    private static void RetrievingAllMovies(MovieRepo mr)
    {
        //First get all movies in storage.
        List<Movie> movies = mr.GetAllMovies(); //<-- Also a new Method

        //Make some fancy display
        System.Console.WriteLine("=== List of All Movies ===");
        foreach (Movie m in movies)
        {
            System.Console.WriteLine(m);
        }
        System.Console.WriteLine("==========================");
    }

    private static void DeletingMovie(MovieRepo mr)
    {
        // Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        // Remove that movie from our storage.
        System.Console.WriteLine("Deleted Movie: " + mr.DeleteMovie(movie));
    }

    private static void UpdatingMovie(MovieRepo mr)
    {
        // Pick a Movie -> Ask for an ID of a Movie -> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        // Let the user update some fields
        System.Console.WriteLine("Please provide a new Title: ");
        movie.Title = Console.ReadLine() ?? "";
        // And we could add more steps to update more values...

        // Save those changed values to our storage
        System.Console.WriteLine("Updated Movie: " + mr.UpdateMovie(movie));
    }

    private static void AddingNewMovie(MovieRepo mr)
    {
        System.Console.WriteLine("Let's Add in a new Movie");
        System.Console.WriteLine("Please provide a Movie Title: ");
        string title = Console.ReadLine() ?? "";

        System.Console.WriteLine("Please provide a price: ");
        double price = double.Parse(Console.ReadLine() ?? "0");

        //Let's just assume that the Available will default to true
        //and by extension the returnDate will be 0.

        //Also not going to ask them for an ID - because our MovieRepo - AddMovie()
        //already gives it the next, correct value for ID.

        //Now we need to collect all of this information into a new Movie Object.
        Movie movie = new(0, title, price, true, 0);

        //Now that the information is collected into a Movie Object
        //let's use the MovieRepo to ADD it to our data storage.
        movie = mr.AddMovie(movie);
        //I am just reusing the movie Variable to store the updated values, 
        //if any, from the AddMovie() process.

        //For the sake of Clarity to the User of the App, lets inform them
        //of the newly added movie.
        System.Console.WriteLine("Newly Added Movie: " + movie);
    }

    private static void RetrievingMovie(MovieRepo mr)
    {
        //Let's test retrieving a movie that exists.
        //We have to make a little bit of assumption
        //The user has to know what kind of IDs might work.
        Movie retrievedMovie = PromptUserForMovie(mr);

        //Easiest way to showcase what Movie we retrieved is to print it out.
        System.Console.WriteLine("Retrieved Movie: " + retrievedMovie);
    }


    //Helper Method
    private static Movie PromptUserForMovie(MovieRepo mr)
    {
        //Now we have input validation
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {
            System.Console.WriteLine("Please enter a Movie ID: ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);
        }
        //Leaving the loop indicates that they have successfully picked a valid movie.
        return retrievedMovie;
    }
    //THIS IS OPTIONAL HE DID - 
    //Generic Command Input Validator - assume 1-MAXOPTIONS are the options. and 0 is an option to quit.
    private static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        // input is less than zero or (||) greater than greatest option number which is 4 in this case 
        {
            System.Console.WriteLine("Invalid Command - Please Enter a command 1-" + maxOption + "; or 0 to Quit");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }

        //if input was already valid - it skips the if statement and just returns the value.
        return cmd;
    }
}