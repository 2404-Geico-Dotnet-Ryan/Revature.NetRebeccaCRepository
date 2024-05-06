using System;

class Program
{
    static void Main(string[] args)
    {
        string? itemsInlist = "";
        string answer = "";
        bool enterAnotherItem = true;

        List<string> groceryList = new List<string>(); //this can also be List<string> groceryList = new();
        // or List<string> groceryList = [];
        System.Console.WriteLine("Lets get started on your Grocery List Menu");

        do
        {
            System.Console.WriteLine("Enter an item: ");
            itemsInlist = Console.ReadLine();
            groceryList.Add(itemsInlist);
            System.Console.WriteLine("Would you like to enter another item? Yes or No.");
            answer = Console.ReadLine();

            if (answer.ToLower().Trim() == "yes") //ToLower makes any answer typed into lower everything-Trim addresses extra spacces
            {
                enterAnotherItem = true;
            }
            else if (answer.ToLower().Trim() == "no")//ToLower makes any answer typed into lower everything-Trim addresses extra spacces
            {
                enterAnotherItem = false;
            }
            else
            {
                enterAnotherItem = false;
            }
        }
        while (enterAnotherItem == true);
      
        System.Console.WriteLine("Here is your Grocery List: ");
        foreach (string item in groceryList)
        {
            System.Console.WriteLine(item);  
        }

    }
}
