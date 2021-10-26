using AutoMapper;
using Domain.Entity;
using Domain.Repository;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GuitarService : IGuitarService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public GuitarService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public GuitarDTO CreateNewGuitar(GuitarDTO guitar)
        {
            var tmp = new Guitar
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
            };

            this.uow.GuitarsRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<GuitarDTO>(tmp);
        }

        public IEnumerable<GuitarDTO> GetAllGuitars()
        {
            var guitars = this.uow.GuitarsRepository.GetAll();
            return guitars.Select((g) => new GuitarDTO
            {
                Id = g.Id,
                CreatedAt = g.CreatedAt,
                Name = g.Name,
                Price = g.Price,
                Quantity = g.Quantity,
                Image = g.Image,
                CategoryId = g.CategoryId,
                ManufacturerId = g.ManufacturerId,
                ColourId = g.ColourId,
                GuitarTypeId = g.GuitarTypeId,
                KindId = g.KindId,
                NumberOfFretsId = g.NumberOfFretsId,
                NumberOfStringId = g.NumberOfStringId,
                PickupId = g.PickupId,
                SizeId = g.SizeId,
                Status = g.Status

            }).ToList();
        }

        public GuitarDTO GetGuitarById(int id)
        {
            var g = this.uow.GuitarsRepository.Get(id);
            return new GuitarDTO
            {
                Id = g.Id,
                CreatedAt = g.CreatedAt,
                Name = g.Name,
                Price = g.Price,
                Quantity = g.Quantity,
                Image = g.Image,
                CategoryId = g.CategoryId,
                ManufacturerId = g.ManufacturerId,
                ColourId = g.ColourId,
                GuitarTypeId = g.GuitarTypeId,
                KindId = g.KindId,
                NumberOfFretsId = g.NumberOfFretsId,
                NumberOfStringId = g.NumberOfStringId,
                PickupId = g.PickupId,
                SizeId = g.SizeId,
                Status = g.Status
            };
        }

        public void RemoveGuitarById(int id)
        {
            this.uow.GuitarsRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public GuitarDTO UpdateGuitar(GuitarDTO guitar)
        {
            var tmp = new Guitar
            {
                Id = guitar.Id,
                CreatedAt = guitar.CreatedAt,
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

            this.uow.GuitarsRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<GuitarDTO>(tmp);
        }
    }
}
