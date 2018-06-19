using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFUN.Models;

namespace ViewModelFUN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string msg = "Coding is dope brah CHAD ITS WORKING IDIOT";
            return View("Index", msg);
        }
        [Route("about")]
        public IActionResult About()
        {

            int[] numbers = new int[5] {5, 8, 9, 10, 55};

            return View("About", numbers);
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            User newGuy = new User("Jay", "Money$");

            // AllUsers.Add(NewGuy)


            return View(newGuy);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
