/*
Control Flow - Loops allow us to execute a chunk of code for as long as the condition continues to be true. 
    - The condition is reassessed after each "iteration' of the loop, before executing the loop again.
    - Major Types 
        - While Loop 
            -Do while loop
            -Best used when the number of iterations (outcomes) needed by the loop is not known/non-deterministic
                - example validation (how many times does it take to successfully sign in)
                - but there can be limits set or left for them to continue to try forever
        - For loop 
            - For each loop
            - best used the number of iterations by the loop is known or could be calculated (calculatable)
            - Finite  
*/


//counter = counter + 1;  // better is counter ++;
//counter++; 
//counter++;

/*
--- this will continue to run forever if it is true
while (condition)
{
    //code to excute while contition is true. 
} 
*/
//Print the numbers 1-100

int counter = 1;
System.Console.WriteLine(counter);
while (counter <= 100)
{
    System.Console.WriteLine(counter); // this alone will print 1 FOREVER
    counter++; // this is what stops the loop
}
System.Console.WriteLine("End of Program");

//Print the sum of the numbers 1-100
counter = 1;
int end = 1000;
long sum = 0;

while (counter <= end)
{
    sum = sum + counter; // better as sum += counter;
    counter++;
}
System.Console.WriteLine("The sum of the numbers 1-" + end + " is " + sum); // answer is bigger than int so need to change long


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