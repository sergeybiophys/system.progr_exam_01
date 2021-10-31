using MusicShop_Exam.Models.String;
using Services.Abstract;
using Services.Abstract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services.String
{
    public class WebStringService : IWebStringService
    {
        readonly IServiceManager serviceManager;

        public WebStringService(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }
        public void Create(StringViewModel @string)
        {
            serviceManager.NumOfStringsService.CreateNewString(new NumberOfStringDTO
            {
                Number = @string.Number
            });
        }

        public List<StringViewModel> GetAll()
        {
            var strings = serviceManager.NumOfStringsService.GetAllStrings();
            return strings.Select((s) => new StringViewModel
            {
                Id = s.Id,
                Number = s.Number

            }).ToList();
        }

        public StringViewModel GetById(int id)
        {
            var s = serviceManager.NumOfStringsService.GetStringById(id);
            return new StringViewModel
            {
                Id = s.Id,
                Number = s.Number
            };
        }

        public void RemoveById(int id)
        {
            serviceManager.NumOfStringsService.RemoveStringById(id);
        }

        public void Update(StringViewModel @string)
        {
            serviceManager.NumOfStringsService.UpdateString(new NumberOfStringDTO
            {
                Id = @string.Id,
                Number = @string.Number
            });
        }
    }
}
