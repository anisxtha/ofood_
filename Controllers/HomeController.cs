using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using restraunt.Models;
using restraunt.Data;

namespace restraunt.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db=db;
    }

    public IActionResult Index()
    {
         IEnumerable<ProductModel> objcategory = _db.products;
        return View(objcategory);
    }

     

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Checkout()
    {
        return View();
    }
     
    public IActionResult Logged_index(){
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


