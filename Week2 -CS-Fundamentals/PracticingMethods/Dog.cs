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
        this.steps = steps;
        this.age = age;
        this.numberOfLegs = numberOfLegs;
    }
    //METHODS
    public void Bark()    
    {
       System.Console.WriteLine("Whoof, whoof!"); 
    }

    public void NewSteps(int addedsteps)
    {
        addedsteps += steps;
        System.Console.WriteLine("The new total steps is: " + steps);
    }
   public override string ToString()
    {
        string str = "";  
        str += "{Breed= '" + breed + "'";  //"{Breed=\"" + breed + "\"";
        str += "; Color= '" + color +  "'";
        str += "; Lengeth of Hair= '" + lengthOfHair + "'";
        str += "; Age= '" + age + "'";
        str += "; Steps= '" + steps + "'";
        str += "; Number of Legs= '" + steps + "'" +  "}";
       
       return str;
    }
}