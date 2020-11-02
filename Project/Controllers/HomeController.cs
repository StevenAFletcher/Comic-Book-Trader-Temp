using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(AddUser i)
        {
            if (ModelState.IsValid)
            {
                return View("MyAccount", i);
            }
            else
            {
                return View();
            }

        }
        [HttpGetAttribute ]
        public IActionResult EditAccount()
        {
            AddUser j = new AddUser();
            j.UserName = "Steven" ;
            j.FirstName = "Steven";
            j.LastName = "Flether";
            j.Location = "Here";
            j.Password = "Password";
            j.EmailAddress = "steven.fletcher@example.com";
            return View(j);
        }   

        
        
        

        [HttpPostAttribute]
        public IActionResult EditAccount(AddUser i)
        {
            return View("MyAccount");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Browse()
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
