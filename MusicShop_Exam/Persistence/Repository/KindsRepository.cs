using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class KindsRepository:BaseRepository<int, Kind>
    {
        public KindsRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Kind Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var kind = Get(id);
            db.Entry(kind).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Kind entity)
        {
            var kind = Get(entity.Id);

            kind.Name = entity.Name;

            db.Entry(kind).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
