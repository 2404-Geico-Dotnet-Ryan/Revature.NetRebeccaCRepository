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