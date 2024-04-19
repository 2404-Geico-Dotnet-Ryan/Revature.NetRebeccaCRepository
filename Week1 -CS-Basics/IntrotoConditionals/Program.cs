/*
Control Flow - fundamental aspect of programming 

// ***Get notes from trainer folder asap 







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

int number = 10;
bool isRainy = true; // this is hard coding
if (isRainy) //put the variable inside here to determine true or false and output.
{
    System.Console.WriteLine("It is Rainy outside!"); //this will only run if value is true
}
//{
//  code block in here (should be indented one time for organization)
//}
// For abovecondition goes in ()--{} these indicates clusteror chunks/blocks of code (control flow statements or methods)
// traditionally in C# it is used on a new line alone and closing on a new line alone above example of new line ---Java uses same line
System.Console.WriteLine("Please enter your favorite number");
string input = Console.Readlin();
System.Console.WriteLine("Your Favorite number is: " + input);

//converting Data Types
int number = int.Parse(input);