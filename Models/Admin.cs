using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;
namespace Final_Project.Models;
public class Admin
{

    public int AdminId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AboutId { get; set; } //This information about themselves will be store here; fk
    public ICollection<Hobby> Hobbies { get; set; }

}