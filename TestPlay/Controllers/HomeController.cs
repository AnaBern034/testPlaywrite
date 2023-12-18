using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestPlay.Models;

namespace TestPlay.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        OwnerUserModel userModel = new OwnerUserModel("Ana");
        return View(userModel);
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
