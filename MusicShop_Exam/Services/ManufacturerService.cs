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
    public class ManufacturerService : IManufacturerService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public ManufacturerService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public ManufacturerDTO CreateNewMnufaturer(ManufacturerDTO manufacturer)
        {
            var tmp = new Manufacturer
            {
                Name = manufacturer.Name,
                Guitars = new List<Guitar>()
            };

            this.uow.ManufacturersRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<ManufacturerDTO>(tmp);
        }

        public IEnumerable<ManufacturerDTO> GetAllMnufaturers()
        {
            var mf = this.uow.ManufacturersRepository.GetAll();

            return mf.Select((m) => new ManufacturerDTO
            {
                Id = m.Id,
                CreatedAt = m.CreatedAt,
                Name = m.Name,
                Guitars = mapper.Map<ICollection<GuitarDTO>>(m.Guitars)
            }).ToList();
        }

        public ManufacturerDTO GetMnufaturerById(int id)
        {
            var mf = this.uow.ManufacturersRepository.Get(id);

            return new ManufacturerDTO
            {
                Id = mf.Id,
                CreatedAt = mf.CreatedAt,
                Name = mf.Name,
                Guitars = mapper.Map<ICollection<GuitarDTO>>(mf.Guitars)
            };
        }

        public void RemoveMnufaturerById(int id)
        {
            this.uow.ManufacturersRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public ManufacturerDTO UpdateMnufaturer(ManufacturerDTO manufacturer)
        {
            var tmp = new Manufacturer
            {
                Id = manufacturer.Id,
                Name = manufacturer.Name,
                CreatedAt = manufacturer.CreatedAt,
                Guitars = mapper.Map<ICollection<Guitar>>(manufacturer.Guitars)
            };

            this.uow.ManufacturersRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<ManufacturerDTO>(tmp);
        }
    }
}
