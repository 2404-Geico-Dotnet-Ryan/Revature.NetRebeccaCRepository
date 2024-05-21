class Program
{
    static MovieService ms;
    static UserService us;
    static User? currentUser = null;

    static void Main(string[] args)
    {
        //Strings with an @ in front will provide you additional flexibility when creating strings.
        string path = @"C:\Users\U713PY\RevatureTraining.NET\Revature.NetRebeccaCRepository\MovieApp-db.txt";
        string connectionString = File.ReadAllText(path);

        //System.Console.WriteLine(connectionString); //definitely remove later...

        UserRepo ur = new(connectionString);
        us = new(ur);

        MovieRepo mr = new(); // <-- we'll need to add the connection string in the near future
        ms = new(mr);

        //Lets just quickly test the repo all by itself - then if it works
        //we can assume nothing else changed -> therefore it shouold intergrate cleaning into the app 
        //User newUser= new(0,"Clayton","Whatisgoingon","user");
        //System.Console.WriteLine("Added User: " + ur.AddUser(newUser));
        //This worked commenting out 
        //next test
        /*
        List<User>? allUsers = ur.GetAllUsers();
        if (allUsers != null)
        {
            //print all users
            foreach (User user in allUsers)
            {
                System.Console.WriteLine(user);
            }
        }
        else 
        {
            //Get all Users failed 
            System.Console.WriteLine("Get all Failed");
        }
        test worked commenting out as we are done with it 
        */
        InitMenu();
    }

    private static void InitMenu()
    {
        System.Console.WriteLine("Welcome to the Movie App!");
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] Login");
            System.Console.WriteLine("[2] Register");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");
            //Same Validation method copied over
            input = ValidateCmd(input, 2);

            keepGoing = DecideInitOption(input); //Slightly different method.
        }
    }

    private static void MainMenu()
    {
        System.Console.WriteLine("Welcome Back, " + currentUser?.Username);
        //Now represents that they want to keep going but also, havent selected Logout yet.
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] View All Available Movies");
            System.Console.WriteLine("[2] Checkout Movie");
            System.Console.WriteLine("[3] Checkin Movie");
            System.Console.WriteLine("[4] View Checked out Movies");
            System.Console.WriteLine("[0] Logout");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");
            //Same Validation method copied over
            input = ValidateCmd(input, 4);

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(input);
        }

        //end of loop means keepGoing = false -> Logout
        currentUser = null;
    }

    private static bool DecideInitOption(int input)
    {
        switch (input)
        {
            case 1:
                Login(); break;
            case 2:
                Register(); break;
            case 0:
            default:
                //If option 0 or anything else -> set keepGoing to false.
                return false;
        }

        return true;
    }

    private static bool DecideNextOption(int input)
    {
        switch (input)
        {
            case 1:
                RetrievingAvailableMovies(); break;
            case 2:
                CheckoutMovie(); break;
            case 3:
                CheckinMovie(); break;
            case 4:
                RetrievingCheckedOutMovies(); break;
            case 0:
            default:
                //If option 0 or anything else -> set keepGoing to false.
                return false;
        }

        return true;
    }


    private static void Register()
    {
        System.Console.WriteLine("Please Enter a New Username: ");
        string username = Console.ReadLine() ?? "";
        //Could Add some validation here to loop if Username is empty or taken.

        System.Console.WriteLine("Please Enter a New Password: ");
        string password = Console.ReadLine() ?? "";
        //Could Add some validation here to loop if Password is empty or not long enough.

        //Lets not set an ID and assume their Role to be 'user'
        //My Register method chose a different tactic of passing in the whole User
        User? newUser = new(0, username, password, "user");
        newUser = us.Register(newUser); //should return the new User.
        if (newUser != null)
        {
            System.Console.WriteLine("New User Registered!");
        }
        else
        {
            System.Console.WriteLine("Registration Failed! Please Try Again!");
        }
    }

    private static void Login()
    {
        while (currentUser == null)
        {
            System.Console.WriteLine("Please Enter Your Username: ");
            string username = Console.ReadLine() ?? "";

            System.Console.WriteLine("Please Enter Your Password: ");
            string password = Console.ReadLine() ?? "";

            //Setting the currentUser variable signifies Logging in. If Login() fails it will remain null.
            currentUser = us.Login(username, password);
            if (currentUser == null)
                System.Console.WriteLine("Login Failed. Please Try Again.");
        }

        //Now that they are logged in -> send them to Main Menu.
        MainMenu();
        //When this MainMenu ends, so does this calling of Login() which means go
        //back to InitMenu().
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

    private static void RetrievingCheckedOutMovies()
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