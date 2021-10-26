using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class StringRepository:BaseRepository<int, NumberOfString>
    {
        public StringRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override NumberOfString Get(int id)
           => Table.FirstOrDefault(c => c.Id == id);

        public override void Remove(int id)
        {
            var size = Get(id);
            db.Entry(size).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }

        public override void Update(NumberOfString entity)
        {
            var size = Get(entity.Id);

            size.Number = entity.Number;

            db.Entry(size).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
