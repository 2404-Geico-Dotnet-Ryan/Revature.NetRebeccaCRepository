namespace EFCoreExample.Models
{
    //Entity Framework requires us to create entities 
    //
    
    
    
    //This file is holding our one to one relationships 
    //It does not need to all be in same file 
    //this is done as anohter way to organize your code, it is all inthe same namespace so it does not really matter what file they are in
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        //this establishes a one to one relationship to the other entity
        //By creating a dependency within it 
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }
        // as profile contains the foriegn key for the user
        //we need to provide a field for the key inside the profile class
        public int UserId { get; set; }
        // this establishes a one to one relationship to the other entity 
        //by creating a dependency within it 
    
        public User User { get; set; }
    }

       
}