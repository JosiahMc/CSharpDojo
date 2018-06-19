using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dur.Models;

namespace Dur.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
        
            return View();
        }

        [HttpGet]
        [Route("about/{User}")]
        //jerome will do this part
        public IActionResult About(string User)
        {
            ViewData["Message"] = User;
        //jerome will do this part
            return View();
        }
        //jerome will do this part
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View("Contact");
        }
        //jerome will do this part
        public IActionResult Privacy()
        {
            return View();
        }
        //jerome will do this part
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}