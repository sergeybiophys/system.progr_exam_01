using MusicShop_Exam.Services.Colour;
using MusicShop_Exam.Services.Kind;
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
    }
}
