class Dog
{
    public string? breed;
    public string? color;
    public string? lengthOfHair;
    public int age;
    public int numberOfLegs;
    public int steps;


    //no arguement constructor (can set default values)
    public Dog()
    {

    }
    //Full-Arguement Constructor
    public Dog(string breed, string color, string lengthOfHair, int age, int steps, int numberOfLegs)
    {
        this.breed = breed;
        this.color = color;
        this.lengthOfHair = lengthOfHair;
        this.age = age;
        this.numberOfLegs = numberOfLegs;
    }
    //METHODS
    public void Bark()    
    {
       System.Console.WriteLine("Whoof, whoof!"); 
    }

    /*public void walk(int steps)
    {
        steps += walk;
        System.Console.WriteLine("The new total milage is: " + walk);
    }*/

}