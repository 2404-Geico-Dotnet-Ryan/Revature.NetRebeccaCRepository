namespace LoginAPI.DTOs;

/*
    DTO as what you expect to receive from the client and what you expect to return to the client
    Most of the time you are going to doing CRUD on your models, but sometimes your client might expect some kind of data
    that doesn't map 1-1 to a single model

    For example, if the user wants all of their information related to their profile data but you have to models for login data and profile data, you may create a DTO that combines the both of those models

    The service layer is there to essentially connect the two together, the DTO (Data Transfer Object) is just there to transfer data between the layers of your application
    It is designed to be very flexible, to suit the needs of your application
*/
public class UserDTO
{
    public string Username {get;set;}
    public string Password {get;set;}
    public string Email {get;set;}
}

public class UserLoginDTO
{
    public string Username {get;set;}
    public string Password {get;set;}
}

public class LoginResponseDTO
{
    public string Username {get;set;}
    public string Authorization {get;set;}
}