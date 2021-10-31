using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Controllers
{
    public class GuitarTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
