using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IStatusService
    {
        IEnumerable<StatusDTO> GetAllStatuses();
        StatusDTO GetStatusById(int id);
        StatusDTO UpdateStatus(StatusDTO staus);
        StatusDTO CreateNewStatus(StatusDTO status);
        void RemoveStatusById(int id);
    }
}
