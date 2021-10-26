using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class GuitarRepository:BaseRepository<int,Guitar>
    {
        public GuitarRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override Guitar Get(int id)
            => Table.FirstOrDefault(a => a.Id == id);

        public override void Remove(int id)
        {
            var g = Get(id);
            db.Entry(g).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Guitar entity)
        {
            var g = Get(entity.Id);

            g.Name = entity.Name;
            g.Price = entity.Price;
            g.Quantity = entity.Quantity;
            g.Image = entity.Image;
            g.CategoryId = entity.CategoryId;
            g.ManufacturerId = entity.ManufacturerId;
            g.ColourId = entity.ColourId;
            g.GuitarTypeId = entity.GuitarTypeId;
            g.KindId = entity.KindId;
            g.NumberOfFretsId = entity.NumberOfFretsId;
            g.NumberOfStringId = entity.NumberOfStringId;
            g.PickupId = entity.PickupId;
            g.SizeId = entity.SizeId;
            g.Status = entity.Status;
 
            db.Entry(g).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
