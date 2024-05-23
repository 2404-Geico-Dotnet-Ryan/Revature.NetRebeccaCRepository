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
        System.Console.WriteLine("You have successfully logged in");
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
            System.Console.WriteLine("[3] Check Balance/Due Date on Ticket");
            System.Console.WriteLine("[4] Pay (partial/full) amount on Ticket");
            System.Console.WriteLine("[0] Quit");
            System.Console.WriteLine("=================================");

            int input = int.Parse(Console.ReadLine() ?? "0");

            input = ValidateCmd(input, 4);

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
                    CheckBalanceDue();
                    break;
                }
            case 4:
                {
                    PayAmountOnTicket();
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

    static void RetrievingSpecificTicket() // this one is not returning details in console I know this has to do with return but not console writeline but dont know how to fix 
    {
        System.Console.WriteLine("Please enter a Ticket ID (0 to Exit Process): ");
        int input = int.Parse(Console.ReadLine() ?? "0");
        int retrievedticket = ts.GetTicket(input);

        System.Console.WriteLine("=== Specific Tickets ===");
        System.Console.WriteLine(retrievedticket);
        System.Console.WriteLine("=================================");
    }
    private static decimal CheckBalance()//Stll needs work
    {
        Ticket? retrievedTicket = null;
        while (retrievedTicket == null)
        {
            System.Console.WriteLine("Please enter a Ticket ID (0 to Exit Process): ");
            int input = int.Parse(Console.ReadLine() ?? "0");
            
            if (input == 0) return null;

            retrievedTicket = ts.GetTicket(input); 
        }
        //       return retrievedTicket;
        decimal TicketBalance = retrievedticket
        long TicketDueDate = retrievedticket.DueDate;
        if (TicketBalance == 0)
        {
            System.Console.WriteLine("This ticket is paid in full. Thank you. ");
        }
        else
        {
        System.Console.WriteLine("Ticket Balance: " + TicketBalance+ "and is due on " + TicketDueDate);
        }
    }

    private static void PayAmountOnTicket()
    {
        throw new NotImplementedException();
    }
    private static Ticket? PromptUserForTicket()
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

    //
    /*    private static void PayAmountOnTicket()
    {
    private static void WithdrawalMoney()
    {
        // Need to create code block to remove $$ from existing balance
        Account? account = PromptUserForAccount();
        if (account == null) return;

        System.Console.WriteLine("Please enter the amount you would like to withdrawal from your account: " + account.AccountName);
        double withdrawal = double.Parse(Console.ReadLine() ?? "0");

        accountServices.MakeWithdrawal(account, withdrawal);

        System.Console.WriteLine("The new balance for " + account.AccountName + " is: " + account.Balance);
        System.Console.WriteLine();
        
    }
    }
    */  
    
}   
    


