using MusicShop_Exam.Services.Colour;
using MusicShop_Exam.Services.Kind;
using MusicShop_Exam.Services.Type;
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
        private readonly Lazy<IWebGuitarTypeService> _webGuitarTypeService;
        private readonly Lazy<IWebKindService> _webKindService;

        public WebServiceManager(IServiceManager serviceManager)
        {
            _webColourService = new Lazy<IWebColourService>(() => new WebColourService(serviceManager));
            _webManufacturerService = new Lazy<IWebManufacturerService>(() => new WebManufacturerService(serviceManager));
            _webGuitarTypeService = new Lazy<IWebGuitarTypeService>(() => new WebGuitarTypeService(serviceManager));
            _webKindService = new Lazy<IWebKindService>(() => new WebKindService(serviceManager));
        }


        public IWebManufacturerService webManufacturerService => _webManufacturerService.Value;

        public IWebColourService webColourService => _webColourService.Value;
        public IWebGuitarTypeService webGuitarTypeService => _webGuitarTypeService.Value;
        public IWebKindService webKindService => _webKindService.Value;
    }
}
