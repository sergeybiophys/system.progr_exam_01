using Domain.Entity;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext db;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.db = context;
        }



        IRepository<int, Guitar> _guitarRepository;
        IRepository<int, Guitar> IUnitOfWork.GuitarsRepository
            => _guitarRepository ?? (_guitarRepository = new GuitarRepository(db));


        IRepository<int, Category> _categoryRepository;
        IRepository<int, Category> IUnitOfWork.CategoriesRepository
            => _categoryRepository ?? (_categoryRepository = new CategoryRepository(db));


        IRepository<int, Manufacturer> _manufRepository;
        IRepository<int, Manufacturer> IUnitOfWork.ManufacturersRepository
            => _manufRepository ?? (_manufRepository = new ManufacturerRepository(db));


        IRepository<int, Colour> _colourRepository;
        IRepository<int, Colour> IUnitOfWork.ColoursRepository
            => _colourRepository ?? (_colourRepository = new ColourRepository(db));


        IRepository<int, Kind> _kindRepository;
        IRepository<int, Kind> IUnitOfWork.KindsRepository
            => _kindRepository ?? (_kindRepository = new KindsRepository(db));


        IRepository<int, NumberOfFrets> _fretsRepository;
        IRepository<int, NumberOfFrets> IUnitOfWork.FretsRepository
            => _fretsRepository ?? (_fretsRepository = new FretsRepository(db));


        IRepository<int, NumberOfString> _stringRepository;
        IRepository<int, NumberOfString> IUnitOfWork.StringsRepository
            => _stringRepository ?? (_stringRepository = new StringRepository(db));


        IRepository<int, Pickup> _pickupRepository;
        IRepository<int, Pickup> IUnitOfWork.PickupRepository
            => _pickupRepository ?? (_pickupRepository = new PickupRepository(db));


        IRepository<int, Size> _sizeRepository;
        IRepository<int, Size> IUnitOfWork.SizeRepository
            => _sizeRepository ?? (_sizeRepository = new SizeRepository(db));



        IRepository<int, GuitarType> _typeRepository;
        IRepository<int, GuitarType> IUnitOfWork.TypeRepository
            => _typeRepository ?? (_typeRepository = new TypeRepository(db));


        IRepository<int, Status> _statusesRepository;
        IRepository<int, Status> IUnitOfWork.StatusRepository
            => _statusesRepository ?? (_statusesRepository = new StatusRepository(db));


        IRepository<Guid, Account> _accountsRepository;
        IRepository<Guid, Account> IUnitOfWork.AccountRepository
            => _accountsRepository ?? (_accountsRepository = new AccountRepository(db));


        public void SaveChanges() => this.db.SaveChanges();
    }
}
