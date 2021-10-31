using MusicShop_Exam.Models.Pickup;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Pickup
{
    public class WebPickupService : IWebPickupService
    {
        readonly IServiceManager serviceManager;

        public WebPickupService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(PickupViewModel pickup)
        {
            serviceManager.PickupService.CreateNewPickup(new PickupDTO
            {
                Type = pickup.Type
            });
        }

        public List<PickupViewModel> GetAll()
        {
            var pickups = serviceManager.PickupService.GetAllPickups();
            return pickups.Select((p) => new PickupViewModel
            {
                Id = p.Id,
                Type = p.Type

            }).ToList();
        }

        public PickupViewModel GetById(int id)
        {
            var p = serviceManager.PickupService.GetPickupById(id);
            return new PickupViewModel
            {
                Id = p.Id,
                Type = p.Type
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.PickupService.RemovePickupById(id);
        }

        public void Update(PickupViewModel pickup)
        {
            serviceManager.PickupService.UpdatePickup(new PickupDTO
            {
                Id = pickup.Id,
                Type = pickup.Type
            }) ;
        }
    }
}
