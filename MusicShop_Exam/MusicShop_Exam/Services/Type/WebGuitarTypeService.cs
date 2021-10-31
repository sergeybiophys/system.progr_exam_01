using MusicShop_Exam.Models.Type;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Type
{
    public class WebGuitarTypeService : IWebGuitarTypeService
    {
        readonly IServiceManager serviceManager;

        public WebGuitarTypeService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(GuitarTypeViewModel type)
        {
            serviceManager.GuitarTypeService.CreateNewType(new GuitarTypeDTO
            {
                Name = type.Name
            });
        }

        public List<GuitarTypeViewModel> GetAll()
        {
            var types = serviceManager.GuitarTypeService.GetAllTypes();
            return types.Select((t) => new GuitarTypeViewModel
            {
                Id = t.Id,
                Name = t.Name

            }).ToList();
        }

        public GuitarTypeViewModel GetById(int id)
        {
            var t = serviceManager.GuitarTypeService.GetTypeById(id);
            return new GuitarTypeViewModel
            {
                Id = t.Id,
                Name = t.Name
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.GuitarTypeService.RemoveTypeById(id);

        }

        public void Update(GuitarTypeViewModel type)
        {
            serviceManager.GuitarTypeService.UpdateType(new GuitarTypeDTO
            {
                Id = type.Id,
                Name = type.Name
            });
        }
    }
}
