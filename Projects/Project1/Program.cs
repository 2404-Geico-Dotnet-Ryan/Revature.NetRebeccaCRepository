using System;

class Program
{
    static TicketService ts = new();
    //static Driver? currentDriver = null;
    //TODO work on getting Driver in like User in Movies once we get to that

    static void Main(string[] args)
    {
        // DriverMenu(); //TODO make sure this menu is working correctly 
        MainMenu();
    }

    /*
    private static void DriverMenu()
    {
        System.Console.WriteLine("Welcome to the Ticket App!");
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
            keepGoing = DecideNextOption(input);
        }
        System.Console.WriteLine("You have successfully logged in");
    }
    */
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

    private static void RetrievingAllUnpaidTickets()
    {
        //use our service methods now.
        List<Ticket> tickets = ts.GetUnpaidTickets();

        System.Console.WriteLine("=== List of Unpaid Tickets ===");
        foreach (Ticket t in tickets)
        {
            System.Console.WriteLine(t);
        }
        System.Console.WriteLine("=================================");
    }

     private static void CheckBalanceDue()
    {
        
    }

    private static void PayAmountOnTicket()
    {

    }
    
    //TODO why not liking public or private here down

    static Ticket? RetrievingSpecificTicket()
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

    //Generic Command Input Validator - assume 1-maxOption are the number of options. and 0 is an option to quit.
    static int ValidateCmd(int cmd, int maxOption)
    {
        while (cmd < 0 || cmd > maxOption)
        {
            System.Console.WriteLine("Invalid Command - Please Enter a command 1-" + maxOption + "; or 0 to Quit");
            cmd = int.Parse(Console.ReadLine() ?? "0");
        }
        return cmd;
    }

}
