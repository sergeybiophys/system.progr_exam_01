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
        IEnumerable<ManufacturerDTO> GetAllMnufaturers();
        ManufacturerDTO GetMnufaturerById(int id);
        ManufacturerDTO UpdateMnufaturer(ManufacturerDTO manufacturer);
        ManufacturerDTO CreateNewMnufaturer(ManufacturerDTO manufacturer);
        void RemoveMnufaturerById(int id);
    }
}
