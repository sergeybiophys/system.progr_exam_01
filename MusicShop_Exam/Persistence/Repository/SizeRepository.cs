using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class SizeRepository:BaseRepository<int,Size>
    {
        public SizeRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Size Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var size = Get(id);
            db.Entry(size).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Size entity)
        {
            var size = Get(entity.Id);

            size.InstrumentSize = entity.InstrumentSize;

            db.Entry(size).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
