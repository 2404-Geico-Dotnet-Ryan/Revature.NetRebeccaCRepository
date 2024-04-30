using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator.Add(4,5));
        System.Console.WriteLine(Calculator.Add(4,5,6));
        System.Console.WriteLine(Calculator.Add(4.2, 5.3));
        System.Console.WriteLine(Calculator.Add("123","45.678"));
        System.Console.WriteLine(Calculator.Add("123",45.678));
        System.Console.WriteLine();
        int[] numbers =[1,2,3];
        System.Console.WriteLine(Calculator.Add(numbers));

        //System.Console.WriteLine(Calculator.Add([1,2,3,4,5]));
        System.Console.WriteLine(Calculator.Add (2.5));
        System.Console.WriteLine(Calculator.Add (2.5, 3.5)); //will call the established method will exhaust those before running the params array)
        System.Console.WriteLine(Calculator.Add (2.5, 3.6, 7.596)); //will call parameter array as there is not one for 3 with a double
        System.Console.WriteLine(Calculator.Add (2.5, 3.6, 7.596, 5, 8, 9));
        System.Console.WriteLine(Calculator.Add (2.5, 3.6, 7.596, 5.2, 5));
        System.Console.WriteLine(Calculator.Add (5,6,7)); //calls 3 int array 
    }

    public static OverrideEX()
    {
        Parent p =new();
        p.JobTitle ="Trainer";
        p.Work();

        System.Console.WriteLine("Introducing Child");
        Child c=new();
        c.JobTitle = "Student";
        c.FavoriteGame = "MineCraft";
        c.Play();
        c.Work();

        System.Console.WriteLine("Introducing GrandChild");
        GrandChild g=new();
        c.FavoriteGame = "Shapes";
        c.JobTitle = "Baby";
        c.Play
        C.work



        //Back to parent
        System.Console.WriteLine(p.ToString());
        System.Console.WriteLine(c);
        System.Console.WriteLine(g);



        //(somewhat - Bonus Knowledge: ---Turn back now!! ---Save Yourself!

        Parent p2 = new();
        Parent p3 = p2;

        Parent pc = new Child();  //parent features(qualities) that implement like the child class(behave like a child) 
        pc.JobTitle = "";
        pc.Work(); //this prints out child class work method

        //pc = new Parent(); can reassign back to parent but if you did child you can't go backwards
        //Child C2 = new Parent(); Can't do parent does not have enough infomration

        //slight detour - Casting
        int num1 = (int) 2.5;  //this turns it into a int and prints 2
        System.Console.WriteLine(num1);

        //Child c2 = (Child) p; //casting parent into child
        //c2.Work(); //casting error --it will not have all properities 

        Child c2 = (Child)pc; //can do all because all child objeccts in memory Parent acting like a child 
        c2.Work="";
        c2.JobTitle="Pain in the butt";
        c2.FavoriteGame= "Fortnite";
        c2.Play();



    }
}