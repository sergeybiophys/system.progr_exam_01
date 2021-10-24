using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUnitOfWork
    {
        IRepository<int, Guitar> GuitarsRepository { get; }
        IRepository<int, Category> CategoriesRepository { get; }
        IRepository<int, Manufacturer> ManufacturersRepository { get; }
        IRepository<int, Colour> ColoursRepository { get; }
        IRepository<int, Kind> KindsRepository { get; }
        IRepository<int, NumberOfFrets> FretsRepository { get; }
        IRepository<int, NumberOfString> StringsRepository { get; }
        IRepository<int, Pickup> PickupRepository { get; }
        IRepository<int, Size> SizeRepository { get; }
        IRepository<int, GuitarType> TypeRepository { get; }
        IRepository<int, Status> StatusRepository { get; }

        void SaveChanges();



    }
}
