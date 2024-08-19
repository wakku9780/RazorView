using Microsoft.AspNetCore.Mvc;

namespace scratch.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About() {
            return View();
                }

        public string  Details()
        {
            return "this is waqar";
        }
    }
}






