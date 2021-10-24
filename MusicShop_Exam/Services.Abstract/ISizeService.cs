using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ISizeService
    {
        IEnumerable<SizeDTO> GetAllSizes();
        SizeDTO GetSizeById(int id);
        SizeDTO UpdateSize(SizeDTO size);
        SizeDTO CreateNewSize(SizeDTO size);
        void RemoveSizeById(int id);
    }
}
