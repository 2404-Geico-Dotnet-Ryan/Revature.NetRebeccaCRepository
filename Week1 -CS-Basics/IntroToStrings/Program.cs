// See https://aka.ms/new-console-template for more information
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

System.Console.WriteLine(word.Length);

