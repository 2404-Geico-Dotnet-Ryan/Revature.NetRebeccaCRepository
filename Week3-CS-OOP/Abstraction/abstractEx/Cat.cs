class Cat : Animal, ICarnivore 
{
    public int Value {get; set;}
   
    public override void Sleep()  
    {
        System.Console.WriteLine("Curls in fluff ball.");
    }
    
    
    
   public override void MakeSound()  // this is blank method in Base Animals MUST MAKE
    {
        System.Console.WriteLine("Meow! Meow! Hiss! Hiss!");
    }

    void EatMeat()
    {
        System.Console.WriteLine("Eats some Friskies.");
    }

    /*
    void ICarnivore.EatMeat()
    {
        System.Console.WriteLine("Eats some Friskies.");
    }
    */
}