using MusicShop_Exam.Models.Pickup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Pickup
{
    public interface IWebPickupService
    {
        List<PickupViewModel> GetAll();
        PickupViewModel GetById(int id);
        void Update(PickupViewModel pickup);
        void Create(PickupViewModel pickup);
        void RemoveById(int id);
    }
}
