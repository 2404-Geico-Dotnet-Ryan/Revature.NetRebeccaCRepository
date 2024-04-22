/*
Control Flow - fundamental aspect of programming 
in which the developer
adds in concepts to further gain control over what will or will not happen
within the program. And/or how often. Often a Condition/Check is used to
assess whether or not a chunk of code will proceed.
    - Condition -> Boolean Expression -> Any statement that evaluates to true/false
    - Examples: 
        - true
        - false
        - boolean variable
        - expression: numberOfBooks > 5
*/

/* 
Conditional Statement - evaluates a condition to simply determine if a chunck of code is/isnt executed 

    - IF statement 
            - IF - ELSE Statements 
            - IF - Elseif-Else Statements
    -  Ternary operators 
    -Switch-Case Statements 
*/

// Quick detour - console input -> Console.ReadLine(); program waits for you to input something (inserts as string)
//use console.writeline statement to tell user what to do - "Please enter True if it is rainy or False if it is not"

// int number = 10;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isRainy = true; // this is hard coding
        if (isRainy) //put the variable inside here to determine true or false and output.
        {
            Console.WriteLine("It is Rainy outside!"); //this will only run if value is true
        }
        //{
        //  code block in here (should be indented one time for organization)
        //}
        // For abovecondition goes in ()--{} these indicates clusteror chunks/blocks of code (control flow statements or methods)
        // traditionally in C# it is used on a new line alone and closing on a new line alone above example of new line ---Java uses same line
        Console.WriteLine("Please enter your favorite number. Example 1, 2, 3, 542, etc.");
        string input = Console.ReadLine();
        Console.WriteLine("Your Favorite number is: " + input);

        //converting Data Types --relisten to recording and try this project again
        int number; //we need to create the number variable outside the IF statement for it "scope to stretch beyond just that block
        if (input != null)
        {
            number = int.Parse(input);
        }
        else
        {
            Console.WriteLine("You failed to enter only digits, you suck.");
            number = -1;
        }


        if (number > 10)
        {
            Console.WriteLine("Your favoritenumber is greater than 10!");
        }
        else
        {
            if (number == 10)
            {
                Console.WriteLine("your favorit number is exactly 10!");
            }
            else
            {
                Console.WriteLine("Your favorite number is not greater than 10!");
            }

        }


        //An alternative to (most) nested conditionals
        // IF -Elseif-Else statements

        if (number > 10) //do not put ; here
        {
            Console.WriteLine(">10 yay!");
        }
        else if (number > 5)
        {
            Console.WriteLine("5<your number<=10...........yay...!");
        }
        else
        {
            Console.WriteLine("<5 .... wahtever .....");
        }

        // Ternary Operator
        // It is an alternative to simple Ef=Else Statements where the tasks/outcomes are very similiar
        //syntax (condition) ? <option if true > : <option is false>

        if (number > 10)
        {
            Console.WriteLine("Your number is greater than 10");
        }
        else
        {
            Console.WriteLine("Your number is not greater than 10");
        }
        //emample of concatenation and Ternart Operator
        string phrase = "Your number is " + (number > 10 ? "greater than 10." : "Not greater than 10.");
        Console.WriteLine(phrase);

        //swtich - case statements 
        //are best used whent the options we want to consider are particular, finite, and/or incremental

        /* 
        switch (variable)
        {
            Case (value1):
            {
                //some code to excute if varaible == value1

            }
            Case (value2):
            {
                //some code to excute if varaible == value2
            }
            Case (Value3):
            Case (value4):
            {
                //some code to excute if varaible == value3 or value4
            }
        }
        */


        // example 
        Console.WriteLine("Enter and option 1+4");
        input = Console.ReadLine();
        int option = 0;

        if (input != null) option = int.Parse(input);

        switch (option)
        {
    case1:
        Console.WriteLine("You have chosen Option 1. You win $!.");
    //break;   
    case2:
        Console.WriteLine("You have chosen Option 1. You win $2.");
    //break;  
    case3:
    case4:
        Console.WriteLine("You did not");
    Default:
        Console.WriteLine("You did not choose an option 1-4. Please try agian."); 
}}
}