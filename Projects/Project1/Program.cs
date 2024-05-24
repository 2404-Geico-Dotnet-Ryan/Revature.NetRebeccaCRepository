using System;
using System.Data.Common;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

class Program
{
    static TicketService ts;
    static DriverService ds;
    static Driver? currentDriver = null; 


    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Ticket Application");
        string path = @"C:\Users\U713PY\RevatureTraining.NET\Revature.NetRebeccaCRepository\RebeccaProject1-app-db.txt";
        string connectionString = File.ReadAllText(path);

        //System.Console.WriteLine(connectionString); //need to delete later 

        DriverRepo dr = new(connectionString);
        ds = new(dr);

        TicketRepo tr = new(connectionString, dr);
        ts = new(tr);
        LoginMenu();
    }


    private static void LoginMenu()
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] Register as a Driver (new user to the application.)");
            System.Console.WriteLine("[2] Log in as registered Driver (returning customer)");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");
            input = ValidateCmd(input, 2);
            keepGoing = DecideUserOption(input);
        }
        System.Console.WriteLine("You have successfully logged in.");
        System.Console.WriteLine("Reminder if you are a new user to the system or you have recieved a new ticket you will need to add them before you can view the ticket or make a payment.");
    }

    private static void MainMenu()
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            System.Console.WriteLine("Please Pick an Option Down Below:");
            System.Console.WriteLine("=================================");
            System.Console.WriteLine("[1] View All Unpaid Tickets");
            System.Console.WriteLine("[2] View a specific Ticket");
            System.Console.WriteLine("[3] Check Balance on a Specific Ticket");
            System.Console.WriteLine("[4] Pay amount on Ticket");
            System.Console.WriteLine("[5] Add a ticket to a newly created account");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");

            input = ValidateCmd(input, 5);

            //Extracted to method - uses switch case to determine what to do next.
            keepGoing = DecideNextOption(input);
        }
    }
    private static bool DecideUserOption(int input)
    {
        switch (input)
        {
            case 1:
                Register(); break;
            case 2:
                Login(); break;
            case 0:
            default:
                return false;
        }

        return true;
    }

 

    private static bool DecideNextOption(int input)
    {
        switch (input)
        {
            case 1:
                {
                    RetrievingAllUnpaidTickets();
                    break;
                }
            case 2:
                {
                    RetrievingSpecificTicket();
                    break;
                }
            case 3:
                {
                    CheckBalance();
                    break;
                }
            case 4:
                {
                    PayAmountOnTicket();
                    break;
                }
            case 5:
            {
                AddTicket();
                break;
            }
            case 0:
            default:
                {
                    return false;
                }
        }

        return true;
    }

    private static void Register()
    {
        System.Console.WriteLine("Please Enter Your UserName as your first and last name: ");
        string username = Console.ReadLine() ?? "";

        System.Console.WriteLine("Please Enter a Password for your accout: ");
        string password = Console.ReadLine() ?? "";
        Driver? newDriver = new(0, username, password, "user");
        newDriver = ds.Register(newDriver); 
        if (newDriver != null)
        {
            System.Console.WriteLine("New Driver Registered!");
            System.Console.WriteLine("You can now log in and will then add your ticket next!");
        }
        else
        {
            System.Console.WriteLine("Registration Failed! Please Try Again!");
        }
    }

    private static void Login()
    {
        while (currentDriver == null)
        {
            System.Console.WriteLine("Please Enter Your Username: ");
            string username = Console.ReadLine() ?? "";

            System.Console.WriteLine("Please Enter Your Password: ");
            string password = Console.ReadLine() ?? "";

            //Setting the currentUser variable signifies Logging in. If Login() fails it will remain null.
            currentDriver = ds.Login(username, password);
            if (currentDriver == null)
                System.Console.WriteLine("Login Failed. Please Try Again.");
        }
        MainMenu();
    }
   
    static void RetrievingAllUnpaidTickets() //this works
    {
        List<Ticket> tickets = ts.GetUnpaidTickets();

        System.Console.WriteLine("=== List of Unpaid Tickets ===");
        foreach (Ticket t in tickets)
        {
            System.Console.WriteLine(t);
        }
        System.Console.WriteLine("=================================");
    }

    static void RetrievingSpecificTicket() // this has been fixed and works 
    {
        System.Console.WriteLine("Please enter a Ticket ID (0 to Exit Process): ");
        int input = int.Parse(Console.ReadLine() ?? "0");
        var retrievedticket = ts.GetTicket(input);

        System.Console.WriteLine("=== Specific Tickets ===");
        System.Console.WriteLine(retrievedticket);
        System.Console.WriteLine("=================================");
    }
    private static void CheckBalance()
    {
        Ticket? retrievedTicket = PromptUserForTicket();
        decimal ticketBalance = retrievedTicket.Balance;

        System.Console.WriteLine("Ticket Balance: " + ticketBalance);
        System.Console.WriteLine();
    }

    static void PayAmountOnTicket()
    {
        Ticket? ticket = PromptUserForTicket();
        if (ticket == null) return;
        System.Console.WriteLine("Please enter the amount you would like to pay on your ticket: " + ticket.TicketId);
        decimal pay = Decimal.Parse(Console.ReadLine() ?? "0");          
        ts.MakeAPay(ticket, pay);
        System.Console.WriteLine("The new balance for " + ticket.TicketId + " is: " + ticket.Balance);
        System.Console.WriteLine();
    }
    
    static Ticket? PromptUserForTicket()
    {
        
        Ticket? retrievedTicket = null;
        while (retrievedTicket == null)
        {
            System.Console.WriteLine("Please enter a Ticket ID (0 to Exit Process): ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            
            if (input == 0) return null;

            retrievedTicket = ts.GetTicket(input); 
        }  
        return retrievedTicket;    
    }

    static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        {
            System.Console.WriteLine("Invalid Command - Please Enter a command 1-" + maxOption + "; or 0 to Quit");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }
        return cmd;
    }
    
    private static void AddTicket()//this works
    {
        System.Console.WriteLine("Let's add a new ticket for your account!");
        System.Console.WriteLine();
        System.Console.WriteLine("What type of Ticket do you need to add?");
        string type = Console.ReadLine() ?? "";
        System.Console.WriteLine();
        System.Console.WriteLine("Please enter the Cost of this ticket: Formatting should be 250.00M");
        decimal cost = decimal.Parse(Console.ReadLine() ?? "0");
        decimal balance = cost;
        bool paidInFull = false;
        long dueDate = 0;
        System.Console.WriteLine();
        int DriverId = currentDriver.DriverId;

        Ticket? ticket = new(0, type, cost, balance, paidInFull, dueDate, DriverId);

        ticket = ts.AddTicket(ticket);
        
        if (ticket != null)
        {
            System.Console.WriteLine("Newly Added Ticket: " + ticket);    
        }
        else
        {
            System.Console.WriteLine("Failed to create ticket, please try again");
        }
    }
    
}
  


