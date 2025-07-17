using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Models;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();

    }

    public ViewResult RsvpForm()
    {
        return View();
    }
}
