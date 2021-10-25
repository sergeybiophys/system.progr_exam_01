using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class StatusRepository : BaseRepository<int, Status>
    {
        public StatusRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Status Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var status = Get(id);
            db.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(Status entity)
        {
            var status = Get(entity.Id);

            status.Name = entity.Name;

            db.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
