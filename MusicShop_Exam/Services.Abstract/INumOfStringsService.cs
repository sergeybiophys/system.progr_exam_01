using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface INumOfStringsService
    {
        IEnumerable<NumberOfStringDTO> GetAllStrings();
        NumberOfStringDTO GetStringById(int id);
        NumberOfStringDTO UpdateString(NumberOfStringDTO strings);
        NumberOfStringDTO CreateNewString(NumberOfStringDTO strings);
        void RemoveStringById(int id);
    }
}
