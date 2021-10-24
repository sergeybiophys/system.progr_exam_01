using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IGuitarTypeService
    {
        IEnumerable<GuitarTypeDTO> GetAllTypes();
        GuitarTypeDTO GetTypeById(int id);
        GuitarTypeDTO UpdateType(GuitarTypeDTO type);
        GuitarTypeDTO CreateNewType(GuitarTypeDTO type);
        void RemoveTypeById(int id);
    }
}
