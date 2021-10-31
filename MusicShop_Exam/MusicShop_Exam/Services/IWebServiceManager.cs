using MusicShop_Exam.Services.Colour;
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
    }
}
