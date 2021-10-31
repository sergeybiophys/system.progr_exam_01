using MusicShop_Exam.Models.Kind;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Kind
{
    public class WebKindService : IWebKindService
    {
        readonly IServiceManager serviceManager;

        public WebKindService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(KindViewModel kind)
        {
            serviceManager.KindService.CreateNewKind(new KindDTO
            {
                Name = kind.Name
            });
        }

        public List<KindViewModel> GetAll()
        {
            var kinds = serviceManager.KindService.GetAllKinds();
            return kinds.Select((k) => new KindViewModel
            {
                Id = k.Id,
                Name = k.Name

            }).ToList();
        }

        public KindViewModel GetById(int id)
        {
            var kind = serviceManager.KindService.GetKindById(id);
            return new KindViewModel
            {
                Id = kind.Id,
                Name = kind.Name
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.KindService.RemoveKindById(id);
        }

        public void Update(KindViewModel kind)
        {
            serviceManager.KindService.UpdateKind(new KindDTO
            {
                Id = kind.Id,
                Name = kind.Name
            });
        }
    }
}
