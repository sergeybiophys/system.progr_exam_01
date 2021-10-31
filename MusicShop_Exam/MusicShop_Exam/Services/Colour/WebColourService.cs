using MusicShop_Exam.Models.Colour;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.Colour
{
    public class WebColourService : IWebColourService
    {
        readonly IServiceManager serviceManager;

        public WebColourService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(ColourViewModel colour)
        {
            serviceManager.ColourService.CreateNewColour(new ColourDTO
            {
                Name = colour.Name
            });
        }

        public List<ColourViewModel> GetAll()
        {
            var colour = serviceManager.ColourService.GetAllColours();
            return colour.Select((c) => new ColourViewModel
            {
                Id = c.Id,
                Name = c.Name

            }).ToList();
        }

        public ColourViewModel GetById(int id)
        {
            var c = serviceManager.ColourService.GetColourById(id);
            return new ColourViewModel
            {
                Id = c.Id,
                Name = c.Name
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.ColourService.RemoveColourById(id);
        }

        public void Update(ColourViewModel colour)
        {
            serviceManager.ColourService.UpdateColour(new ColourDTO
            {
                Id = colour.Id,
                Name = colour.Name
            });
        }
    }
}
