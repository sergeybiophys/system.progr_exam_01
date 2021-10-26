using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class ManufacturerRepository:BaseRepository<int,Manufacturer>
    {
        public ManufacturerRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Manufacturer Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var manuf = Get(id);
            db.Entry(manuf).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Manufacturer entity)
        {
            var manuf = Get(entity.Id);

            manuf.Name = entity.Name;
            manuf.Guitars = entity.Guitars;

            db.Entry(manuf).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
