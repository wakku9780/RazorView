using Microsoft.AspNetCore.Mvc;

namespace scratch.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            ViewBag.data5 = "tension";
            ViewBag.data6 = new List<string>()
            {
                "cricket","hockey","football"
            };















            ViewData["data1"] = "program";
            ViewData["data2"] = "waqar";

            ViewData["data3"] = DateTime.Now.ToLongDateString();

            string[] arr = { "waqar", "hashim", "mp" };
            ViewData["data4"] = arr;

              

            return View();
        }

        public IActionResult About() {
            return View();
                }

        public string  Details()
        {
            return "this is waqar";
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}






