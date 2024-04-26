class Thing
{
    //Scopes are a way to measure a range of visiblity/existence or a particular entity/vsriable.

    //Object Scope - exists wtihin any object of this class. (no static in title- )
    //Each Object gets its own copy of this variable with its own value
    public int objectNum = 100; //when created like this 

    //Class Scope - belngs to the entire Class, ad by extensn, each Object of the Class... (has static in title)
    //The value of the Class Scoped variable remains teh same between each Object
    public static int classNum = 10;
    public static int count = 0;
    public Thing()
    {
        objectNum = 100;
        count++;
    }
     
     //Staticmethodscan not use non static members( felds or methods)
     public static void StaticMethod()
    {
        System.Console.WriteLine("This is a static method from the Thing Class1");
    }
    public void SomeMethod(int paraNum)
    {
        int methodNum = 10;
        //paramenters and varialbles created within a method can be used so long as you are still in that metod 
        System.Console.WriteLine(paraNum);
        System.Console.WriteLine(methodNum);

        //Can still access the object class scoped vvariables 
        System.Console.WriteLine(Thing.classNum);
        System.Console.WriteLine(objectNum);
    }
  
    //Method Scope - any variables we create (declare) inside that method or 
    //and parameter used by that method is 'scoped' to that method. 
    //will no be used after the Method is finished running. 
//*****Need to compare to his when pushed***********

    //Blocked Scope - any variable created with in a *block* of code
    //can only 


//*****Need to compare to his when pushed***********


//Cannot use the block scoped variable 


}


