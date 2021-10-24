using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IGuitarService
    {
        IEnumerable<GuitarDTO> GetAllGuitars();
        GuitarDTO GetGuitarById(int id);
        GuitarDTO UpdateGuitar(GuitarDTO guitar);
        GuitarDTO CreateNewGuitar(GuitarDTO guitar);
        void RemoveGuitarById(int id);
    }
}
