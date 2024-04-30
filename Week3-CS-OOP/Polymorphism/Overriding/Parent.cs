class Parent
{
    public string JobTitle{get; set;}

       public static Parent()
        {
            JobTitle = "";
        }

        public Parent(string JobTitle)
        {
            System.Console.WriteLine(Parent.JobTitle);
        }

    public 
}