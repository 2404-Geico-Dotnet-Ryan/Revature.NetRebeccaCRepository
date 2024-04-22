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
/*
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
*/

//Input Validation (registering new account, Guess Game, Verification)
//  User has to put in information in order for program to execute 

//Tell teh user to print out the number : 5

int counter = 1;
while (counter <= 100)
{
    System.Console.WriteLine(counter);
    counter++;
}
System.Console.WriteLine("End of Program");

// Print the Sum of the numbers 1-1000000
counter = 1;
int end = 1000000;
long sum = 0;
while (counter <= end)
{
    sum += counter;
    counter++;
}
System.Console.WriteLine("The sum of the numbers 1-" + end + " is: " + sum);


//Start of class on Monday 4-22-2024

//Tell the user to print out the number 5
int num = 0; // if this number is 5 then it already mets condition for while loop then it will skip the while loop and only run do loop
while (num != 5) 
{
    System.Console.WriteLine("Please input the number : 5");
    string? input = Console.ReadLine();
     if (input != null) num = int.Parse(input);

     if (num != 5)
     {
        System.Console.WriteLine("Please try again");
     }
 }

// Down here is for when the loop is done
// -> they finally inputted the correct value
System.Console.WriteLine("You finally got it correct! You entered " + num);
System.Console.WriteLine("Proceeding to next step.");

//Do-While Loop
//Do-while loop , as opposed to just while loops, will alway 
/*
Syntax
do
{
    //whatever we want the loop to do 
}
while (condition);

*/

//Rebranding the last example

do
{
    System.Console.WriteLine("Do: Please input the number : 5");
    string? input = Console.ReadLine();
     if (input != null) num = int.Parse(input);

     if (num != 5)
     {
        System.Console.WriteLine("Please try again");
     }
}
while(num != 5);

System.Console.WriteLine("You finally got it correct! You entered " + num + "Proceeding to next step!"). ;


//---------------------------
// For Loop
// Best used when the number of iterations is known / calculable. 

//benifit this makes code inside of the loop much simpler
/*
for (initallization;(executed1st) condition (techinically check executed2nd); update (executed 3rd and is the change that is made before we check condition again) )
{

}
*/

//Print the numbers 1-100

for(int count = 1; count <= 100; count++) //start at 1; go up to 100; add 1 each time 
{
    System.Console.WriteLine(count);
}

//Print the sum of the numbers 1-10000
int result = 0;
for(int count = 1, count <=10000; count++)
{
    result += count;
}
System.Console.WriteLine(result);

//On break until 11:15 try this 
//Print only even nummbers 2-200
//Print all numbers starting with 50 going to 25


































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