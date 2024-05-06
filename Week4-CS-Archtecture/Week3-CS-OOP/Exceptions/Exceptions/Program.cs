using System;

class Program
{
    static void Main(string[] args)
    {
        //Preventive();
        //HandlingExceptions();
        //System.Console.WriteLine(whyFinally());
        try
        {
            ThrowingExceptions();
        }
        catch (NoFunExcpetion e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public static void ThrowingExceptions()
    {
        //You can introduce your own Exceptions into the code at will:
        //throw keyword in code
        //this will stop code unless you update the main method

        System.Console.WriteLine("Enter a number between 1-100: ");
        int guess = int.Parse(Console.ReadLine() ?? "0");

        int correct =50;
        if(guess==correct)
        {
            System.Console.WriteLine("You guessed correc! Congratulations1");
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
            throw new NoFunException("I guess you aren't have fun anymore! Goodbye1");
        }

    }

    public static int whyFinally()
    {
        int x = 10;
        int y = 1;
        try 
        {
           int result = x / y;
           retrun result; 
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
        System.Console.WriteLine("Printing from the end of the method.");
    }

    public static void HandlingExceptions()
    {
        int[] numbers = [1, 2, 3];
        System.Console.WriteLine("Enter an Index");
        string input =Console.ReadLine() ?? "0";
        //handling exception Try Catch Block
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
        catch (Exception ex) //all other exceptions
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        System.Console.WriteLine("Program End");
    }  
    private static void Preventive()
    {
        int[] numbers = [1, 2, 3];
        System.Console.WriteLine("Enter an Index");
        int index = int.Parse(Console.ReadLine() ?? "0"); 
        //if you put int index = 3;if you change this to 2 it will work
        //the ?? "0" addresses if null do this called Null Coalescing
        //nulls cause alot of exceptions
        //keep this one handy 
        //Preventive Approach to dealing with input not in the array.
        if (index >= numbers.Length || index < 0) //This means both condition are (and)true && - if one or the other is true (or) is ||
            {
                 System.Console.WriteLine("You failed to enter an index in the array!");
            }
        else
            {
                System.Console.WriteLine(numbers[index]);
            }
        //System.Console.WriteLine(numbers[index]); // console write if [index is 3]will give unhandled exception (out of bounds with array)
        //- there is nothing in the code to address it// nothing continues after this 
        System.Console.WriteLine("Program End");
    }
    
    
}
