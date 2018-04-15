using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NOps.Models;

namespace NOps.Controllers
{
    public class HomeController : Controller
    {
        private readonly NOpsContext _dbContext;

        public HomeController(NOpsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            
            return View(_dbContext);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
