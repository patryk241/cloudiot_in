using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Web.Models;

namespace ChatApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private const string SessionKey = "USER_SESSION";

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SignIn()
    {
        var login = HttpContext.Session.GetString(SessionKey);

        if (login != null)
        {
            return RedirectToAction("ChatApp");
        }

        
        var vm = new User();
        return View(vm);
    }

    [HttpPost]
    public IActionResult SignIn(User user)
    {
   
        if (!ModelState.IsValid)
        {
            return View(user);
        }

        HttpContext.Session.SetString(SessionKey, user.Login);
        return RedirectToAction("ChatApp");
    }

    [HttpGet]
    public IActionResult LogOut()
    {
        HttpContext.Session.Remove(SessionKey);
        return RedirectToAction("SignIn");
    }
    
    public IActionResult ChatApp()
    {
        var login = HttpContext.Session.GetString(SessionKey);

        if (login == null)
        {
            return RedirectToAction("SignIn");
        }

        var vm = new User()
        {
            Login = login
        };

        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}