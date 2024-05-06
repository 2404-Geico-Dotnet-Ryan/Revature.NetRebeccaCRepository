using System;

class Program
{
    //Exception tell us where the code went wrong and why 
    //also called stack trace 
    static void Main(string[] args)
    {
        PreventiveApproach();
        HandlingExceptions();
        System.Console.WriteLine(WhyFinally());
        ThrowingExceptions();
        try
        {
            ThrowingExceptions();
        }
        catch (NoFunException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public static void ThrowingExceptions()
    {
        //You can introduce your own Exceptions into the code at will:
        // throw keyword

        System.Console.WriteLine("Enter a number between 1-100: ");
        int guess = int.Parse(Console.ReadLine() ?? "0");

        int correct = 50;

        if (guess == correct)
        {
            System.Console.WriteLine("You got it correct!");
        }
        else if (guess > correct)
        {
            System.Console.WriteLine("Your guess is too high!");
        }
        else if (guess < correct && guess > 0)
        {
            System.Console.WriteLine("Your guess is too low!");
        }
        else
        {
            throw new NoFunException("I guess you aren't having fun anymore! Goodbye!");
        }

    }

    public static int WhyFinally()
    {
        int x = 10;
        int y = 1;

        try
        {
            int result = x / y;
            return result;
        }
        catch (DivideByZeroException ex)
        {
            System.Console.WriteLine(ex.Message);
            return 0;
        }
        finally
        {
            System.Console.WriteLine("Printing from the Finally Block");
        }

        System.Console.WriteLine("Printing from the End of the Method.");

    }

    public static void HandlingExceptions()
    {
        int[] numbers = [1, 2, 3];

        System.Console.WriteLine("Enter an index: ");
        string input = Console.ReadLine() ?? "0";
        //Handling Exceptions: try-catch block
        try
        {
            int index = int.Parse(input);
            System.Console.WriteLine(numbers[index]);
        }
        catch (IndexOutOfRangeException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        catch (Exception ex) //handles all other exceptions (has to go last if there are some before it)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }

        System.Console.WriteLine("Program End");

    }

    private static void PreventiveApproach()
    {
        //if you put int index = 3;if you change this to 2 it will work
        //the ?? "0" addresses if null do this called Null Coalescing
        //nulls cause alot of exceptions
        //keep this one handy 
        //Preventive Approach to dealing with input not in the array.
        int[] numbers = [1, 2, 3];

        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing
        //This means both condition are (and)true && - if one or the other is true (or) is ||

        //Preventive Approach to dealing with issues.
        if (index >= numbers.Length || index < 0)
        {
            System.Console.WriteLine("You failed to enter a correct index!");
        }
        else
        {
            System.Console.WriteLine(numbers[index]);
        }

        System.Console.WriteLine("Program End");
    }
}