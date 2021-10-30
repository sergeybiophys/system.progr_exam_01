using MusicShop_Exam.Models.Manufacturer;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services
{
    public class WebManufacturerService : IWebManufacturerService
    {
        readonly IServiceManager serviceManager;

        public WebManufacturerService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(ManufacturerViewModel manufacturer)
        {
            serviceManager.ManufacturerService.CreateNewManufacturer(new ManufacturerDTO
            {
                Name = manufacturer.Name
            });
        }

        public List<ManufacturerViewModel> GetAll()
        {
            var mnfs = serviceManager.ManufacturerService.GetAllManufacturers();
            return mnfs.Select((m) => new ManufacturerViewModel
            {
                Id = m.Id,
                Name = m.Name,
                Guitars = m.Guitars
            }).ToList();
        }

        public ManufacturerViewModel GetById(int id)
        {
            var m = serviceManager.ManufacturerService.GetManufacturerById(id);
            return new ManufacturerViewModel
            {
                Id = m.Id,
                Name = m.Name,
                Guitars = m.Guitars
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.ManufacturerService.RemoveManufacturerById(id);
        }

        public void Update(ManufacturerViewModel manufacturer)
        {
            serviceManager.ManufacturerService.UpdateManufacturer(new ManufacturerDTO
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                Guitars = manufacturer.Guitars
            });
        }
    }
}
