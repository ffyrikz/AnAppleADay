using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace testMVC.Controllers;

public class HelloController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome?name=1234&numTimes=2234
    public IActionResult Welcome(string name, int ID = 1, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}