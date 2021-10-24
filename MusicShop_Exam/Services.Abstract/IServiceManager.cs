using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IServiceManager
    {
        ICategoryService CategoryService { get; }
        IColourService ColourService { get; }
        IGuitarService GuitarService { get; }
        IGuitarTypeService GuitarTypeService { get; }
        IKindService KindService { get; }
        IManufacturerService ManufacturerService { get; }
        INumOfFretsService NumOfFretsService { get; }
        INumOfStringsService NumOfStringsService { get; }
        IPickupService PickupService { get; }
        ISizeService SizeService { get; }
        IStatusService StatusService { get; }
    }
}
