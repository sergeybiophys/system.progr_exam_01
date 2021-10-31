using MusicShop_Exam.Models.Guitar;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Guitar
{
    public class WebGuitarService : IWebGuitarService
    {
        readonly IServiceManager serviceManager;

        public WebGuitarService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public void Create(GuitarViewModel guitar)
        {
            serviceManager.GuitarService.CreateNewGuitar(new GuitarDTO
            {
                Name = guitar.Name,
                Price = guitar.Price,
                Quantity = guitar.Quantity,
                Image = guitar.Image,
                CategoryId = guitar.CategoryId,
                ManufacturerId = guitar.ManufacturerId,
                ColourId = guitar.ColourId,
                GuitarTypeId = guitar.GuitarTypeId,
                KindId = guitar.KindId,
                NumberOfFretsId = guitar.NumberOfFretsId,
                NumberOfStringId = guitar.NumberOfStringId,
                PickupId = guitar.PickupId,
                SizeId = guitar.SizeId,
                Status = guitar.Status
            });
        }

        public List<GuitarViewModel> GetAll()
        {
            var guitars = serviceManager.GuitarService.GetAllGuitars();
            return guitars.Select((guitar) => new GuitarViewModel
            {
                Id = guitar.Id,
                Name = guitar.Name,
                Price = guitar.Price,
                Quantity = guitar.Quantity,
                Image = guitar.Image,
                CategoryId = guitar.CategoryId,
                ManufacturerId = guitar.ManufacturerId,
                ColourId = guitar.ColourId,
                GuitarTypeId = guitar.GuitarTypeId,
                KindId = guitar.KindId,
                NumberOfFretsId = guitar.NumberOfFretsId,
                NumberOfStringId = guitar.NumberOfStringId,
                PickupId = guitar.PickupId,
                SizeId = guitar.SizeId,
                Status = guitar.Status
            }).ToList();
        }

        public GuitarViewModel GetById(int id)
        {
            var guitar = serviceManager.GuitarService.GetGuitarById(id);
            return new GuitarViewModel
            {
                Id = guitar.Id,
                Name = guitar.Name,
                Price = guitar.Price,
                Quantity = guitar.Quantity,
                Image = guitar.Image,
                CategoryId = guitar.CategoryId,
                ManufacturerId = guitar.ManufacturerId,
                ColourId = guitar.ColourId,
                GuitarTypeId = guitar.GuitarTypeId,
                KindId = guitar.KindId,
                NumberOfFretsId = guitar.NumberOfFretsId,
                NumberOfStringId = guitar.NumberOfStringId,
                PickupId = guitar.PickupId,
                SizeId = guitar.SizeId,
                Status = guitar.Status
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.GuitarService.RemoveGuitarById(id);
        }

        public void Update(GuitarViewModel guitar)
        {
            serviceManager.GuitarService.UpdateGuitar(new GuitarDTO
            {
                Id = guitar.Id,
                Name = guitar.Name,
                Price = guitar.Price,
                Quantity = guitar.Quantity,
                Image = guitar.Image,
                CategoryId = guitar.CategoryId,
                ManufacturerId = guitar.ManufacturerId,
                ColourId = guitar.ColourId,
                GuitarTypeId = guitar.GuitarTypeId,
                KindId = guitar.KindId,
                NumberOfFretsId = guitar.NumberOfFretsId,
                NumberOfStringId = guitar.NumberOfStringId,
                PickupId = guitar.PickupId,
                SizeId = guitar.SizeId,
                Status = guitar.Status
            });
        }
    }
}
