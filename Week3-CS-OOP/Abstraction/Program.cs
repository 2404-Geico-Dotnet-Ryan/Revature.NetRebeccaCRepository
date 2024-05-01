using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Starting on Dog.");
        //Animal a = new Animal();  can't do this - this abstract does not actually do anything can't create an object 
        Dog d = new Dog();
        d.MakeSound();
        d.Sleep();
        d.Species ="German Sheppard";
        d.FavoriteChewToy = "Bone";
        //d.EatMeat();
        d.Value = 100;
        System.Console.WriteLine(d.Value);
       
        System.Console.WriteLine("Starting on Cat.");
        Cat c = new Cat();
        c.MakeSound();
        c.Sleep();
        c.Species = "American Long Hair";
        c.EatMeat();
        c.Value = 101;
        c.Value = 102;
        System.Console.WriteLine(c.Value);
        System.Console.WriteLine("Starting Cat2");
        Cat c2 = new();
        System.Console.WriteLine(c2.Value);
        
        //c.FavoriteChewToy = "mouse trap";
        // Cats Class does not have a favorite chew toy 
        System.Console.WriteLine("Starting on Bunny");
        Bunny bugs =new();
        bugs.MakeSound();
        bugs.Sleep();
        ///bugs.EatPlant(); wont work right now-- Trainer could not get it to work either
        ///
        IHerbivores b = new Bunny();
        b.EatPlant();

        





    }
}
