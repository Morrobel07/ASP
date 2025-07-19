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
    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (ModelState.IsValid)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        else
        {
            return View(guestResponse);
        }

    }

    public ViewResult ListResponses()
    {
        return View(Repository.ResponsesList.Where(r => r.WillAttend == true));
    }
}




