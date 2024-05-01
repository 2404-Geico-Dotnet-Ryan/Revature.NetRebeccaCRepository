abstract class Animal 
{
    public string Species {get; set;}

    public Animal()  //classes below this need this to have constructor to build their objects
    {
        Species = "";
    }

    /*
    Two Types of Methods you can make in an Abstract Class
        -Concrete Methods - These methods have an Implementation
    */
    public void Sleep()
    {
        System.Console.WriteLine("Animal rest to recover energy.");
    }

    /*
    Abstract Methods - These methods will not have an implementation. 
    Any Class (that is not also abstract) will have to provide said implementation
    */

    public abstract void MakeSound(); //you can add parameters or not - each class will then have to override this method and tell it what to do.




}