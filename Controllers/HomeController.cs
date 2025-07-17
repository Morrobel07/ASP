using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Models;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        int hours = DateTime.Now.Hour;
        String viewModel = hours < 12 ? "Good Morning" : hours < 18 ? "Good Afternoon" : "Good Evening";

        return View("MyView", viewModel);
    }
}
