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
    public class KindService : IKindService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public KindService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public KindDTO CreateNewKind(KindDTO kind)
        {
            var tmp = new Kind
            {
                Name = kind.Name,
            };

            this.uow.KindsRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<KindDTO>(tmp);
        }

        public IEnumerable<KindDTO> GetAllKinds()
        {
            var type = this.uow.KindsRepository.GetAll();

            return type.Select((k) => new KindDTO
            {
                Id = k.Id,
                CreatedAt = k.CreatedAt,
                Name = k.Name
            }).ToList();
        }

        public KindDTO GetKindById(int id)
        {
            var kind = this.uow.KindsRepository.Get(id);

            return new KindDTO
            {
                Id = kind.Id,
                CreatedAt = kind.CreatedAt,
                Name = kind.Name
            };
        }

        public void RemoveKindById(int id)
        {
            this.uow.KindsRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public KindDTO UpdateKind(KindDTO kind)
        {
            var tmp = new Kind
            {
                Id = kind.Id,
                CreatedAt = kind.CreatedAt,
                Name = kind.Name
            };

            this.uow.KindsRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<KindDTO>(tmp);
        }
    }
}
