using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY3.Models;
using DAY3.Model;

namespace DAY3.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        Product product = new Product(
            00,
            "IPHONE",
            "BRANDNEW",
            "000",
            5,
            "12-01-0000"
        );
        return View(product);
    }

    public IActionResult Test(Product product){
        return RedirectToAction("Index");
    }
}
