using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string filepath = "example.txt";
        //string desktopfile = "C:User/U713py/Desktop (see trainer example)
        //StreamWriter writer = new StreamWriter(filepath, true);  //overwrites any information in the file _clears the contents frist then writes
            //the addition of the word True makes it append to the file not overwrite it
        //writer.WriteLine("Hello, World!"); //writes to text file
        //writer.WriteLine("Becky was here!");
        ReadFromFile(filepath);

        //System.Console.WriteLine("Information written to file"); //writes to console (terminal App)

       // writer.Close(); //this makes sure it wraps up what it is doing and closes out this object -this resource finishes
        

            //another way to write the streamwriter)
        //using (StreamWriter writer = new StreamWriter(filepath, true))
            //NewMethod(writer);
    }

    public static void WriteToFile(StreamWriter writer)
    {
        writer.WriteLine("Hello, World!");
        writer.WriteLine("Becky was here!");

        System.Console.WriteLine("Information written to file");
    }

    public static void ReadFromFile(string filepath)
    {
        using (StreamReader reader= new (filepath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

        }  
    }
    //Pillars of OOP 
    // Inheritance - 
    //  encaspulation - 
    // Abstraction 
    // Polymorphism 

    //Inheritance is the concept in OOP in which one class inhertits the attributes and methods of another class. 
    //The calss whose properties and methods are the Parent (super) class. Child class gains them (inherits them) 
    /* 
    Single Inheritance one parent one child 
    Hierarchical Inheritance is one parent many child class
    Multilevel goes from one parent to one child to another child
    Multiple Inheritance (not in c sharp)
}

