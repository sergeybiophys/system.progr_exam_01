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
    public class StatusService : IStatusService
    {
        readonly IUnitOfWork uow;
        readonly IMapper mapper;
        public StatusService(IUnitOfWork uow,
                               IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        public StatusDTO CreateNewStatus(StatusDTO status)
        {
            var tmp = new Status
            {
                Name = status.Name
            };

            this.uow.StatusRepository.Create(tmp);
            this.uow.SaveChanges();

            return mapper.Map<StatusDTO>(tmp);
        }

        public IEnumerable<StatusDTO> GetAllStatuses()
        {
            var status = this.uow.StatusRepository.GetAll();
            return status.Select((t) => new StatusDTO
            {
                Id = t.Id,
                CreatedAt = t.CreatedAt,
                Name = t.Name
            }).ToList();
        }

        public StatusDTO GetStatusById(int id)
        {
            var f = this.uow.StatusRepository.Get(id);
            return new StatusDTO
            {
                Id = f.Id,
                CreatedAt = f.CreatedAt,
                Name = f.Name
            };
        }

        public void RemoveStatusById(int id)
        {
            this.uow.StatusRepository.Remove(id);
            this.uow.SaveChanges();
        }

        public StatusDTO UpdateStatus(StatusDTO staus)
        {
            var tmp = new Status
            {
                Id = staus.Id,
                CreatedAt = staus.CreatedAt,
                Name = staus.Name
            };


            this.uow.StatusRepository.Update(tmp);
            this.uow.SaveChanges();

            return mapper.Map<StatusDTO>(tmp);
        }
    }
}
