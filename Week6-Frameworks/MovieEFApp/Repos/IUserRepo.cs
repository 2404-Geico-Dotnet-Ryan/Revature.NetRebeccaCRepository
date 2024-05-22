/* 
    Coding to interfaces 
    Practice in which we will start theses "classes" that are functionality focused
    (repo, serv, contollers, etc.)
    we will opt to outline their functionality through an interface first 

    The overall goal is to promote flexibiity or resusablity  if we ever need to change
    implementations you can simple create a new class that implements the SAME Interface 
    therby letting us know it will service all the same INTENTIONS. 


*/
interface IUserRepo
{
    public abstract void AddUser(User u); //techinically do not need abstract in the method as it is a default
      public User? GetUser(int id);
    public List<User> GetAllUser();
    public void UpdateUser (User U);
    public void DeleteUser (int id);
    public void Save(); 


}