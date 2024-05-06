using System;

class Program
{
    static void Main(string[] args)
    {
       int[] intArray = new int[5];
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;
        intArray[3] = 4; 
        intArray[4] = 5;

        int min = intArray[0];
        foreach (int num in intArray) // changed to for when would not work
        {
            if (num < min)
            { min=num; }
        }
            //Console.WriteLine("The min number is: " + min);
            //Needed to be return not console.write
            return min;
    }    
}

