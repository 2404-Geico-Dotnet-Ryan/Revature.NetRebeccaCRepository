namespace EFCoreExample.Models
{

    // Entity framework requires us to create entities
    // These entities are essential class based representations of our data in our database

    // This file is holding our one to one relationships
    // It does not need to all be in the same file
    // This is done as another way to organize your code, it is all in the same namespace so it doesn't matter what files they are in
    public class User
    {
        public int UserId {get;set;}
        public string Name {get;set;}

        // This establishes a one-to-one relationship to the other entity
        // By creating a dependency within it
        public Profile Profile {get;set;}
    }

    public class Profile
    {
        public int ProfileId {get;set;}
        public string Bio {get;set;}

        // As profile contains the foreign key for User
        // We need to provide a field for the key inside the profile class
        public int UserId {get;set;}

        // This establishes a one-to-one relationship to the other entity
        // By creating a dependency within it
        public User User {get;set;}
    }
}