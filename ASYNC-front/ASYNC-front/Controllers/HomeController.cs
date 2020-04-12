using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_front.Properties.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASYNC_front.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Test test)
        {
            return View(test);
        }
    }
}