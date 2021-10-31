using MusicShop_Exam.Models.Size;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Size
{
    public class WebSizeService : IWebSizeService
    {
        readonly IServiceManager serviceManager;

        public WebSizeService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public void Create(SizeViewModel size)
        {
            serviceManager.SizeService.CreateNewSize(new SizeDTO
            {
                InstrumentSize = size.InstrumentSize
            });
        }

        public List<SizeViewModel> GetAll()
        {
            var sizes = serviceManager.SizeService.GetAllSizes();
            return sizes.Select((s) => new SizeViewModel
            {
                Id = s.Id,
                InstrumentSize = s.InstrumentSize

            }).ToList();
        }

        public SizeViewModel GetById(int id)
        {
            var s = serviceManager.SizeService.GetSizeById(id);
            return new SizeViewModel
            {
                Id = s.Id,
                InstrumentSize = s.InstrumentSize
            }; 
        }

        public void RemoveById(int id)
        {
            serviceManager.SizeService.RemoveSizeById(id);
        }

        public void Update(SizeViewModel size)
        {
            serviceManager.SizeService.UpdateSize(new SizeDTO
            {
                Id = size.Id,
                InstrumentSize = size.InstrumentSize
            });
        }
    }
}
