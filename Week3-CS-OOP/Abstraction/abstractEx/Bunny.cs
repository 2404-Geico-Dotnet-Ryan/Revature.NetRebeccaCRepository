class Bunny : Animal, IHerbivores, IAdorable
{
    public override void MakeSound()
    {
        System.Console.WriteLine("whats up Doc?");
    }

    void EatPlants()
    {
      System.Console.WriteLine("This animal loves carrots!");  
    }
    
   
    
}