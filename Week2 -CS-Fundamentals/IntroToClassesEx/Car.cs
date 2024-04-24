class Car
{
    //fields
    public string? color;
    public string? make;
    public string? model;
    public int year;
    public int mileage;

/* this is an alternate way to do the above with public - it defaults to private and you need it public to call it to method in program. cs file
    public string GetColor()
    {
        return color;
    }
*/

    //Methods
    public void Honk()
    {
        System.Console.WriteLine("Honk, Honk1");
    }
    public void Drive(int miles)
    {
        mileage += miles;
        System.Console.WriteLine("The new total milage is: " + mileage);
    }
}