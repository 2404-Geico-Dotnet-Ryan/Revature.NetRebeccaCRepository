using System.ComponentModel;

class Child: Parent
{
    public string FavoriteGame {get;set;}

    public static Child()
    {
        FavoriteGame ="";
    }

    public  String Play()
    {
        System.Console.WriteLine(Child.FavoriteGame);
    }
}