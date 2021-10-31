using MusicShop_Exam.Services.Colour;
using MusicShop_Exam.Services.Fret;
using MusicShop_Exam.Services.Guitar;
using MusicShop_Exam.Services.Kind;
using MusicShop_Exam.Services.Pickup;
using MusicShop_Exam.Services.Size;
using MusicShop_Exam.Services.String;
using MusicShop_Exam.Services.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop_Exam.Services
{
    public interface IWebServiceManager
    {
        IWebManufacturerService webManufacturerService { get; }
        IWebColourService webColourService { get; }
        IWebGuitarTypeService webGuitarTypeService { get; }
        IWebKindService webKindService { get; } 
        IWebFretService webFretService { get; }
        IWebStringService webStringService { get; }
        IWebPickupService webPickupService { get;  }
        IWebSizeService webSizeService { get; }

        IWebGuitarService webGuitarService { get; }
    }
}
