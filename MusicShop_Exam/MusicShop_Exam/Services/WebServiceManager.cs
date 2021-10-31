using MusicShop_Exam.Services.Colour;
using MusicShop_Exam.Services.Fret;
using MusicShop_Exam.Services.Kind;
using MusicShop_Exam.Services.Pickup;
using MusicShop_Exam.Services.Size;
using MusicShop_Exam.Services.String;
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
        private readonly Lazy<IWebFretService> _webFretService;
        private readonly Lazy<IWebStringService> _webStringService;
        private readonly Lazy<IWebSizeService> _webSizeService;
        private readonly Lazy<IWebPickupService> _webPickupService;

        public WebServiceManager(IServiceManager serviceManager)
        {
            _webColourService = new Lazy<IWebColourService>(() => new WebColourService(serviceManager));
            _webManufacturerService = new Lazy<IWebManufacturerService>(() => new WebManufacturerService(serviceManager));
            _webGuitarTypeService = new Lazy<IWebGuitarTypeService>(() => new WebGuitarTypeService(serviceManager));
            _webKindService = new Lazy<IWebKindService>(() => new WebKindService(serviceManager));
            _webFretService = new Lazy<IWebFretService>(() => new WebFretService(serviceManager));
            _webStringService = new Lazy<IWebStringService>(() => new WebStringService(serviceManager));
            _webSizeService = new Lazy<IWebSizeService>(() => new WebSizeService(serviceManager));
            _webPickupService = new Lazy<IWebPickupService>(() => new WebPickupService(serviceManager));

        }


        public IWebManufacturerService webManufacturerService => _webManufacturerService.Value;

        public IWebColourService webColourService => _webColourService.Value;
        public IWebGuitarTypeService webGuitarTypeService => _webGuitarTypeService.Value;
        public IWebKindService webKindService => _webKindService.Value;
        public IWebFretService webFretService => _webFretService.Value;
        public IWebStringService webStringService => _webStringService.Value;
        public IWebPickupService webPickupService => _webPickupService.Value;
        public IWebSizeService webSizeService => _webSizeService.Value;

    }
}
