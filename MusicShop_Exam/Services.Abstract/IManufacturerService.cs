using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IManufacturerService
    {
        IEnumerable<ManufacturerDTO> GetAllManufacturers();
        ManufacturerDTO GetManufacturerById(int id);
        ManufacturerDTO UpdateManufacturer(ManufacturerDTO manufacturer);
        ManufacturerDTO CreateNewManufacturer(ManufacturerDTO manufacturer);
        void RemoveManufacturerById(int id);
    }
}
