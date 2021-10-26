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
    public class GuitarTypeService : IGuitarTypeService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public GuitarTypeService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public GuitarTypeDTO CreateNewType(GuitarTypeDTO type)
        {
            var tmp = new GuitarType
            {
                Name = type.Name,
            };

            this.uow.TypeRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<GuitarTypeDTO>(tmp);
        }

        public IEnumerable<GuitarTypeDTO> GetAllTypes()
        {
            var type = this.uow.TypeRepository.GetAll();
            return type.Select((t) => new GuitarTypeDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Name = t.Name
            }).ToList();
        }

        public GuitarTypeDTO GetTypeById(int id)
        {
            var type = this.uow.TypeRepository.Get(id);
            return new GuitarTypeDTO
            {
                Id = type.Id,
                CreatedAt = type.CreatedAt,
                Name = type.Name
            };
        }

        public void RemoveTypeById(int id)
        {
            this.uow.TypeRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public GuitarTypeDTO UpdateType(GuitarTypeDTO type)
        {
            var tmp = new GuitarType
            {
                Id = type.Id,
                CreatedAt = type.CreatedAt,
                Name = type.Name
            };

            this.uow.TypeRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<GuitarTypeDTO>(tmp);
        }
    }
}
