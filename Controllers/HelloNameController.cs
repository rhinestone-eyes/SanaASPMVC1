using HelloName.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MvcMovie.Controllers;

public class HelloNameController : Controller
{
    private readonly ILogger<HelloNameController> _logger;

    public HelloNameController(ILogger<HelloNameController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Greetings(helloName _name)
    {
        return View(_name);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}