interface ICarnivore
{
     int Value { get; set; }
     //Also assumes to be public.
    
    
    
    //public abstract void EatMeat(); //abstract portion is implied - also do not have to put public it is implied too
    void EatMeat(); //Acceptable assumed to be public and abstract 
}