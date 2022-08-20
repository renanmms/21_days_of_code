using Microsoft.AspNetCore.Mvc;

namespace _21_days_of_code.Controllers;

public class Error404Controller : Controller
{
    public IActionResult Index(){
        return View();
    }
}