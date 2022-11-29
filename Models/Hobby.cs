using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Models;
public class Hobby
{
    //This model will be about basic information about the hobby; this will be the table in the datbase
    //Not sure if I should hardcode the hobby or get the information of a hobby in the database
    public int HobbyID { get; set; }
    public string HobbyName { get; set; }
    public string Desc { get; set; } //? means nullable; desc of hobby


    // Add a foriegn key to the admin table --> admin table will hold information about the person who is assoicted by the hobby;
    public ICollection<AdminHobby> AdminHobbies { get; set; }

}