using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Final_Project.Models;

//Test 
namespace Final_Project.Areas.Admin.Controllers
{

    [Area("Admin")]
    
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

}
}

