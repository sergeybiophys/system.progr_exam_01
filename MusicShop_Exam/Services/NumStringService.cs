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
    public class NumStringService : INumOfStringsService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public NumStringService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        public NumberOfStringDTO CreateNewString(NumberOfStringDTO strings)
        {
            var tmp = new NumberOfString
            {
                Number = strings.Number
            };

            this.uow.StringsRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<NumberOfStringDTO>(tmp);
        }

        public IEnumerable<NumberOfStringDTO> GetAllStrings()
        {
            var strings = this.uow.StringsRepository.GetAll();
            return strings.Select((t) => new NumberOfStringDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Number = t.Number
            }).ToList();
        }

        public NumberOfStringDTO GetStringById(int id)
        {
            var f = this.uow.StringsRepository.Get(id);
            return new NumberOfStringDTO
            {
                Id = f.Id,
                CreatedAt = f.CreatedAt,
                Number = f.Number
            };
        }

        public void RemoveStringById(int id)
        {
            this.uow.StringsRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public NumberOfStringDTO UpdateString(NumberOfStringDTO strings)
        {
            var tmp = new NumberOfString
            {
                Id = strings.Id,
                CreatedAt = strings.CreatedAt,
                Number = strings.Number
            };

            this.uow.StringsRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<NumberOfStringDTO>(tmp);
        }
    }
}
