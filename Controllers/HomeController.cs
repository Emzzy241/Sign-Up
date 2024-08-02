using Microsoft.AspNetCore.Mvc;
using Sign_up.Models;

namespace Sign_up.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
