using System;
using System.Net.NetworkInformation; //this is where it imports code from 

class Program
{
    static void Main(string[] args)  //This is where the main method is created. AKA method messenger- header
    {
        // Main method code here
        System.Console.WriteLine("Hello World!"); //this is another method inside the main method
       
        /*
        Problem: Often we have chuncks of code that perform some operation that we would like to potentially 
        use again later in our programs. 
        Right now, our only means to do so is to simply copy/paste that chunk of code to repeat ifs 
        intended functions. 
        
        Methods - Allow us to recall a chunk of code all consolidated to one place as often as we'd like, whil
        simultaneuosly abstracting away the implementations behind archieving such functionaliy, allowing
        us to focus solely on the intention of said chunk of code.
        */
        AddNumbers(4,5);
        AddNumbers(6, 10);
        AddNumbers(7, 9);

        
    }

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
// This is end of 4/23/2024 lesson*****************
}
