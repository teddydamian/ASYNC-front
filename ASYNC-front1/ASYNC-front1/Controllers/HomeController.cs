using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_front1.Models;
using ASYNC_front1.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASYNC_front1.Controllers
{
    

    public class HomeController : Controller
    {
        private IHotelManager _hotel;

        public HomeController(IHotelManager hotel)
        {
            _hotel = hotel;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _hotel.GetAllHotels();
            return View(result);
        }

    }
}