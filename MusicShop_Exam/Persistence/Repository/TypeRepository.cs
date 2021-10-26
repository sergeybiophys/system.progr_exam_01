using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class TypeRepository:BaseRepository<int, GuitarType>
    {
        public TypeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override GuitarType Get(int id)
          => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var status = Get(id);
            db.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(GuitarType entity)
        {
            var status = Get(entity.Id);

            status.Name = entity.Name;

            db.Entry(status).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
