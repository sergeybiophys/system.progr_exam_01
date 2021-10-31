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
        readonly IWebServiceManager webServiceManager;
        public HomeController(ILogger<HomeController> logger,
                              IWebServiceManager webServiceManager)
        {
            _logger = logger;
            this.webServiceManager = webServiceManager;

        }

        public IActionResult Index()
        {

            ViewBag.manufs = webServiceManager.webManufacturerService.GetAll().ToList();
            ViewBag.colours = webServiceManager.webColourService.GetAll().ToList();

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
