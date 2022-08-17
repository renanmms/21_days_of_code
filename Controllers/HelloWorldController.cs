using Microsoft.AspNetCore.Mvc;

namespace _21_days_of_code.Controllers;

public class HelloWorldController :  Controller
{
    public IActionResult Index(){
        return View();
    }
}