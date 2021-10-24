using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IKindService
    {
        IEnumerable<KindDTO> GetAllKinds();
        KindDTO GetKindById(int id);
        KindDTO UpdateKind(KindDTO kind);
        KindDTO CreateNewKind(KindDTO kind);
        void RemoveKindById(int id);
    }
}
