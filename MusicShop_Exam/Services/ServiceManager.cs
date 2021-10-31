
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
            _manufacturerService = new Lazy<IManufacturerService>(()=> new ManufacturerService(unitOfWork, mapper));
            _colourService = new Lazy<IColourService>(() => new ColourService(unitOfWork, mapper));
            _guitarTypeService = new Lazy<IGuitarTypeService>(() => new GuitarTypeService(unitOfWork, mapper));
            _guitarService = new Lazy<IGuitarService>(() => new GuitarService(unitOfWork, mapper));
            _kindService = new Lazy<IKindService>(() => new KindService(unitOfWork, mapper));
            _numOfFretsService = new Lazy<INumOfFretsService>(() => new NumFretsService(unitOfWork, mapper));
            _numOfStringsService = new Lazy<INumOfStringsService>(() => new NumStringService(unitOfWork, mapper));
            _pickupService = new Lazy<IPickupService>(() => new PickupService(unitOfWork, mapper));
            _sizeService = new Lazy<ISizeService>(() => new SizeService(unitOfWork, mapper));
            _statusService = new Lazy<IStatusService>(() => new StatusService(unitOfWork, mapper));

            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(unitOfWork, mapper));
 
        }

        public ICategoryService CategoryService => _categoryService.Value;

        public IColourService ColourService => _colourService.Value;

        public IGuitarService GuitarService => _guitarService.Value;

        public IGuitarTypeService GuitarTypeService => _guitarTypeService.Value;

        public IKindService KindService => _kindService.Value;

        public IManufacturerService ManufacturerService => _manufacturerService.Value;

        public INumOfFretsService NumOfFretsService => _numOfFretsService.Value;

        public INumOfStringsService NumOfStringsService => _numOfStringsService.Value;

        public IPickupService PickupService => _pickupService.Value;

        public ISizeService SizeService => _sizeService.Value;

        public IStatusService StatusService => _statusService.Value;

        public IAccountService AccountService => _accountService.Value;
    }
}
