using _21_days_of_code.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21_days_of_code.Controllers;

public class CalculatorController : Controller
{
    public IActionResult Index(){
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(CalculatorInputModel model){
        return NoContent();
    }
}