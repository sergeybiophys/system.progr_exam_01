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
    public class PickupService : IPickupService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public PickupService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public PickupDTO CreateNewPickup(PickupDTO pickup)
        {
            var tmp = new Pickup
            {
                Type = pickup.Type
            };

            this.uow.PickupRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<PickupDTO>(tmp);
        }

        public IEnumerable<PickupDTO> GetAllPickups()
        {
            var pickups = this.uow.PickupRepository.GetAll();
            return pickups.Select((t) => new PickupDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Type = t.Type
            }).ToList();
        }

        public PickupDTO GetPickupById(int id)
        {
            var f = this.uow.PickupRepository.Get(id);
            return new PickupDTO
            {
                Id = f.Id,
                CreatedAt = f.CreatedAt,
                Type = f.Type
            };
        }

        public void RemovePickupById(int id)
        {
            this.uow.PickupRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public PickupDTO UpdatePickup(PickupDTO pickup)
        {
            var tmp = new Pickup
            {
                Id = pickup.Id,
                CreatedAt = pickup.CreatedAt,
                Type = pickup.Type
            };


            this.uow.PickupRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<PickupDTO>(tmp);
        }
    }
}
