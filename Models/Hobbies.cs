namespace Final_Project.Models;
public class Hobby 
{
    //This model will be about basic information about the hobby; this will be the table in the datbase
    //Not sure if I should hardcode the hobby or get the information of a hobby in the database
    public int HobbyId {get;set;}
    public string Name {get;set;}
    public string Desc{get;set;} //? means nullable 

    public int UserId {get;set;}
    // Add a foriegn key to a user table --> user table will hold information about the person who is assoicted by the hobby; as well contain password and username -- maybe





}