using System;

class Program
{
    static void Main(string[] args)
    {
        TicketRepo tr = new();
        MainMenu(tr);
        System.Console.WriteLine("Thank you for using the ticket app. Have a good day!");
    }

    private static void MainMenu (TicketRepo tr)
    {
        System.Console.WriteLine("Welcome to the Ticket Application!");
        bool keepGoing = true:
        while (keepGoing == true) 
        {
            System.Console.WriteLine("PLease pick an function from the Main Menu below.");
            System.Console.WriteLine("****************************************");
            System.Console.WriteLine("[1] View all tickets Open and Closed");
            System.Console.WriteLine("[2] Open a New Ticket");
            System.Console.WriteLine("[3] Update a Ticket");
            System.Console.WriteLine("[4] Close a Ticket");
            System.Console.WriteLine("[5] View tickets assigned to you.");
            System.Console.WriteLine("[6] View tickets opened by you. ");
            System.Console.WriteLine("[7] View a single ticket.");
            System.Console.WriteLine("[0] Exit Ticket Application");
            System.Console.WriteLine("****************************************");

            int input = int.Parse(Console.ReadLine() ?? "0");

            input = ValidateCmd(input, 7);
            keepGoing = DecideNextOption(tr, input);

            //create switch case here -- maybe lengthy 

        }
    }

}  
        
        
