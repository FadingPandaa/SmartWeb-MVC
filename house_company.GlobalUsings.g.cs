using System.Diagnostics;
using house_company.Models;
using Microsoft.AspNetCore.Mvc;

namespace house_company.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Home/Index
        [HttpPost]
        public IActionResult Index(house_info model)
        {
            if (ModelState.IsValid)
            {
                //Prints details to console.
                Console.WriteLine($"House Type: {model.HouseType}");
                Console.WriteLine($"Location: {model.Location}");
            }

            //Returns the same view with model data.
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //This handles errors.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}