class Building
{
    public int Walls { get; set; }
    public int Area { get; set; }

    public Building()
    {
        //For the sake of demo
        System.Console.WriteLine("Constructing a new Building");
    }

    public Building(int walls, int area)
    {
        Walls = walls;
        Area = area;
        System.Console.WriteLine("Constructing a new building with " + walls + " walls and " + area + " area.");
    }

    public override string ToString()
    {
        return "{walls:" + Walls + ",area:" + Area + "}";
    }

}