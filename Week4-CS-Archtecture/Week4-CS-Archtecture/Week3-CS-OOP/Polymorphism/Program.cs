﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // OverloadEx();
        OverrideEx();
    }

    private static void OverloadEx()
    {
        System.Console.WriteLine(Calculator.Add(4, 5));
        System.Console.WriteLine(Calculator.Add(4, 5, 6));
        System.Console.WriteLine(Calculator.Add(4.2, 5.3));
        System.Console.WriteLine(Calculator.Add("123", "45.678"));
        System.Console.WriteLine(Calculator.Add("123", 45.678));
        System.Console.WriteLine(Calculator.Add(12.345, "678"));

        int[] numbers = [1, 2, 3];
        System.Console.WriteLine(Calculator.Add(numbers));
        // System.Console.WriteLine(Calculator.Add([1, 2, 3, 4, 5]));

        System.Console.WriteLine(Calculator.Add(2.5));
        System.Console.WriteLine(Calculator.Add(2.5, 3.6));
        System.Console.WriteLine(Calculator.Add(2.5, 3.6, 7.4));
        System.Console.WriteLine(Calculator.Add(2.5, 3.6, 7.5, 2.1, 1.9, 2, 0.2));
        System.Console.WriteLine(Calculator.Add(1, 2, 3));
        System.Console.WriteLine(Calculator.Add(1, 2, 3, 4, 5, 6, 7));
    }

    public static void OverrideEx()
    {
        Parent p = new();
        p.JobTitle = "Trainer";
        p.Work();

        System.Console.WriteLine("----------");
        Child c = new();
        c.JobTitle = "Student";
        c.FavoriteGame = "Minecraft";
        c.Play();
        c.Work();

        System.Console.WriteLine("----------");
        GrandChild g = new();
        g.FavoriteGame = "Shapes";
        g.JobTitle = "Senior Associate Whatever";
        g.Play();
        g.Work();

        //Back to Parent
        System.Console.WriteLine(p.ToString());
        System.Console.WriteLine(c);
        System.Console.WriteLine(g);

        //(Somewhat) Bonus Knowledge---turn back now!---Save Yourself!
        Parent p2 = new();
        Parent p3 = p2;

        Parent pc = new Child();
        pc.JobTitle = "";
        pc.Work();


        // Child c2 = new Parent();
        //Slight Detour - Casting
        int num1 = (int)2.5;
        System.Console.WriteLine(num1);
        // Child c2 = (Child)p; //Cast does not work bc 'p' can only work and have JobTitle.
        Child c2 = (Child)pc;
        c2.Work();
        c2.JobTitle = "Student";
        c2.FavoriteGame = "Fortnite";
        c2.Play();

    }
}