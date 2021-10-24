using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IColourService
    {
        IEnumerable<ColourDTO> GetAllColours();
        ColourDTO GetColourById(int id);
        ColourDTO UpdateColour(ColourDTO colour);
        ColourDTO CreateNewColour(ColourDTO colour);
        void RemoveColourById(int id);
    }
}
