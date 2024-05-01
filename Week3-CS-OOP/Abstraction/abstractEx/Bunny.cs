class Bunny : Animal, IHerbivores
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