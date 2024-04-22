/*
Guessing Game - make a new project 
    - Start with teh asumed range of numbers 1-100
    - Prompt the user to Enter number in set range
    - Tell the user if the number is higher or lower or equal to number you program
    - If they are = they win the guessing game
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
System.Console.WriteLine("Please enter your favorite number: ");
string input = Console.ReadLine();
System.Console.WriteLine("Your Favorite number is: " + input);


int number = 0; 
if (input != null)
{
    number = int.Parse(input);
}
else
{
    System.Console.WriteLine("You failed to enter only digits, please enter digit between 1 and 100.");
    number = -1;
}

if (number > 25)
{
    System.Console.WriteLine("Sorry, You are a not a winner! Your number is lower than the number of the day.");
}
else
{
    if (number == 25)
    {
        System.Console.WriteLine("Congratulations! You chose the number of the day 251 You are a winner1");
    }
}
