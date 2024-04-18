// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");

/*
strings - a sequence of characters (letters, numbers, symbols and whitespace) all put together 
     represented with "double quotes" in C# for String Literals
     "Hello, World!" is a string literal
        The type here is a string 
String is a reference_type (aka an Object data type)
    Objects have more capabilities than just storing a value
    They can also have methods to perform various functionality (potentially upon some stored value//values)
         Example Car Object
            States - fields - properties (variables - pieces of data about the Object Car that define it specifically )
                Color
                Make 
                Model
                Year 
                VIN                    
                numberOfTires 
                Horsepower
            Behviors _Methods - functunality we wish to perform on our Object Car
                Drive Car
                Park
                TurnOnRadio
                RollDownWindows
                GoInReverse
                TurnOnWipers 
                TurnOnHeadlights
*/

//Create a string variable
string word = "Hello";
System.Console.WriteLine(word);

// To access fields and methods from objects we create use we the "." (memberaccess operator) commonly know as .(dot) operator

System.Console.WriteLine(word.Length); //Length is a PROPERTY of the word
word = "Hi!";
System.Console.WriteLine(word.Length);
System.Console.WriteLine(word.ToUpper()); //must have the () inside to work. this is using a stack. Does not affect the orginal only for this statement
System.Console.WriteLine(word);
System.Console.WriteLine(word.ToLower());

// (), {}, [] All three used commonly and have to complete series in code or wont work
//"method" and "functions" are interchangable words for now in class. C# generally uses Method

//ToUpper();  Does not need any addtitional information 
//Writeline(word); Does need to know context of what to print to console --- referred to as an ARGUMENT - something we provide with in the method to work (context)
// when defining a method: referred to as teh method's parameters

word = "Hello World!";
System.Console.WriteLine(word.Length);

System.Console.WriteLine(word.Substring(0)); //this will need more context - has to match the data type which is defaulted to INT
System.Console.WriteLine(word.Substring(6));
/*
INDEXES - strings and other such varios collection - based devices use Indexes/
Indexes describe the postition of that element with the entire set of data. 
String -> the postition of that character within the entire String
each index has a certain numbers of bits 
for example Char is 166 bits see string in memory in revature repo

Indexes (in MOST programming languages) are 0-indexed
The 1st character in the string starts at the index 0.
   The 2nd character is at index 1, etc. 
   The last index of any string is length -1 (because we start at 0 -- also known as off by one)
*/
//if you want only want part of the string not to end 
System.Console.WriteLine(word.Substring(6, 2)); //if you just wanted the WO in Hello World
//System.Console.WriteLine(word.Substring(6, 10)); // will give you an error becuase there are not 11 characters after the 6th character you started at
/*
You will get this error 
Unhandled exception. System.ArgumentOutOfRangeException: Index and length must refer to a location within the string. (Parameter 'length')
   at System.String.ThrowSubstringArgumentOutOfRange(Int32 startIndex, Int32 length)
   at System.String.Substring(Int32 startIndex, Int32 length)
   at Program.<Main>$(String[] args) in C:\Users\U713PY\RevatureTraining.NET\Revature.NetRebeccaCRepository\Week1 -CS-Basics\IntroToStrings\Program.cs:line 72
*/


//String Concatenation
// when using the "+" sign with Strings the behavior changes from simple mathmaticial addition.
//concatenation - the combing of two or more strings in which conjoin all the characters into one String.

string phrase = "Hello" + "World!";
System.Console.WriteLine(phrase);

string fname = "Rebecca";
string lname = "Chester";
System.Console.WriteLine("Hello my name is:" + fname + "" +lname +"!"); //the + "" adds a space

int num1 = 1;
int num2 = 2;
System.Console.WriteLine("Num1 = "+ num1);
System.Console.WriteLine("Num2 = "+ num2);

System.Console.WriteLine("1" + 1); // performs concatention , NOT addition! (output will be num1  1 and a 1 so 11)



