class Dog : Animal, ICarnivore
{
    public string FavoriteChewToy {get;set;}
    public int Value {get; set;}

    public Dog()
    {
        FavoriteChewToy = "";
    }
    public override void MakeSound()  // this is blank method in Base Animals MUST MAKE
    {
        System.Console.WriteLine("Woof! Woof! Bark! Bark!");
    }

    
    public void EatMeat()
    {
        System.Console.WriteLine("Eats some puppy chow.");
    }

    /*    void ICarnivore.EatMeat()
    {
        System.Console.WriteLine("Eats some puppy chow.");
    }
    */
}