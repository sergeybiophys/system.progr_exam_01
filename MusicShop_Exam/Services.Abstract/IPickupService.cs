using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IPickupService
    {
        IEnumerable<PickupDTO> GetAllPickups();
        PickupDTO GetPickupById(int id);
        PickupDTO UpdatePickup(PickupDTO pickup);
        PickupDTO CreateNewPickup(PickupDTO pickup);
        void RemovePickupById(int id);
    }
}
