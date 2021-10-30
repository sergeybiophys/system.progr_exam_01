using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicShop_Exam.Models;
using MusicShop_Exam.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IWebManufacturerService manufacturerService;
        public HomeController(ILogger<HomeController> logger,
                              IWebManufacturerService manufacturerService)
        {
            _logger = logger;
            this.manufacturerService = manufacturerService;

        }

        public IActionResult Index()
        {

            ViewBag.manufs = manufacturerService.GetAll().ToList();
            
            return View();
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
