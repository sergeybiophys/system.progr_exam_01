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
        public IRepository<int, Guitar> GuitarsRepository => throw new NotImplementedException();

        public IRepository<int, Category> CategoriesRepository => throw new NotImplementedException();

        public IRepository<int, Manufacturer> ManufacturersRepository => throw new NotImplementedException();

        public IRepository<int, Colour> ColoursRepository => throw new NotImplementedException();

        public IRepository<int, Kind> KindsRepository => throw new NotImplementedException();

        public IRepository<int, NumberOfFrets> FretsRepository => throw new NotImplementedException();

        public IRepository<int, NumberOfString> StringsRepository => throw new NotImplementedException();

        public IRepository<int, Pickup> PickupRepository => throw new NotImplementedException();

        public IRepository<int, Size> SizeRepository => throw new NotImplementedException();

        public IRepository<int, GuitarType> TypeRepository => throw new NotImplementedException();



        IRepository<int, Status> _statusesRepository;
        IRepository<int, Status> IUnitOfWork.StatusRepository
            => _statusesRepository ?? (_statusesRepository = new StatusRepository(db));


        IRepository<Guid, Account> _accountsRepository;
        IRepository<Guid, Account> IUnitOfWork.AccountRepository
            => _accountsRepository ?? (_accountsRepository = new AccountRepository(db));


        public void SaveChanges() => this.db.SaveChanges();
    }
}
