using Microsoft.AspNetCore.Mvc;
using MusicShop_Exam.Models.Manufacturer;
using MusicShop_Exam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Controllers
{
    public class ManufacturerController : Controller
    {
        readonly IWebManufacturerService manufacturerService;
        //readonly IWebGuitarService guitarService;
        public ManufacturerController(IWebManufacturerService webManufacturer)
        {
            manufacturerService = webManufacturer;
        }

        public IActionResult Index()
        {
            var m = manufacturerService.GetAll();
            return View(new ManufacturerIndexViewModel
            {
                Manufacturers = this.manufacturerService.GetAll()
            }) ;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ManufacturerViewModel manufacturer)
        {
            this.manufacturerService.Create(manufacturer);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || manufacturerService.GetById((int)id) is null)
            {
                return BadRequest("Manufacturer was not found");
            }
            manufacturerService.RemoveById((int)id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id is null || manufacturerService.GetById((int)id) is null)
            {
                return BadRequest("Manufacturer was not found");
            }
            return View(manufacturerService.GetById((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ManufacturerViewModel manufacturer)
        {
            if (manufacturerService.GetById((int)manufacturer.Id) is null)
            {
                return BadRequest("Manufacturer was not found");
            }
            manufacturerService.Update(manufacturer);
  
            return RedirectToAction("Index");
        }

        //public IActionResult ViewGuitars(int? id)
        //{
        //    if (id is null || categoryService.GetCategoryById((int)id) is null)
        //    {
        //        return BadRequest("Category was not found");
        //    }

        //    return View(new ProductIndexViewModel
        //    {
        //        Products = productsService.GetAllProducts().Where(p => p.CategoryId == id).ToList()
        //    });
        //}
    }
}
