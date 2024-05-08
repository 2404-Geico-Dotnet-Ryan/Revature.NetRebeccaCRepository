/*
using System;
class Program
{
    static void Main(string[] args)
    {
        //CharToInt();
        //ruebenCode();
    }
*/
    /*public static int CharToInt(char c)
    {
        word1 = "abcd";
        foreach (char c in word1) 
        {// Convert the character to lowercase for simplicity
        c = char.ToLower(c);
	    // Subtract the Unicode value of 'a' from the Unicode value of the character
	    // then add 1 to make 'a' correspond to 1, 'b' correspond to 2, and so on.
        return c - 'a' + 1;
        System.Console.WriteLine(c - 'a' + 1);
        }
        
    }
    */
    
        char myChar = 'b';
        int intValue = (int)myChar; //this is casting portion
        System.Console.WriteLine("My character was: " + myChar);
        System.Console.WriteLine("My characters value is: " + intValue);

        char c = char.ToLower(myChar);
        int newIndexStart = (c-'a' + 1);
        System.Console.WriteLine(newIndexStart);
    

/*
string version = "Version 1.0.2.3";
string finalOutput = "";
foreach (char c in version)
{
    finalOutput = finalOutput + ((int)c).ToString();
}

Console.WriteLine(finalOutput);
// Output is 8610111411510511111032494648465046514
}
*/
