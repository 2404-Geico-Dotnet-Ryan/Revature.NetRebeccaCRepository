using System.Dynamic;
using Microsoft.VisualBasic;

class Calculator
{

/*
Polymorphism -> Many Forms -> an entity can exist with multiple labels attached to it all at the same time. 

Static Polymorphism - Overloading 
    - we can have multiple methods wtih the same name, the only requirement is that they each have a unique set of paramteters(based strickly on data type)
        - change the quantity
        - Change the order 
        - Change the type

Dynamic Polymorphism - Overriing 
    -   we can change the implememntation of methods that we inherit into a new child class to fit the narative of 
        the new class    
    -   virtual - C# does require for you to specify that a method can be override
    -   override -- and by extension, you must explicity declare that you are overriding
*/

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    //Both can exist at the same time 
    //Because C# can always identify which version of Add()
    public static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    //public static Add(int value2, int value4)
    //{
    //       return value2 + value4;
    //}

    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Add(string num1, string num2)
    {
               return double.Parse (num1) + double.Parse(num2);
    }

    public static double Add(string num1, double num2)
    {
            return (double.Parse(num1) + num2);
    }

    public static double Add(double num1, string num2)
    {
        return num1 +double.Parse(num2);
    }

    public static int Add(int num1)
    {
        return 0;
    }

    public static  int Add(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    //Parameter array -> lets you provide a varaible of arguments to satistify this one parameter
    //in which it will 'collect' them into one array for us.
    //you can only have 1 parameter array per method
    //it MUST be the last parameter in the method.
    public static double Add(params double[] array) //this gets the last priority to run of all methods
    {
        double sum = 0;
        foreach (double num in array)
        {
            sum += num;
        }
        return sum;
    }
    //this differs from using multiple ararys
   // public static int Add(int[] array1, array2, )
    //{
    //    //get code for this 
    //}

}

   