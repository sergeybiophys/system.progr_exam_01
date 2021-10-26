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
    public class NumFretsService : INumOfFretsService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public NumFretsService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public NumberOfFretsDTO CreateNewFret(NumberOfFretsDTO frets)
        {
            var tmp = new NumberOfFrets
            {
                Number = frets.Number
            };

            this.uow.FretsRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<NumberOfFretsDTO>(tmp);
        }

        public IEnumerable<NumberOfFretsDTO> GetAllFrets()
        {
            var frets = this.uow.FretsRepository.GetAll();
            return frets.Select((t) => new NumberOfFretsDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Number = t.Number
            }).ToList();
        }

        public NumberOfFretsDTO GetFretById(int id)
        {
            var f = this.uow.FretsRepository.Get(id);
            return new NumberOfFretsDTO
            {
                Id = f.Id,
                CreatedAt = f.CreatedAt,
                Number = f.Number
            };
        }

        public void RemoveFretById(int id)
        {
            this.uow.FretsRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public NumberOfFretsDTO UpdateFret(NumberOfFretsDTO frets)
        {
            var tmp = new NumberOfFrets
            {
                Id = frets.Id,
                CreatedAt = frets.CreatedAt,
                Number = frets.Number
            };

            this.uow.FretsRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<NumberOfFretsDTO>(tmp);
        }
    }
}
