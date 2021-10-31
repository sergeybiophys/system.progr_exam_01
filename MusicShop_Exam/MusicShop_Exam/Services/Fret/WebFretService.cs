using MusicShop_Exam.Models.Fret;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Fret
{
    public class WebFretService : IWebFretService
    {
        readonly IServiceManager serviceManager;

        public WebFretService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(FretsViewModel fret)
        {
            serviceManager.NumOfFretsService.CreateNewFret(new NumberOfFretsDTO
            {
                Number = fret.Number
            }) ;
        }

        public List<FretsViewModel> GetAll()
        {
            var frets = serviceManager.NumOfFretsService.GetAllFrets();
            return frets.Select((f) => new FretsViewModel
            {
                Id = f.Id,
                Number = f.Number

            }).ToList();
        }

        public FretsViewModel GetById(int id)
        {
            var f = serviceManager.NumOfFretsService.GetFretById(id);
            return new FretsViewModel
            {
                Id = f.Id,
                Number = f.Number
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.NumOfFretsService.RemoveFretById(id);
        }

        public void Update(FretsViewModel fret)
        {
            serviceManager.NumOfFretsService.UpdateFret(new NumberOfFretsDTO
            {
                Id = fret.Id,
                Number = fret.Number
            });
        }
    }
}
