using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Update.Internal;
/* Make sure this are added to your project
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
*/
class Program
{
    static IUserRepo ur;

    static void Main(string[] args)
    {
        //testing out LINQ and Lambda
        //LambdaTest(); // this has nothing to do with our moivie project
        using MovieEFAppDBContext context =new();
        ur = new UserRepo(context);
        /*
        //Creating a new user 
        User newUser = new User(0,"CaptainAmerica", "WinterSoldier", "user");
        ur.AddUser(newUser);
        ur.Save();
        System.Console.WriteLine("User added successfully!");
         // this worked just commenting out so that it does not try to continue to run
        */
        //get (retrieve)
        User? u = ur.GetUser(1);
        if (u != null)
        {
            System.Console.WriteLine(u);
        }
        else
        {
            System.Console.WriteLine("User not found!");
        }

        //Updateuser
        u.Password = "pass123";
        ur.UpdateUser(u);
        ur.Save();
        System.Console.WriteLine(ur.GetUser(1));

        //DeleteUser
        ur.DeleteUser(1);
        ur.Save();
        

        //check that user 1 is not in All user 
        List<User> allUsers =ur.GetAllUser();
        List<User> allUserWithId1= allUsers.Where(user => user.Id ==1).ToList();
        System.Console.WriteLine(allUserWithId1.Count == 0);

    }

   


    public static void LambdaTest() //this has nothing to do with our movie project 
    {
        List<int> numbers = [9,10,1,2,3,4,5,6,7,8,];
        List<string> words = ["hello", "hi", "hye", "bye"];

        List<int> evenNumbers = numbers.Where(num => num %2 ==0).ToList();
        var hWords = words.Where(word => word.Substring(0,1) == "h");
        /*this is the old way
        foreach (int num in evenNumbers)
        {
            System.Console.WriteLine(num);
        }
        foreach (string word in hWords)
        {
            System.Console.WriteLine(word);
        }
        */
        numbers.ForEach(num => System.Console.WriteLine(num));
        evenNumbers.ForEach(num => System.Console.WriteLine(num));
        System.Console.WriteLine("///////////////////////");
        evenNumbers = evenNumbers.OrderBy(x => x).ToList();// this one is stating using number as is
        evenNumbers.ForEach(num => System.Console.WriteLine(num));
    }
}
