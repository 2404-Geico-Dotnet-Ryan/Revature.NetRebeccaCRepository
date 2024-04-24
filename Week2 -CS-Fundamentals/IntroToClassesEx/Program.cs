using System;

class Program
{
    static void Main(string[] args)
    {
        //int num = 1;
        //string word= "Hello";

        //Object Declaration and Instantiation (new instance of a class)(Intialization)
        Object obj1 = new Object();
        Object obj2 = new Object();
        Object obj3 = new(); //simplified version of same thing assumes Object will be the name
        
        DateTime currentTime = DateTime.Now;
        System.Console.WriteLine(currentTime);

        Car car1 = new Car();
        System.Console.WriteLine(car1); // Right now only prints car as it only prints the name of the class

        car1.color = "Blue";
        car1.make = "Chevy";
        car1.model = "1500";
        car1.year = 2017;

        System.Console.WriteLine(car1.color);
        System.Console.WriteLine(car1.year);
        System.Console.WriteLine(car1.mileage);//not set so defaults to 0 when run 

        System.Console.WriteLine("color: " + car1.color + ": Year:" + car1.year);
        System.Console.WriteLine(car1.color + car1.year);// not as pretty as above wont have spaces or anything

        car1.Honk(); //need the car to honk the car 
        car1.Drive(100);
        car1.Drive(100);

        //Tomorrow 
        //ToString Method
        //Copying Object references 
        //Properties 
        //Constructors 
        //Scopes (static keyword as well)
        //Access Modifiers

        //Inheritance
        //Polymorphism 
        
    }
}