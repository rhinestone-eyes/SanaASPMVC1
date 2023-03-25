using HelloName.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MvcMovie.Controllers;

public class HelloNameController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Greetings(helloName userName)
    {
        return View(userName);
    }
}