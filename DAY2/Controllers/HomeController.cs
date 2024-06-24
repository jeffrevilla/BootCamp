using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY2.Models;

namespace DAY2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Name FullName = new Name(){
            FirstName = "Jeffre",
            MiddleName = "Aquino",
            LastName = "Villa",
            Age = 22
        };
        return View(FullName);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
