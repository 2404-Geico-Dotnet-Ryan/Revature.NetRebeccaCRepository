/*
Guessing Game - make a new project 
    - Start with teh asumed range of numbers 1-100 - done
    - Prompt the user to Enter number in set range - done
    - Tell the user if the number is higher or lower or equal to number you program- done
    - If they are = they win the guessing game - done
    - IF higher or lower let them guess again
    - The while loop essentially need to contain 
        - Prompt the user
        -retrieve their quess 
        -tell them higher or lower or if correct
        - while (gues !=correctChoice) -> run the loop again
    Bonus
    - create your own library/Random Class (Random number genearator) that way you can play too
    - The user is prompted to play again with out having to re run the program 
        - involves (likely) another (outer) while loop

        for self study for loops? 
*/
// my code
/*
System.Console.WriteLine("Please enter a numerical digit between 1 - 100: ");
string input = Console.ReadLine();


int number = 0; 
if (input != null)
    {
    number = int.Parse(input);
    }
else 
{
    System.Console.WriteLine("You failed to enter only digits."); //need to add loop to allow to try again
    number = -1;
}



if (number > 25)
    {
        System.Console.WriteLine("Sorry, You are a not a winner! Your number is greater than the number of the day. Please try again.");
//need to add looping 
    }
else if (number == 25)
    {
         System.Console.WriteLine("Congratulations! You chose the number of the day 25 You are a winner!");
    }
else 
    {  
        System.Console.WriteLine("Sorry, You are a not a winner! Your number is lower than the number of the day. Please try again.");
    }
// pick up on looping part 

do
{
    System.Console.WriteLine("Please try again!Pick a number between 1-100.");
    string? input1 = Console.ReadLine();
    if (input != null) number = int.Parse(input);
    if (number != 25)
    {
        System.Console.WriteLine("Please try again!Pick a number between 1-100.");
    }
}
while (number != 25);
System.Console.WriteLine("Congratulations! You chose the number of the day 25 You are a winner!");
*/  



System.Console.WriteLine("**********Ryans Solution****************");
/*
Inserting Ryan's Solution
*/
bool again = true;

while (again)
{
    //The entire game starts here
    Random random = new Random();
    int correctNum = random.Next(1, 101);
    int guess = 0;
    string? input;

    while (guess != correctNum)
    {
        System.Console.WriteLine("Please enter a number between 1-100: ");
        input = Console.ReadLine();
        if (input != null) guess = int.Parse(input);
        // guess = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing Operator

        if (guess > correctNum)
        {
            System.Console.WriteLine("Your guess was Too High!");
        }
        else if (guess < correctNum)
        {
            System.Console.WriteLine("Your guess was Too Low!");
        }
    }

    System.Console.WriteLine("Your guess was correct! The number was: " + correctNum);
    //The entire game ends here

    System.Console.WriteLine("Would you like to play again? (Y) or (N)?");
    input = Console.ReadLine();

    if (!"Y".Equals(input))
    {
        again = false;
    }
}

System.Console.WriteLine("Thanks for Playing! Goodbye!");
//Bonus Bonuses are not included in this solution 
