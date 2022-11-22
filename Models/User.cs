using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;
namespace Final_Project.Models;
public class User
{

    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Desc { get; set; } //This information about themselves will be store here 
    public ICollection<Hobby> Hobbies { get; set; }

}