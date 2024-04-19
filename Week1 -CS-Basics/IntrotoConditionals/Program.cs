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

// int number = 10;
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
System.Console.WriteLine("Please enter your favorite number. Example 1, 2, 3, 542, etc.");
string input = Console.ReadLine();
System.Console.WriteLine("Your Favorite number is: " + input);

//converting Data Types --relisten to recording and try this project again
int number; //we need to create the number variable outside the IF statement for it "scope to stretch beyond just that block
if(input !=null)
{
    number = int.Parse(input);
}
else
{
    System.Console.WriteLine("You failed to enter only digits, you suck.");
    number = -1;
}


if (number > 10)
{
    System.Console.WriteLine("Your favoritenumber is greater than 10!");
}
else 
{
    if(number == 10)
    {
        System.Console.WriteLine("your favorit number is exactly 10!");
    }
    else
    {
        System.Console.WriteLine("Your favorite number is not greater than 10!");
    }
    
}


//An alternative to (most) nested conditionals
// IF -Elseif-Else statements

if (number > 10) //do not put ; here
{
    System.Console.WriteLine(">10 yay!");
}
else if (number >5)
{
    System.Console.WriteLine("5<your number<=10...........yay...!");
}
else
{
    System.Console.WriteLine("<5 .... wahtever .....");
}