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
    public class SizeService : ISizeService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public SizeService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public SizeDTO CreateNewSize(SizeDTO size)
        {
            var tmp = new Size
            {
                InstrumentSize = size.InstrumentSize
            };

            this.uow.SizeRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<SizeDTO>(tmp);
        }

        public IEnumerable<SizeDTO> GetAllSizes()
        {
            var sizes = this.uow.SizeRepository.GetAll();
            return sizes.Select((t) => new SizeDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                InstrumentSize = t.InstrumentSize
            }).ToList();
        }

        public SizeDTO GetSizeById(int id)
        {
            var f = this.uow.SizeRepository.Get(id);
            return new SizeDTO
            {
                Id = f.Id,
                CreatedAt = f.CreatedAt,
                InstrumentSize = f.InstrumentSize
            };
        }

        public void RemoveSizeById(int id)
        {
            this.uow.SizeRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public SizeDTO UpdateSize(SizeDTO size)
        {
            var tmp = new Size
            {
                Id = size.Id,
                CreatedAt = size.CreatedAt,
                InstrumentSize = size.InstrumentSize
            };


            this.uow.SizeRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<SizeDTO>(tmp);
        }
    }
}
