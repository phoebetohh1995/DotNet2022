using Microsoft.AspNetCore.Mvc;
using EmptyWebApp.Models;

namespace EmptyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Waffle()
        {
            Toppings toppings = new Toppings();
            toppings.Syrup = "Maple";
            toppings.Sprinkles = "Choco chips";

            return View(toppings);
        }
        public string Rice()
        {
            return "Steaming hot rice";
        }
    }
}
