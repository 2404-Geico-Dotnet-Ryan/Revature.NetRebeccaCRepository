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

    /* 
    Constructors - a special kind of method whose purpose is to help us create new objects of that class
    Along with any other initial set up instructions we wish to provide. 

    Syntax: *note no return type in syntax
    access_modifier ClassName (potetial parameters)
    [
         what you want the constructor to do while setting up your object. 
            -setting initial values is commom
    ]
    C# does provide a "default" constructor when you do not explicitly create any constuctors.That is a no arguement constructor    
    As soon as you create even ONE constructor, the default constructor is no longer provided. 
    */


    //No Argument constructor
    public Car()  
    {
        //sets defualt values
        color = "Please Update";
        year = 9999;
    }

    // You can have multiple constructors - the only requirement is that the parameters have to be some new unique co=mbination of typess. 
    //Overloaded Methods -> have multiple implementatios to the same named method - with different parameters

    /*public Car(string newColor)  //one arguement method
    {
       color = newColor; 
       System.Console.WriteLine(color);
    }
    This will print silver
    */  
    public Car(string color)  //one arguement method - this will change the default color to the new color provided
    {
       this.color = color; //this. indicates which object we are talking about car1 car2  overrides the default refers back to top lines of code
       System.Console.WriteLine(color);
    }

    //Multiple Arguement Constructor ->Full -Arg constructor
    //meaning a choice of us providing ALL the values for our fields
    public Car(string color, string make, string model, int year, int mileage)//these parameters only override the orginial in this method not outside the method
    {
        this.color = color;
        this.make = make;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }
//Bonus Copy Constructor
public Car (Car otherCar)
{
    color = otherCar.color;
    make = otherCar.make;
    model = otherCar.model;
    year = otherCar.year;
    mileage = otherCar.mileage;
}



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

    public string DisplayInfo()
    {
        string str = "";      //this can be done in one line of code 
        str += "{Color=" + color;
        str += "; Make=" + make;
        str += "; Model=" + model;
        str += "; Year=" + year;
        str += "; Mileage=" + mileage + "}";
       
       return str;
    }
    //This is similiar to above but it is not the same results (unless you override it)
    //They are plain because they are inherited 
    //They can be overwritten but can't do without putting override before it 
    //Override is a common practice in coding 
    public override string ToString()
    {
        string str = "";      //this can be done in one line of code 
        str += "{Color=\"" + color + "\"";
        str += "; Make= '" + make +  "'";
        str += "; Model= '" + model + "'";
        str += "; Year= '" + year + "'";
        str += "; Mileage= '" + mileage + "'" +  "}";
       
       return str;
    }
}