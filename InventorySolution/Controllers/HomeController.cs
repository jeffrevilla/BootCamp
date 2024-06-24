using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventorySolution.Models;
using InventorySolution.interfaces;
using InventorySolution.AppModels;

namespace InventorySolution.Controllers;

public class HomeController : Controller
{

    private readonly IInventoryRespiratory inventoryRespiratory;

    public HomeController(IInventoryRespiratory inventoryRespiratory){
        this.inventoryRespiratory = inventoryRespiratory;
    }

    public async Task<IActionResult> Index()
    {
        App app = new App();
        app.Products = await this.inventoryRespiratory.GetAllProducts();
        return View(app);
    }

    public IActionResult EditScreen()
    {
        App app = new App();
        return View(app);
    }

    [HttpPost, ActionName("Save")]
    public async Task<IActionResult> Save(Product NewProduct)
    {
        await this.inventoryRespiratory.AddProduct(NewProduct);

        return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> Delete(int id)
    {
        await this.inventoryRespiratory.DeleteProduct(id);

        return RedirectToAction("Index");
    }
}