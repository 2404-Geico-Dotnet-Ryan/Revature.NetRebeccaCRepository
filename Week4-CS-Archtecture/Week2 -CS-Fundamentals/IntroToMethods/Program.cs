using System;
// System.Console.WriteLine("Hello World!"); //this is another method inside the main method
/*
    Problem: Often we have chuncks of code that perform some operation that we would like to potentially 
    use again later in our programs. 
    Right now, our only means to do so is to simply copy/paste that chunk of code to repeat ifs 
    intended functions. 
        
    Methods - Allow us to recall a chunk of code all consolidated to one place as often as we'd like, whil
    simultaneuosly abstracting away the implementations behind archieving such functionaliy, allowing
    us to focus solely on the intention of said chunk of code.
*/
class Program
{
    static void Main(string[] args)  //This is where the main method is created. AKA method messenger- header
    {
        // SayHello();

        // AddNumbers(4, 5);
        // AddNumbers(6, 10);
        // AddNumbers(7, 9);

        // int result = SquareNumber(5);
        // System.Console.WriteLine(result);
        // Main method code here
        PrintMenu();      //Prints the main Menu 
        int cmd = GetCmd(); //Retrieves input from user  
        ProcessCmd(cmd);
    }
    public static void PrintMenu()
    {
        System.Console.WriteLine("Welcome to our app!");
        System.Console.WriteLine("==================");
        System.Console.WriteLine("Please enter a command:");
        System.Console.WriteLine("[1] SayHello ");
        System.Console.WriteLine("[2] Add Two Numbers");
        System.Console.WriteLine("[3] Square a Number");
        System.Console.WriteLine("===================");
    }
    public static int GetCmd()
    {
        string? input = Console.ReadLine();
        int cmd = 0;
        if (input != null) cmd = int.Parse(input);
        return cmd;
    }

    public static void ProcessAddNumber()
    {
        System.Console.WriteLine("Enter 1st Number: ");
        string? value1 = Console.ReadLine();
        System.Console.WriteLine("Enter 2nd Number: ");
        string? value2 = Console.ReadLine();

        int num1 = 0, num2 = 0;
        if (value1 != null) num1 = int.Parse(value1);
        if (value1 != null) num2 = int.Parse(value2);

        AddNumbers(num1, num2);

    }

    public static void ProcessSquareNumber()
    {
        System.Console.WriteLine("Enter a Number:");
        string? value1 = Console.ReadLine();

        int num1 = 0;
        if (value1 != null) num1 = int.Parse(value1);

        System.Console.WriteLine(SquareNumber(num1));
    }
    public static void ProcessCmd(int cmd)
    {
        switch (cmd)
        {
            case 1:
                {
                    SayHello(); break;
                }
            case 2:
                {
                    ProcessAddNumber(); break;
                }
            case 3:
                {
                    ProcessSquareNumber(); break;
                }
        }
    }
    //based on input execute
    //AddNumbers(4, 5);
    //AddNumbers(6, 10);
    //AddNumbers(7, 9);

    //int result = SquareNumber (5); //we also needd to have something to store the returned info. from the method below 
    //int result not needed above due to we are not returning any information 
    // System.Console.WriteLine(result);//void methods shoould have this in the other method not the main method - to cover all begining to end handling    
    //SayHello(); // You can move this to top of main method if you want the welcome first (main method order determines order processed)
    
        //lets make a method that simply adds two numbers togeher and print it out
        //Method Signature Syntax: 
        //  - access_modifier- grants access for program to informaton - default is actually private
        //  - return_tpe (void = self contained)
        //  - MethodName (parameterType paremeterName,parameterTypes ParameterName2) {}
        //      - Parameters inside ()
        //      - Arguement when calling it to run then parameter when making the parameters 
        // Syntax
        // access_modifier return_tpe MethodName (parameterType paremeterName, parameterTypes ParameterName2) {}

        //This starts the Compiling that runs before the main method
        //Compiling data does not declare it - declaring happens in method- compiling is just seeing what we want to accomplish and then runs code in Main Method
        // compile time vs run time is different 
        public static void AddNumbers(int num1, int num2) //had to add Static because it is in the main method and they must match
        {
            System.Console.WriteLine(num1 + num2);
        }
        //this will run the number of times that you have in the main method so 3 AddNumbers will give 3 results
        // papa john's example of adding items to cart\\\maybe a good example for when this would be used
        //********** This is end of 4/23/2024 lesson*****************
        //Start of class 4/24/2024 lession 
        // Lets make a method that reeturns the squared value of a number 
        public static int SquareNumber(int num1)
        {
            int square = num1 * num1;
            return square;
        }
        public static void SayHello()
        {
            //Print out this welcome message
            System.Console.WriteLine("Please enter your name: ");
            string? input = Console.ReadLine();
            System.Console.WriteLine("==================");
            System.Console.WriteLine("Hello, " + input + "!");
            System.Console.WriteLine("==================");
        }
        // Things to do - google some practice questions on Chat GPT etc something like below
        //Takes in two strings and prints both of them twice
        //Find the largest number between 3 ints
    }
