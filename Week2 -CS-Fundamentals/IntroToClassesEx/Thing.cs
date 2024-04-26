class Thing
{
    //Scopes are a way to measure a range of visiblity/existence or a particular entity/vsriable.

    //Object Scope - exists wtihin any object of this class.
    //Each Object gets its own copy of this variable with its own value
    public int objectNum = 100; //when created like this 

    //Clas Scope - belngs to the entire Class, ad by extensn, each Object of the Class... 
    //The value of the Class Scoped variable remains teh same between each Object
    public static int classNum = 10;
    public static int count = 0;
    public Thing()
    {
        objectNum = 100;
        count++;
    }
     public static void StaticMethod()
    {
        System.Console.WriteLine("This is a static method from the Thing Class1");
    }
    

}