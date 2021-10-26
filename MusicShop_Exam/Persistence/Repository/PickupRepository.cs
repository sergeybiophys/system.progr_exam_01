using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class PickupRepository:BaseRepository<int,Pickup>
    {
        public PickupRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override Pickup Get(int id)
          => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var pickup = Get(id);
            db.Entry(pickup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Pickup entity)
        {
            var pickup = Get(entity.Id);

            pickup.Type = entity.Type;

            db.Entry(pickup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
