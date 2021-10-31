using Microsoft.AspNetCore.Mvc;
using MusicShop_Exam.Models.Guitar;
using MusicShop_Exam.Services.Guitar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Controllers
{
    public class GuitarController : Controller
    {
        readonly IWebGuitarService webGuitarService;

        public GuitarController(IWebGuitarService webGuitarService)
        {
            this.webGuitarService = webGuitarService;
        }



        public IActionResult Index()
        {
            var guitars = webGuitarService.GetAll();
            return View(new GuitarIndexViewModel
            {
                Guitars = this.webGuitarService.GetAll()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GuitarViewModel guitar)
        {

            this.webGuitarService.Create(guitar);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || webGuitarService.GetById((int)id) is null)
            {
                return BadRequest("Guitar was not found");
            }
            webGuitarService.RemoveById((int)id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            //ViewBag.categories = categoryService.GetAllCategory().ToList();

            if (id is null || webGuitarService.GetById((int)id) is null)
            {
                return BadRequest("Guitar was not found");
            }
            return View(webGuitarService.GetById((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GuitarViewModel guitar)
        {
            if (webGuitarService.GetById((int)guitar.Id) is null)
            {
                return BadRequest("Guitar was not found");
            }
            webGuitarService.Update(guitar);

            return RedirectToAction("Index");
        }

        //public IActionResult Detail(int? id)
        //{
        //    if (id is null || productsService.GetProductById((int)id) is null)
        //    {
        //        return BadRequest("Product was not found");
        //    }
        //    return View(productsService.GetProductById((int)id));
        //}

    }
}
