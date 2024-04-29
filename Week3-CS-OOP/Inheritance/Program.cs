﻿using System;

class Program
{
    static void Main(string[] args)
    {

        Building b1 = new();
        Building b2 = new(4, 1000);

        System.Console.WriteLine(b1);
        System.Console.WriteLine(b2);

        System.Console.WriteLine("Changing to House");
        //Zero Arguement
        House h1 = new();
        System.Console.WriteLine(h1);

        //What if I wanted to provide a number of walls and an area to my house?
        House h2 = new(6, 500);
        System.Console.WriteLine(h2);

        //Full arg constructor for House?
        House h3 = new(8, 750, 12, "Ryan");
        System.Console.WriteLine(h3);


    }
}