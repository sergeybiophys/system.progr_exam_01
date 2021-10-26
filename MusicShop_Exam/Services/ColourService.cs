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
    public class ColourService : IColourService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public ColourService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public ColourDTO CreateNewColour(ColourDTO colour)
        {
            var tmp = new Colour
            {
                Name = colour.Name,
            };

            this.uow.ColoursRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<ColourDTO>(tmp);
        }

        public IEnumerable<ColourDTO> GetAllColours()
        {
            var colours = this.uow.ColoursRepository.GetAll();
            return colours.Select((c) => new ColourDTO
            {
                Id = c.Id,
                CreatedAt = c.CreatedAt,
                Name = c.Name
            }).ToList();
        }

        public ColourDTO GetColourById(int id)
        {
            var colour = this.uow.CategoriesRepository.Get(id);
            return new ColourDTO
            {
                Id = colour.Id,
                CreatedAt = colour.CreatedAt,
                Name = colour.Name
            };
        }

        public void RemoveColourById(int id)
        {
            this.uow.ColoursRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public ColourDTO UpdateColour(ColourDTO colour)
        {
            var tmp = new Colour
            {
                Id = colour.Id,
                CreatedAt = colour.CreatedAt,
                Name = colour.Name
            };

            this.uow.ColoursRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<ColourDTO>(tmp);
        }
    }
}
