using System;
using System.ComponentModel;

class Program
{
    static MovieService ms;  
    static UserService us;
    static User? currentUser = null;
    
    static void Main(string[] args)
    {
        //strings with an @ in front provide you with additional flexiblity when creating strings.
        string path = @"c:\Users\U713PY\RevatureTraining.NET\MovieAppDBConnections.txt";
        string connectionString = File.ReadAllText(path);
        System.Console.WriteLine(connectionString);// this is just for confirmation - you have to remove this later 
        
        UserRepo ur= new(connectionString);
        us= new(ur);

        //UserMenu(); // this still needs to be added 
        //MainMenu(); //this will have to be rebranded we just do not need it this minute 

    }
    private static void MainMenu()
    {
        //Similar menu different options.
        System.Console.WriteLine("Welcome to the Movie App!");
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] View All Available Movies");
            System.Console.WriteLine("[2] Checkout Movie");
            System.Console.WriteLine("[3] Checkin Movie");
            System.Console.WriteLine("[4] View Checked out Movies");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");
            //Same Validation method copied over
            input = ValidateCmd(input, 4);

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(input);
        }
    }

    private static bool DecideNextOption(int input)
    {
        switch (input)
        {
            case 1:
                {
                    RetrievingAvailableMovies();
                    break;
                }
            case 2:
                {
                    CheckoutMovie();
                    break;
                }
            case 3:
                {
                    CheckinMovie();
                    break;
                }
            case 4:
                {
                    RetrievingCheckedOutMovies();
                    break;
                }
            case 0:
            default:
                {
                    //If option 0 or anything else -> set keepGoing to false.
                    return false;
                }
        }

        return true;
    }

    private static void RetrievingAvailableMovies()
    {
        //use our service methods now.
        List<Movie> movies = ms.GetAvailableMovies();

        System.Console.WriteLine("=== List of Available Movies ===");
        foreach (Movie m in movies)
        {
            System.Console.WriteLine(m);
        }
        System.Console.WriteLine("=================================");
    }

    private static void CheckoutMovie()
    {
        //Ew, What is that?
        while (true)
        {
            //Pick a movie to Check out.
            Movie? movie = PromptUserForMovie();
            //Adding a way out...
            if (movie == null) return; //Leaves method.
            //Check it out.
            movie = ms.CheckOut(movie);
            if (movie != null)
            {
                System.Console.WriteLine("Movie Checked Out: " + movie); break; // <-- :O
            }
            else
            {
                System.Console.WriteLine("Please Try Another Movie.");
            }
        }

    }

    private static void CheckinMovie()
    {
        //Ew, What is that?
        while (true)
        {
            //Pick a movie to Check in.
            Movie? movie = PromptUserForMovie();
            //Adding a way out...
            if (movie == null) return; //Leaves method.
            //Check it in
            movie = ms.CheckIn(movie);
            if (movie != null)
            {
                System.Console.WriteLine("Movie Checked in: " + movie); break; // <-- :O
            }
            else
            {
                System.Console.WriteLine("Please Try Another Movie.");
            }
        }
    }

    private static void RetrievingCheckedOutMovies() //this is just a placeholder for now
    {
        System.Console.WriteLine("Sorry the code for this method is in another castle.");
    }



    //Same Helper Methods
    private static Movie? PromptUserForMovie()
    {
        //Now we have input validation
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {
            System.Console.WriteLine("Please enter a Movie ID (0 to Exit Process): ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            //Okay I want to add a "way out" for anytime they want to exist the process.
            if (input == 0) return null;

            retrievedMovie = ms.GetMovie(input);    // <-- add a trivial service method here.
        }
        //Leaving the loop indicates that they have successfully picked a valid movie.
        return retrievedMovie;
    }

    //Generic Command Input Validator - assume 1-maxOption are the number of options. and 0 is an option to quit.
    private static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        {
            System.Console.WriteLine("Invalid Command - Please Enter a command 1-" + maxOption + "; or 0 to Quit");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }

        //if input was already valid - it skips the if statement and just returns the value.
        return cmd;
    }
}