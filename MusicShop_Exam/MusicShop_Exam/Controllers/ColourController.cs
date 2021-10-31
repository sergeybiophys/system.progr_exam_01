using Microsoft.AspNetCore.Mvc;
using MusicShop_Exam.Models.Colour;
using MusicShop_Exam.Services.Colour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Controllers
{
    public class ColourController : Controller 
    {
        readonly IWebColourService colourService;
        public ColourController(IWebColourService webColour)
        {
            colourService = webColour;
        }

        public IActionResult Index()
        {
            var m = colourService.GetAll();
            return View(new ColourIndexViewModel
            {
                Colours = this.colourService.GetAll()
            });
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ColourViewModel colour)
        {
            this.colourService.Create(colour);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || colourService.GetById((int)id) is null)
            {
                return BadRequest("Colour was not found");
            }
            colourService.RemoveById((int)id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || colourService.GetById((int)id) is null)
            {
                return BadRequest("Colour was not found");
            }
            return View(colourService.GetById((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ColourViewModel colour)
        {
            if (colourService.GetById((int)colour.Id) is null)
            {
                return BadRequest("Colour was not found");
            }
            colourService.Update(colour);

            return RedirectToAction("Index");
        }
    }
}
