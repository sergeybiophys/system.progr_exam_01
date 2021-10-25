
using AutoMapper;
using Domain.Repository;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAccountService> _accountService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IColourService> _colourService;
        private readonly Lazy<IGuitarService> _guitarService;
        private readonly Lazy<IGuitarTypeService> _guitarTypeService;
        private readonly Lazy<IKindService> _kindService;
        private readonly Lazy<IManufacturerService> _manufacturerService;
        private readonly Lazy<INumOfFretsService> _numOfFretsService;
        private readonly Lazy<INumOfStringsService> _numOfStringsService;
        private readonly Lazy<IPickupService> _pickupService;
        private readonly Lazy<ISizeService> _sizeService;
        private readonly Lazy<IStatusService> _statusService;


        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _accountService = new Lazy<IAccountService>(() => new AccountService(unitOfWork, mapper));
 
        }

        public ICategoryService CategoryService => throw new NotImplementedException();

        public IColourService ColourService => throw new NotImplementedException();

        public IGuitarService GuitarService => throw new NotImplementedException();

        public IGuitarTypeService GuitarTypeService => throw new NotImplementedException();

        public IKindService KindService => throw new NotImplementedException();

        public IManufacturerService ManufacturerService => throw new NotImplementedException();

        public INumOfFretsService NumOfFretsService => throw new NotImplementedException();

        public INumOfStringsService NumOfStringsService => throw new NotImplementedException();

        public IPickupService PickupService => throw new NotImplementedException();

        public ISizeService SizeService => throw new NotImplementedException();

        public IStatusService StatusService => throw new NotImplementedException();

        public IAccountService AccountService => _accountService.Value;
    }
}
