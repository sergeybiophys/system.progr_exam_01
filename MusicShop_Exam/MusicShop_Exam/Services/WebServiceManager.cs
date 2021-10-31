using MusicShop_Exam.Services.Colour;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services
{
    public class WebServiceManager : IWebServiceManager
    {
        private readonly Lazy<IWebManufacturerService> _webManufacturerService;
        private readonly Lazy<IWebColourService> _webColourService;

        public WebServiceManager(IServiceManager serviceManager)
        {
            _webColourService = new Lazy<IWebColourService>(() => new WebColourService(serviceManager));
            _webManufacturerService = new Lazy<IWebManufacturerService>(() => new WebManufacturerService(serviceManager));
        }


        public IWebManufacturerService webManufacturerService => _webManufacturerService.Value;

        public IWebColourService webColourService => _webColourService.Value;
    }
}
