// Things to do - google some practice questions on Chat GPT etc something like below
//Takes in two strings and prints both of them twice
//Find the largest number between 3 ints


//assignment practice methods 

using System;

    class PracticingMethods
    {
        public static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            System.Console.WriteLine(dog1);

            dog1.color = "Brown";
            dog1.breed = "PitBull";
            dog1.lengthOfHair = "Short";
            dog1.age = 5;
            dog1.steps = 75;
            dog1.numberOfLegs = 3;
            System.Console.WriteLine("Dog 1: " + dog1.lengthOfHair);

            Dog dog2 = new Dog();
            System.Console.WriteLine(dog1);

            dog2.color = "Red and White";
            dog2.breed = "Pointer";
            dog2.lengthOfHair = "Long";
            dog2.age = 20;
            dog2.steps = 50;
            dog2.numberOfLegs = 4;
            System.Console.WriteLine("Dog 2: " +dog2.lengthOfHair);

            Dog dog3=new();

            Dog dog4 = new("White", "GreatDane", "Short", 10, 500, 4);


            dog1.Bark();
            dog1.NewSteps(50);

            System.Console.WriteLine("Dog 1 information: " +dog1);
            System.Console.WriteLine("Dog 2 information: "+ dog2);

             
            string reverse ="Revature";
            foreach (char c in reverse)
            {
                reverse = c + reverse;
            }
            System.Console.WriteLine(reverse);

            //need to work on print out of this
            int[] array= [1,2,3,4,5];
            System.Console.WriteLine(array);
            Array.Reverse(array);
            System.Console.WriteLine(array);
        }
    }