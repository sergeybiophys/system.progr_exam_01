using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface INumOfFretsService
    {
        IEnumerable<NumberOfFretsDTO> GetAllFrets();
        NumberOfFretsDTO GetFretById(int id);
        NumberOfFretsDTO UpdateFret(NumberOfFretsDTO frets);
        NumberOfFretsDTO CreateNewFret(NumberOfFretsDTO frets);
        void RemoveFretById(int id);
    }
}
