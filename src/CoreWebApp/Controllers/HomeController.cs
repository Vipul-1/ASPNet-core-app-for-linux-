using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Message"] = RuntimeInformation.OSDescription + " " + RuntimeInformation.OSArchitecture.ToString();
            return View();
        }

        public IActionResult About()
        {
            
             ViewData["Message"] = RuntimeInformation.OSDescription + " " + RuntimeInformation.OSArchitecture.ToString();
             return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
